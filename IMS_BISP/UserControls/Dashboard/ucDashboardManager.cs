using IMS_BISP.DAL.Data;
using IMS_BISP.Sessions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Dashboard
{
    public partial class ucDashboardManager : UserControl
    {
        public ucDashboardManager()
        {
            InitializeComponent();
        }

        private void ucDashboardManager_Load(object sender, EventArgs e)
        {
            if (!UserSession.StoreId.HasValue) return;

            try
            {
                lblHeader.Text = $"Welcome, {UserSession.FullName} — {UserSession.StoreName}";

                var stats = DashboardRepository.GetStoreStats(UserSession.StoreId.Value);

                lblTotalProducts.Text    = stats.TotalProducts.ToString();
                lblPublicProducts.Text   = stats.PublicProducts.ToString();
                lblLowStock.Text         = stats.LowStockCount.ToString();
                lblIncoming.Text         = stats.PendingIncoming.ToString();
                lblSent.Text             = stats.PendingSent.ToString();
                lblInventory.Text        = string.Format("{0:N0} UZS", stats.TotalInventoryValue);

                if (stats.LowStockCount > 0)
                    lblLowStock.ForeColor = Color.FromArgb(192, 57, 43);

                if (stats.PendingIncoming > 0)
                    lblIncoming.ForeColor = Color.FromArgb(211, 84, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
