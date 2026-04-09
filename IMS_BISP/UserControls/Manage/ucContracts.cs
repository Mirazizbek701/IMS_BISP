using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Forms;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Manage
{
    public partial class ucContracts : UserControl
    {
        private List<Contract> _contracts;

        public ucContracts()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvContracts.AutoGenerateColumns = false;
            dgvContracts.Columns.Clear();

            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colContractId", HeaderText = "ID",
                DataPropertyName = "ContractId",
                Visible = false
            });
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStoreName", HeaderText = "Store Name",
                DataPropertyName = "StoreName",
                FillWeight = 25, MinimumWidth = 140
            });
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStartDate", HeaderText = "Start Date",
                DataPropertyName = "StartDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" },
                FillWeight = 15, MinimumWidth = 100
            });
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEndDate", HeaderText = "End Date",
                DataPropertyName = "EndDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" },
                FillWeight = 15, MinimumWidth = 100
            });
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMonthlyRent", HeaderText = "Monthly Rent",
                DataPropertyName = "MonthlyRent",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "$ #,##0.00", Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 18, MinimumWidth = 120
            });
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colContractFile", HeaderText = "Contract File",
                DataPropertyName = "ContractFile",
                FillWeight = 20, MinimumWidth = 130
            });
            dgvContracts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDaysLeft", HeaderText = "Days Left",
                DataPropertyName = "DaysLeft",
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter },
                FillWeight = 10, MinimumWidth = 80
            });

            dgvContracts.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvContracts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvContracts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvContracts.EnableHeadersVisualStyles               = false;
            dgvContracts.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvContracts.RowTemplate.Height                      = 28;
        }

        private void ucContracts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _contracts = ContractRepository.GetAll();
                dgvContracts.DataSource = null;
                dgvContracts.DataSource = _contracts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load contracts: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Contract GetSelectedContract()
        {
            if (_contracts == null || dgvContracts.SelectedRows.Count == 0) return null;
            int idx = dgvContracts.SelectedRows[0].Index;
            return (idx >= 0 && idx < _contracts.Count) ? _contracts[idx] : null;
        }

        private void dgvContracts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || _contracts == null || e.RowIndex >= _contracts.Count) return;

            var contract = _contracts[e.RowIndex];

            if (contract.DaysLeft <= 15)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 204, 204);
                e.CellStyle.ForeColor = Color.FromArgb(150, 0, 0);
            }

            if (dgvContracts.Columns[e.ColumnIndex].Name == "colContractFile" && e.Value != null)
            {
                string val = e.Value.ToString();
                e.Value = string.IsNullOrEmpty(val) ? "" : Path.GetFileName(val);
                e.FormattingApplied = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmAddEditContract())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    int newId = ContractRepository.Insert(
                        dlg.SelectedStoreId,
                        dlg.SelectedStartDate,
                        dlg.SelectedEndDate,
                        dlg.SelectedMonthlyRent,
                        dlg.SelectedFilePath);
                    AuditLogRepository.Insert(UserSession.UserId, "ADD_CONTRACT",
                        $"Contract added for store ID {dlg.SelectedStoreId} (Contract ID: {newId}).");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add contract: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var contract = GetSelectedContract();
            if (contract == null)
            {
                MessageBox.Show("Please select a contract to edit.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new frmAddEditContract(contract))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    ContractRepository.Update(
                        contract.ContractId,
                        dlg.SelectedStoreId,
                        dlg.SelectedStartDate,
                        dlg.SelectedEndDate,
                        dlg.SelectedMonthlyRent,
                        dlg.SelectedFilePath);
                    AuditLogRepository.Insert(UserSession.UserId, "EDIT_CONTRACT",
                        $"Contract ID {contract.ContractId} updated.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update contract: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var contract = GetSelectedContract();
            if (contract == null)
            {
                MessageBox.Show("Please select a contract to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete the contract for '{contract.StoreName}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                ContractRepository.Delete(contract.ContractId);
                AuditLogRepository.Insert(UserSession.UserId, "DELETE_CONTRACT",
                    $"Contract ID {contract.ContractId} for store '{contract.StoreName}' deleted.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete contract: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var contract = GetSelectedContract();
            if (contract == null)
            {
                MessageBox.Show("Please select a contract.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(contract.ContractFile))
            {
                MessageBox.Show("No file is attached to this contract.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(contract.ContractFile))
            {
                MessageBox.Show("File not found:\n" + contract.ContractFile, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(contract.ContractFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open file: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
