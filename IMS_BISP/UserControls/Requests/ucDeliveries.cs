using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Requests
{
    public partial class ucDeliveries : UserControl
    {
        private List<ProductRequest> _requests;

        public ucDeliveries()
        {
            InitializeComponent();
        }

        private void ucDeliveries_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!UserSession.StoreId.HasValue) return;
            try
            {
                _requests = RequestRepository.GetDeliveryHistory(UserSession.StoreId.Value);
                dgvDeliveries.DataSource = null;
                dgvDeliveries.DataSource = _requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load deliveries: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ProductRequest GetSelectedRequest()
        {
            if (dgvDeliveries.SelectedRows.Count == 0 || _requests == null) return null;
            int idx = dgvDeliveries.SelectedRows[0].Index;
            return (idx >= 0 && idx < _requests.Count) ? _requests[idx] : null;
        }

        private void dgvDeliveries_SelectionChanged(object sender, EventArgs e)
        {
            var r = GetSelectedRequest();
            bool isAccepted = r != null && r.Status == "ACCEPTED";
            btnMarkDelivered.Enabled    = isAccepted;
            btnMarkNotDelivered.Enabled = isAccepted;
        }

        private void dgvDeliveries_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_requests == null) return;
            for (int i = 0; i < dgvDeliveries.Rows.Count && i < _requests.Count; i++)
            {
                switch (_requests[i].Status)
                {
                    case "ACCEPTED":
                        dgvDeliveries.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 229, 252);
                        break;
                    case "DELIVERED":
                        dgvDeliveries.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                        break;
                    case "NOT_DELIVERED":
                        dgvDeliveries.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                        break;
                }
            }
        }

        private void btnMarkDelivered_Click(object sender, EventArgs e)
        {
            var r = GetSelectedRequest();
            if (r == null || r.Status != "ACCEPTED") return;

            var confirm = MessageBox.Show(
                $"Mark delivery of '{r.ProductName}' (Qty: {r.QuantityRequested}) to '{r.RequesterStoreName}' as Delivered?",
                "Confirm Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                RequestRepository.Respond(r.RequestId, "DELIVERED", null);
                AuditLogRepository.Insert(UserSession.UserId, "DELIVER_REQUEST",
                    $"Request ID {r.RequestId} for '{r.ProductName}' marked as delivered.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Mark as Delivered",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMarkNotDelivered_Click(object sender, EventArgs e)
        {
            var r = GetSelectedRequest();
            if (r == null || r.Status != "ACCEPTED") return;

            var confirm = MessageBox.Show(
                $"Mark delivery of '{r.ProductName}' (Qty: {r.QuantityRequested}) to '{r.RequesterStoreName}' as Not Delivered?",
                "Confirm Not Delivered", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                RequestRepository.Respond(r.RequestId, "NOT_DELIVERED", null);
                AuditLogRepository.Insert(UserSession.UserId, "NOT_DELIVER_REQUEST",
                    $"Request ID {r.RequestId} for '{r.ProductName}' marked as not delivered.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot Mark as Not Delivered",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
