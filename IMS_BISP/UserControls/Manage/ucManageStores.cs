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
    public partial class ucManageStores : UserControl
    {
        private List<Store> _stores;

        public ucManageStores()
        {
            InitializeComponent();
            SetupGrid();
            btnEdit.Enabled         = false;
            btnToggleActive.Enabled = false;
        }

        private void SetupGrid()
        {
            dgvStores.AutoGenerateColumns = false;
            dgvStores.Columns.Clear();

            dgvStores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStoreId", HeaderText = "ID",
                DataPropertyName = "StoreId",
                FillWeight = 5, MinimumWidth = 45
            });
            dgvStores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStoreName", HeaderText = "Store Name",
                DataPropertyName = "StoreName",
                FillWeight = 35, MinimumWidth = 150
            });
            dgvStores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhone", HeaderText = "Contact Phone",
                DataPropertyName = "ContactPhone",
                FillWeight = 20, MinimumWidth = 120
            });
            dgvStores.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive", HeaderText = "Active",
                DataPropertyName = "IsActive",
                FillWeight = 8, MinimumWidth = 60
            });
            dgvStores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCreatedAt", HeaderText = "Created At",
                DataPropertyName = "CreatedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm" },
                FillWeight = 20, MinimumWidth = 130
            });

            dgvStores.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvStores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvStores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStores.EnableHeadersVisualStyles               = false;
            dgvStores.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvStores.RowTemplate.Height                      = 28;
        }

        private void ucManageStores_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _stores = StoreRepository.GetAll();
                dgvStores.DataSource = null;
                dgvStores.DataSource = _stores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load stores: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Store GetSelectedStore()
        {
            if (_stores == null || dgvStores.SelectedRows.Count == 0) return null;
            int idx = dgvStores.SelectedRows[0].Index;
            return (idx >= 0 && idx < _stores.Count) ? _stores[idx] : null;
        }

        private void dgvStores_SelectionChanged(object sender, EventArgs e)
        {
            var store = GetSelectedStore();
            bool hasSelection         = store != null;
            btnEdit.Enabled           = hasSelection;
            btnToggleActive.Enabled   = hasSelection;
            if (hasSelection)
            {
                btnToggleActive.Text      = store.IsActive ? "Deactivate" : "Activate";
                btnToggleActive.BackColor = store.IsActive
                    ? Color.FromArgb(192, 57, 43)
                    : Color.FromArgb(39, 174, 96);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmAddEditStore())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    int newId = StoreRepository.Insert(dlg.StoreName, dlg.ContactPhone);
                    AuditLogRepository.Insert(UserSession.UserId, "ADD_STORE",
                        $"Store '{dlg.StoreName}' added (ID: {newId}).");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add store: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var store = GetSelectedStore();
            if (store == null)
            {
                MessageBox.Show("Please select a store to edit.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new frmAddEditStore(store))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    StoreRepository.Update(store.StoreId, dlg.StoreName, dlg.ContactPhone);
                    AuditLogRepository.Insert(UserSession.UserId, "EDIT_STORE",
                        $"Store ID {store.StoreId} updated to '{dlg.StoreName}'.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update store: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            var store = GetSelectedStore();
            if (store == null)
            {
                MessageBox.Show("Please select a store.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool newStatus = !store.IsActive;
            string action  = newStatus ? "activate" : "deactivate";

            var confirm = MessageBox.Show(
                $"Are you sure you want to {action} '{store.StoreName}'?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                StoreRepository.SetActiveStatus(store.StoreId, newStatus);
                AuditLogRepository.Insert(UserSession.UserId,
                    newStatus ? "ACTIVATE_STORE" : "DEACTIVATE_STORE",
                    $"Store '{store.StoreName}' (ID: {store.StoreId}) {action}d.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to {action} store: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
