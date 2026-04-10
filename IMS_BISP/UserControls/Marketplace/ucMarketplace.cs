using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Forms;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Marketplace
{
    public partial class ucMarketplace : UserControl
    {
        private List<Product> _allProducts;
        private List<Product> _filtered;

        public ucMarketplace()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvMarketplace.AutoGenerateColumns = false;
            dgvMarketplace.Columns.Clear();

            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductId", HeaderText = "ID",
                DataPropertyName = "ProductId",
                Visible = false
            });
            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSKU", HeaderText = "SKU",
                DataPropertyName = "SKU",
                FillWeight = 10, MinimumWidth = 80
            });
            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductName", HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                FillWeight = 22, MinimumWidth = 150
            });
            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoryName", HeaderText = "Category",
                DataPropertyName = "CategoryName",
                FillWeight = 12, MinimumWidth = 90
            });
            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStoreName", HeaderText = "Supplier Store",
                DataPropertyName = "StoreName",
                FillWeight = 18, MinimumWidth = 130
            });
            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity", HeaderText = "Available Qty",
                DataPropertyName = "Quantity",
                FillWeight = 10, MinimumWidth = 80
            });
            dgvMarketplace.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnitPrice", HeaderText = "Listed Price",
                DataPropertyName = "UnitPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                FillWeight = 12, MinimumWidth = 90
            });

            dgvMarketplace.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvMarketplace.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvMarketplace.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMarketplace.EnableHeadersVisualStyles               = false;
            dgvMarketplace.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvMarketplace.RowTemplate.Height                      = 28;
        }

        private void ucMarketplace_Load(object sender, EventArgs e)
        {
            if (UserSession.IsStaff())
                btnRequestProduct.Visible = false;

            LoadData();
        }

        private void LoadData()
        {
            if (!UserSession.StoreId.HasValue) return;
            try
            {
                _allProducts = ProductRepository.GetPublicExcludingStore(UserSession.StoreId.Value);
                _filtered    = _allProducts;
                dgvMarketplace.DataSource = null;
                dgvMarketplace.DataSource = _filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load marketplace: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Product GetSelectedProduct()
        {
            if (dgvMarketplace.SelectedRows.Count == 0 || _filtered == null) return null;
            int idx = dgvMarketplace.SelectedRows[0].Index;
            return (idx >= 0 && idx < _filtered.Count) ? _filtered[idx] : null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = tbxSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(term))
            {
                _filtered = _allProducts;
            }
            else
            {
                _filtered = _allProducts
                    .Where(p => p.ProductName.ToLower().Contains(term) ||
                                p.SKU.ToLower().Contains(term))
                    .ToList();
            }
            dgvMarketplace.DataSource = null;
            dgvMarketplace.DataSource = _filtered;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            _filtered = _allProducts;
            dgvMarketplace.DataSource = null;
            dgvMarketplace.DataSource = _filtered;
        }

        private void btnRequestProduct_Click(object sender, EventArgs e)
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Please select a product to request.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new frmSendRequest(p))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    int newId = RequestRepository.Insert(
                        UserSession.StoreId.Value, p.StoreId,
                        p.ProductId, dlg.SelectedQuantity, dlg.SelectedPrice);
                    AuditLogRepository.Insert(UserSession.UserId, "SEND_REQUEST",
                        $"Request sent for '{p.ProductName}' (ID: {p.ProductId}) to store '{p.StoreName}'. RequestId: {newId}.");
                    MessageBox.Show("Request sent successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Request Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            LoadData();
        }
    }
}
