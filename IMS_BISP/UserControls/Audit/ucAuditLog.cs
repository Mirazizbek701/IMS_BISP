using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Audit
{
    public partial class ucAuditLog : UserControl
    {
        private List<AuditLog> _logs;

        public ucAuditLog()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvAuditLog.AutoGenerateColumns = false;
            dgvAuditLog.Columns.Clear();

            dgvAuditLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLogId", HeaderText = "ID",
                DataPropertyName = "LogId",
                FillWeight = 5, MinimumWidth = 45
            });
            dgvAuditLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsername", HeaderText = "Username",
                DataPropertyName = "Username",
                FillWeight = 14, MinimumWidth = 100
            });
            dgvAuditLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName", HeaderText = "Full Name",
                DataPropertyName = "FullName",
                FillWeight = 18, MinimumWidth = 130
            });
            dgvAuditLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colActionType", HeaderText = "Action",
                DataPropertyName = "ActionType",
                FillWeight = 14, MinimumWidth = 110
            });
            dgvAuditLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colActionDetail", HeaderText = "Detail",
                DataPropertyName = "ActionDetail",
                FillWeight = 36, MinimumWidth = 200
            });
            dgvAuditLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLoggedAt", HeaderText = "Logged At",
                DataPropertyName = "LoggedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm:ss" },
                FillWeight = 16, MinimumWidth = 140
            });

            dgvAuditLog.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAuditLog.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvAuditLog.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAuditLog.EnableHeadersVisualStyles               = false;
            dgvAuditLog.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvAuditLog.RowTemplate.Height                      = 28;
        }

        private void ucAuditLog_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _logs = AuditLogRepository.GetAll();
                dgvAuditLog.DataSource = null;
                dgvAuditLog.DataSource = _logs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load audit log: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
