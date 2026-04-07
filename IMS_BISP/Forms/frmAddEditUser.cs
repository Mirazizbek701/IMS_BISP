using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmAddEditUser : Form
    {
        private readonly bool _editMode;
        private readonly int  _userId;

        // Add mode
        public frmAddEditUser()
        {
            InitializeComponent();
            _editMode         = false;
            lblFormTitle.Text = "Add User";
            this.Load        += frmAddEditUser_Load;
        }

        // Edit mode — only FullName, RoleId, StoreId can change
        public frmAddEditUser(User user)
        {
            InitializeComponent();
            _editMode              = true;
            _userId                = user.UserId;
            lblFormTitle.Text      = "Edit User";
            tbxFullName.Text       = user.FullName;

            // Username and Password are not editable in edit mode
            tbxUsername.Text      = user.Username;
            tbxUsername.ReadOnly  = true;
            tbxUsername.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            lblPassword.Visible   = false;
            tbxPassword.Visible   = false;

            this.Load += (s, e) =>
            {
                frmAddEditUser_Load(s, e);
                // Pre-select current values after combos are loaded
                if (cmbRole.Items.Count > 0)  cmbRole.SelectedValue  = user.RoleId;
                if (cmbStore.Items.Count > 0) cmbStore.SelectedValue = (object)user.StoreId ?? DBNull.Value;
            };
        }

        // Exposed results
        public string FullName      => tbxFullName.Text.Trim();
        public string Username      => tbxUsername.Text.Trim();
        public string Password      => tbxPassword.Text.Trim();
        public int    SelectedRoleId  => (int)cmbRole.SelectedValue;
        public int?   SelectedStoreId => cmbStore.SelectedValue == null ? (int?)null : (int?)cmbStore.SelectedValue;
        public bool   IsEditMode    => _editMode;
        public int    UserId        => _userId;

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            try
            {
                var roles = RoleRepository.GetNonAdmin();
                cmbRole.DataSource    = roles;
                cmbRole.DisplayMember = "RoleName";
                cmbRole.ValueMember   = "RoleId";

                var stores = StoreRepository.GetAllActive();
                cmbStore.DataSource    = stores;
                cmbStore.DisplayMember = "StoreName";
                cmbStore.ValueMember   = "StoreId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load form data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFullName.Focus();
                return;
            }

            if (!_editMode)
            {
                if (string.IsNullOrWhiteSpace(tbxUsername.Text))
                {
                    MessageBox.Show("Username is required.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxUsername.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxPassword.Text))
                {
                    MessageBox.Show("Password is required.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxPassword.Focus();
                    return;
                }
            }

            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Please select a Role.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }

            if (cmbStore.SelectedValue == null)
            {
                MessageBox.Show("Please select a Store.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStore.Focus();
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
