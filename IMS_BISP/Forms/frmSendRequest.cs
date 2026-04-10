using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmSendRequest : Form
    {
        public int     SelectedQuantity { get; private set; }
        public decimal SelectedPrice    { get; private set; }

        private int    _availableQty;
        private string _storeName;

        public frmSendRequest(Product product)
        {
            InitializeComponent();
            _availableQty       = product.Quantity;
            _storeName          = product.StoreName;
            lblProductVal.Text  = $"{product.ProductName} ({product.SKU})";
            lblSupplierVal.Text = product.StoreName;
            lblPriceVal.Text    = product.UnitPrice.ToString("N2");
            nudProposedPrice.Value = product.UnitPrice;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value < 1)
            {
                MessageBox.Show("Quantity must be at least 1.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantity.Focus();
                return;
            }
            if (nudQuantity.Value > _availableQty)
            {
                MessageBox.Show(
                    $"Cannot request {(int)nudQuantity.Value} units — only {_availableQty} available from \"{_storeName}\".",
                    "Quantity Exceeds Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudQuantity.Focus();
                return;
            }
            if (nudProposedPrice.Value <= 0)
            {
                MessageBox.Show("Proposed price must be greater than zero.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudProposedPrice.Focus();
                return;
            }

            SelectedQuantity = (int)nudQuantity.Value;
            SelectedPrice    = nudProposedPrice.Value;
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
