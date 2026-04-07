using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmAddEditStore : Form
    {
        private readonly bool _editMode;
        private readonly int  _storeId;

        // Add mode
        public frmAddEditStore()
        {
            InitializeComponent();
            _editMode         = false;
            lblFormTitle.Text = "Add Store";
        }

        // Edit mode
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
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
