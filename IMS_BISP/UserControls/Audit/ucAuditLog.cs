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
            dgvAuditLog.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvAuditLog.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvAuditLog.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAuditLog.EnableHeadersVisualStyles = false;
            dgvAuditLog.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvAuditLog.RowTemplate.Height = 28;
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
