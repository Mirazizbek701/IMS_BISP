using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmAddEditProduct : Form
    {
        public bool   IsEditMode    { get; private set; }
        public int    ProductId     { get; private set; }
        public string ProductName   => tbxProductName.Text.Trim();
        public string SKU           => tbxSKU.Text.Trim();
        public int    SelectedCategoryId => (cmbCategory.SelectedItem as Category)?.CategoryId ?? 0;
        public int    Quantity      => (int)nudQuantity.Value;
        public decimal UnitPrice    => nudUnitPrice.Value;
        public int    MinThreshold  => (int)nudMinThreshold.Value;
        public string Visibility    => rbPublic.Checked ? "PUBLIC" : "PRIVATE";
        public string Description   => tbxDescription.Text.Trim();

        public frmAddEditProduct()
        {
            InitializeComponent();
            IsEditMode = false;
            this.Load += frmAddEditProduct_Load;
        }

        public frmAddEditProduct(Product product) : this()
        {
            IsEditMode           = true;
            ProductId            = product.ProductId;
            lblFormTitle.Text    = "Edit Product";
            tbxProductName.Text  = product.ProductName;
            tbxSKU.Text          = product.SKU;
            nudQuantity.Value    = product.Quantity;
            nudUnitPrice.Value   = product.UnitPrice;
            nudMinThreshold.Value = product.MinThreshold;
            rbPublic.Checked     = product.Visibility == "PUBLIC";
            rbPrivate.Checked    = product.Visibility == "PRIVATE";
            tbxDescription.Text  = product.Description ?? string.Empty;
            this.Tag = product.CategoryId;
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                var categories = CategoryRepository.GetAll();
                cmbCategory.DataSource    = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember   = "CategoryId";

                if (IsEditMode && this.Tag is int catId)
                {
                    foreach (Category c in categories)
                    {
                        if (c.CategoryId == catId)
                        {
                            cmbCategory.SelectedItem = c;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxProductName.Text))
            {
                MessageBox.Show("Product Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxProductName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxSKU.Text))
            {
                MessageBox.Show("SKU is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxSKU.Focus();
                return;
            }
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
