using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Forms;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Products
{
    public partial class ucProducts : UserControl
    {
        private List<Product> _allProducts;
        private List<Product> _filtered;

        public ucProducts()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductId", HeaderText = "ID",
                DataPropertyName = "ProductId",
                Visible = false
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSKU", HeaderText = "SKU",
                DataPropertyName = "SKU",
                FillWeight = 10, MinimumWidth = 80
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductName", HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                FillWeight = 22, MinimumWidth = 150
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoryName", HeaderText = "Category",
                DataPropertyName = "CategoryName",
                FillWeight = 14, MinimumWidth = 100
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity", HeaderText = "Qty",
                DataPropertyName = "Quantity",
                FillWeight = 6, MinimumWidth = 50
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnitPrice", HeaderText = "Unit Price",
                DataPropertyName = "UnitPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                FillWeight = 10, MinimumWidth = 80
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMinThreshold", HeaderText = "Min Threshold",
                DataPropertyName = "MinThreshold",
                FillWeight = 10, MinimumWidth = 90
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colVisibility", HeaderText = "Visibility",
                DataPropertyName = "Visibility",
                FillWeight = 9, MinimumWidth = 70
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUpdatedAt", HeaderText = "Updated At",
                DataPropertyName = "UpdatedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm" },
                FillWeight = 14, MinimumWidth = 120
            });

            dgvProducts.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.EnableHeadersVisualStyles               = false;
            dgvProducts.DefaultCellStyle.Font                   = new Font("Segoe UI", 9F);
            dgvProducts.RowTemplate.Height                      = 28;
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _allProducts = ProductRepository.GetByStore(UserSession.StoreId.Value);
                _filtered    = _allProducts;
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = _filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count == 0 || _filtered == null) return null;
            int idx = dgvProducts.SelectedRows[0].Index;
            return (idx >= 0 && idx < _filtered.Count) ? _filtered[idx] : null;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            var p = GetSelectedProduct();
            if (p != null)
            {
                btnToggleVisibility.Text      = p.Visibility == "PUBLIC" ? "Make Private" : "Make Public";
                btnToggleVisibility.BackColor = p.Visibility == "PUBLIC"
                    ? Color.FromArgb(142, 68, 173)
                    : Color.FromArgb(41, 128, 185);
            }
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (_filtered == null) return;
            for (int i = 0; i < dgvProducts.Rows.Count && i < _filtered.Count; i++)
            {
                var p = _filtered[i];
                if (p.Quantity <= p.MinThreshold)
                    dgvProducts.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
            }
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
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _filtered;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            _filtered = _allProducts;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _filtered;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmAddEditProduct())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    int newId = ProductRepository.Insert(
                        UserSession.StoreId.Value, dlg.SelectedCategoryId,
                        dlg.ProductName, dlg.SKU, dlg.Quantity,
                        dlg.UnitPrice, dlg.MinThreshold, dlg.Visibility, dlg.Description);
                    AuditLogRepository.Insert(UserSession.UserId, "ADD_PRODUCT",
                        $"Product '{dlg.ProductName}' (SKU: {dlg.SKU}) added (ID: {newId}).");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add product: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Please select a product to edit.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new frmAddEditProduct(p))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    ProductRepository.Update(
                        p.ProductId, dlg.SelectedCategoryId,
                        dlg.ProductName, dlg.SKU, dlg.Quantity,
                        dlg.UnitPrice, dlg.MinThreshold, dlg.Visibility, dlg.Description);
                    AuditLogRepository.Insert(UserSession.UserId, "EDIT_PRODUCT",
                        $"Product ID {p.ProductId} updated to '{dlg.ProductName}'.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update product: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Please select a product to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete product '{p.ProductName}'? This cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                ProductRepository.SoftDelete(p.ProductId);
                AuditLogRepository.Insert(UserSession.UserId, "DELETE_PRODUCT",
                    $"Product '{p.ProductName}' (ID: {p.ProductId}) deleted.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete product: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleVisibility_Click(object sender, EventArgs e)
        {
            var p = GetSelectedProduct();
            if (p == null)
            {
                MessageBox.Show("Please select a product.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string newVis = p.Visibility == "PUBLIC" ? "PRIVATE" : "PUBLIC";
            try
            {
                ProductRepository.ToggleVisibility(p.ProductId, newVis);
                AuditLogRepository.Insert(UserSession.UserId, "TOGGLE_VISIBILITY",
                    $"Product '{p.ProductName}' (ID: {p.ProductId}) set to {newVis}.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change visibility: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbxSearch.Clear();
            LoadData();
        }
    }
}
