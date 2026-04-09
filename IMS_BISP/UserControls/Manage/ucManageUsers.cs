using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Forms;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Manage
{
    public partial class ucManageUsers : UserControl
    {
        private List<User> _users;

        public ucManageUsers()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUserId", HeaderText = "ID",
                DataPropertyName = "UserId",
                FillWeight = 5, MinimumWidth = 45
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName", HeaderText = "Full Name",
                DataPropertyName = "FullName",
                FillWeight = 25, MinimumWidth = 140
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsername", HeaderText = "Username",
                DataPropertyName = "Username",
                FillWeight = 18, MinimumWidth = 110
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRoleName", HeaderText = "Role",
                DataPropertyName = "RoleName",
                FillWeight = 18, MinimumWidth = 110
            });
            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStoreName", HeaderText = "Store",
                DataPropertyName = "StoreName",
                FillWeight = 22, MinimumWidth = 130
            });
            dgvUsers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive", HeaderText = "Active",
                DataPropertyName = "IsActive",
                FillWeight = 7, MinimumWidth = 60
            });

            dgvUsers.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.EnableHeadersVisualStyles               = false;
            dgvUsers.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvUsers.RowTemplate.Height                      = 28;
        }

        private void ucManageUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _users = UserRepository.GetAll();
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private User GetSelectedUser()
        {
            if (_users == null || dgvUsers.SelectedRows.Count == 0) return null;
            int idx = dgvUsers.SelectedRows[0].Index;
            return (idx >= 0 && idx < _users.Count) ? _users[idx] : null;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user != null)
            {
                btnToggleActive.Text      = user.IsActive ? "Deactivate" : "Activate";
                btnToggleActive.BackColor = user.IsActive
                    ? Color.FromArgb(192, 57, 43)
                    : Color.FromArgb(39, 174, 96);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmAddEditUser())
            {
                if (dlg.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
                try
                {
                    int newId = UserRepository.Insert(
                        dlg.SelectedStoreId, dlg.SelectedRoleId,
                        dlg.Username, dlg.Password, dlg.FullName);
                    AuditLogRepository.Insert(UserSession.UserId, "ADD_USER",
                        $"User '{dlg.Username}' ('{dlg.FullName}') added (ID: {newId}).");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add user: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user to edit.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new frmAddEditUser(user))
            {
                if (dlg.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
                try
                {
                    UserRepository.UpdateDetails(user.UserId, dlg.FullName,
                        dlg.SelectedRoleId, dlg.SelectedStoreId);
                    AuditLogRepository.Insert(UserSession.UserId, "EDIT_USER",
                        $"User ID {user.UserId} ('{user.Username}') details updated.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update user: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool newStatus = !user.IsActive;
            string action  = newStatus ? "activate" : "deactivate";

            var confirm = MessageBox.Show(
                $"Are you sure you want to {action} user '{user.FullName}'?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != System.Windows.Forms.DialogResult.Yes) return;

            try
            {
                UserRepository.SetActiveStatus(user.UserId, newStatus);
                AuditLogRepository.Insert(UserSession.UserId,
                    newStatus ? "ACTIVATE_USER" : "DEACTIVATE_USER",
                    $"User '{user.Username}' (ID: {user.UserId}) {action}d.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to {action} user: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new frmResetPassword())
            {
                if (dlg.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
                try
                {
                    UserRepository.UpdatePassword(user.UserId, dlg.NewPassword);
                    AuditLogRepository.Insert(UserSession.UserId, "RESET_PASSWORD",
                        $"Password reset for user '{user.Username}' (ID: {user.UserId}).");
                    MessageBox.Show("Password reset successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to reset password: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
