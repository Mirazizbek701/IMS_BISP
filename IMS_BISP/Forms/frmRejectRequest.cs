using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmRejectRequest : Form
    {
        public string RejectionNote => tbxNote.Text.Trim();

        public frmRejectRequest()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNote.Text))
            {
                MessageBox.Show("Rejection note is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNote.Focus();
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
