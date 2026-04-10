using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Requests
{
    public partial class ucSentRequests : UserControl
    {
        private List<ProductRequest> _requests;

        public ucSentRequests()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvSentRequests.AutoGenerateColumns = false;
            dgvSentRequests.Columns.Clear();

            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRequestId", HeaderText = "ID",
                DataPropertyName = "RequestId",
                FillWeight = 5, MinimumWidth = 45
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductName", HeaderText = "Product",
                DataPropertyName = "ProductName",
                FillWeight = 22, MinimumWidth = 140
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSKU", HeaderText = "SKU",
                DataPropertyName = "SKU",
                FillWeight = 10, MinimumWidth = 80
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSupplierStore", HeaderText = "Supplier Store",
                DataPropertyName = "SupplierStoreName",
                FillWeight = 18, MinimumWidth = 120
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity", HeaderText = "Qty",
                DataPropertyName = "QuantityRequested",
                FillWeight = 6, MinimumWidth = 50
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProposedPrice", HeaderText = "Proposed Price",
                DataPropertyName = "ProposedPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                FillWeight = 12, MinimumWidth = 100
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStatus", HeaderText = "Status",
                DataPropertyName = "Status",
                FillWeight = 9, MinimumWidth = 75
            });
            dgvSentRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCreatedAt", HeaderText = "Sent At",
                DataPropertyName = "CreatedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm" },
                FillWeight = 14, MinimumWidth = 120
            });

            dgvSentRequests.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSentRequests.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvSentRequests.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSentRequests.EnableHeadersVisualStyles               = false;
            dgvSentRequests.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvSentRequests.RowTemplate.Height                      = 28;
        }

        private void ucSentRequests_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (!UserSession.StoreId.HasValue) return;
            try
            {
                _requests = RequestRepository.GetByRequester(UserSession.StoreId.Value);
                dgvSentRequests.DataSource = null;
                dgvSentRequests.DataSource = _requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load sent requests: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSentRequests_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_requests == null) return;
            for (int i = 0; i < dgvSentRequests.Rows.Count && i < _requests.Count; i++)
            {
                switch (_requests[i].Status)
                {
                    case "PENDING":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        break;
                    case "ACCEPTED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                        break;
                    case "REJECTED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                        break;
                    case "DELIVERED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(178, 223, 138);
                        break;
                    case "NOT_DELIVERED":
                        dgvSentRequests.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 171, 145);
                        break;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
