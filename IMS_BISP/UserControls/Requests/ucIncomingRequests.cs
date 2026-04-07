using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Forms;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Requests
{
    public partial class ucIncomingRequests : UserControl
    {
        private List<ProductRequest> _requests;

        public ucIncomingRequests()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvIncomingRequests.AutoGenerateColumns = false;
            dgvIncomingRequests.Columns.Clear();

            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRequestId", HeaderText = "ID",
                DataPropertyName = "RequestId",
                FillWeight = 5, MinimumWidth = 45
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductName", HeaderText = "Product",
                DataPropertyName = "ProductName",
                FillWeight = 20, MinimumWidth = 130
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSKU", HeaderText = "SKU",
                DataPropertyName = "SKU",
                FillWeight = 9, MinimumWidth = 75
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRequesterStore", HeaderText = "Requester Store",
                DataPropertyName = "RequesterStoreName",
                FillWeight = 18, MinimumWidth = 120
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity", HeaderText = "Qty",
                DataPropertyName = "QuantityRequested",
                FillWeight = 6, MinimumWidth = 50
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colListedPrice", HeaderText = "Listed Price",
                DataPropertyName = "OwnListedPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                FillWeight = 11, MinimumWidth = 90
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProposedPrice", HeaderText = "Proposed Price",
                DataPropertyName = "ProposedPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                FillWeight = 11, MinimumWidth = 95
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus", HeaderText = "Status",
                DataPropertyName = "Status",
                FillWeight = 9, MinimumWidth = 75
            });
            dgvIncomingRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCreatedAt", HeaderText = "Received At",
                DataPropertyName = "CreatedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm" },
                FillWeight = 13, MinimumWidth = 110
            });

            dgvIncomingRequests.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvIncomingRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvIncomingRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIncomingRequests.EnableHeadersVisualStyles               = false;
            dgvIncomingRequests.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvIncomingRequests.RowTemplate.Height                      = 28;
        }

        private void ucIncomingRequests_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _requests = RequestRepository.GetBySupplier(UserSession.StoreId.Value);
                dgvIncomingRequests.DataSource = null;
                dgvIncomingRequests.DataSource = _requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load incoming requests: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ProductRequest GetSelectedRequest()
        {
            if (dgvIncomingRequests.SelectedRows.Count == 0 || _requests == null) return null;
            int idx = dgvIncomingRequests.SelectedRows[0].Index;
            return (idx >= 0 && idx < _requests.Count) ? _requests[idx] : null;
        }

        private void dgvIncomingRequests_SelectionChanged(object sender, EventArgs e)
        {
            var r = GetSelectedRequest();
            bool isPending = r != null && r.Status == "PENDING";
            btnAccept.Enabled = isPending;
            btnReject.Enabled = isPending;
        }

        private void dgvIncomingRequests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_requests == null) return;
            for (int i = 0; i < dgvIncomingRequests.Rows.Count && i < _requests.Count; i++)
            {
                switch (_requests[i].Status)
                {
                    case "PENDING":
                        dgvIncomingRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        break;
                    case "ACCEPTED":
                        dgvIncomingRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                        break;
                    case "REJECTED":
                        dgvIncomingRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                        break;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var r = GetSelectedRequest();
            if (r == null || r.Status != "PENDING") return;

            var confirm = MessageBox.Show(
                $"Accept request for '{r.ProductName}' (Qty: {r.QuantityRequested}) from '{r.RequesterStoreName}'?",
                "Confirm Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                RequestRepository.Respond(r.RequestId, "ACCEPTED", null);
                AuditLogRepository.Insert(UserSession.UserId, "ACCEPT_REQUEST",
                    $"Request ID {r.RequestId} for '{r.ProductName}' accepted.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to accept request: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            var r = GetSelectedRequest();
            if (r == null || r.Status != "PENDING") return;

            using (var dlg = new frmRejectRequest())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    RequestRepository.Respond(r.RequestId, "REJECTED", dlg.RejectionNote);
                    AuditLogRepository.Insert(UserSession.UserId, "REJECT_REQUEST",
                        $"Request ID {r.RequestId} for '{r.ProductName}' rejected. Note: {dlg.RejectionNote}");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to reject request: " + ex.Message,
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
