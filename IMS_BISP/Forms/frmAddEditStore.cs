using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmAddEditStore : Form
    {
        private readonly bool _editMode;
        private readonly int  _storeId;

        public frmAddEditStore()
        {
            InitializeComponent();
            _editMode         = false;
            lblFormTitle.Text = "Add Store";
        }

        public frmAddEditStore(Store store)
        {
            InitializeComponent();
            _editMode              = true;
            _storeId               = store.StoreId;
            lblFormTitle.Text      = "Edit Store";
            tbxStoreName.Text      = store.StoreName;
            tbxContactPhone.Text   = store.ContactPhone;
        }

        public string StoreName    => tbxStoreName.Text.Trim();
        public string ContactPhone => tbxContactPhone.Text.Trim();
        public bool   IsEditMode   => _editMode;
        public int    StoreId      => _storeId;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxStoreName.Text))
            {
                MessageBox.Show("Store Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxStoreName.Focus();
                return;
            }
            if (tbxStoreName.Text.Trim().Length > 100)
            {
                MessageBox.Show("Store Name must not exceed 100 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxStoreName.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(tbxContactPhone.Text))
            {
                string phone = tbxContactPhone.Text.Trim();
                if (phone.Length > 20)
                {
                    MessageBox.Show("Contact Phone must not exceed 20 characters.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxContactPhone.Focus();
                    return;
                }
                foreach (char c in phone)
                {
                    if (!char.IsDigit(c) && c != '+')
                    {
                        MessageBox.Show("Contact Phone may only contain digits and '+'.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxContactPhone.Focus();
                        return;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
