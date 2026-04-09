using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using System;
using System.Windows.Forms;

namespace IMS_BISP.Forms
{
    public partial class frmAddEditContract : Form
    {
        private readonly bool _editMode;
        private readonly int _contractId;

        public frmAddEditContract()
        {
            InitializeComponent();
            _editMode = false;
            lblFormTitle.Text = "Add Contract";
            LoadStores();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddYears(1);
        }

        public frmAddEditContract(Contract c)
        {
            InitializeComponent();
            _editMode = true;
            _contractId = c.ContractId;
            lblFormTitle.Text = "Edit Contract";
            LoadStores();
            cmbStore.SelectedValue = c.StoreId;
            dtpStartDate.Value = c.StartDate;
            dtpEndDate.Value = c.EndDate;
            nudMonthlyRent.Value = c.MonthlyRent;
            tbxFilePath.Text = c.ContractFile ?? string.Empty;
        }

        public int SelectedStoreId => cmbStore.SelectedValue != null ? (int)cmbStore.SelectedValue : 0;
        public DateTime SelectedStartDate => dtpStartDate.Value.Date;
        public DateTime SelectedEndDate => dtpEndDate.Value.Date;
        public decimal SelectedMonthlyRent => nudMonthlyRent.Value;
        public string SelectedFilePath => string.IsNullOrWhiteSpace(tbxFilePath.Text) ? null : tbxFilePath.Text.Trim();

        private void LoadStores()
        {
            try
            {
                var stores = StoreRepository.GetAllActive();
                cmbStore.DataSource = stores;
                cmbStore.DisplayMember = "StoreName";
                cmbStore.ValueMember = "StoreId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load stores: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Contract File";
                dlg.Filter = "Contract files|*.pdf;*.docx|All files|*.*";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    tbxFilePath.Text = dlg.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStore.SelectedValue == null)
            {
                MessageBox.Show("Please select a store.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStore.Focus();
                return;
            }

            if (dtpEndDate.Value.Date <= dtpStartDate.Value.Date)
            {
                MessageBox.Show("End Date must be after Start Date.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return;
            }

            if (nudMonthlyRent.Value <= 0)
            {
                MessageBox.Show("Monthly Rent must be greater than 0.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudMonthlyRent.Focus();
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
