using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmSendRequest : Form
    {
        public int     SelectedQuantity { get; private set; }
        public decimal SelectedPrice    { get; private set; }

        public frmSendRequest(Product product)
        {
            InitializeComponent();
            lblProductVal.Text  = $"{product.ProductName} ({product.SKU})";
            lblSupplierVal.Text = product.StoreName;
            lblPriceVal.Text    = product.UnitPrice.ToString("N2");
            nudProposedPrice.Value = product.UnitPrice;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
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
