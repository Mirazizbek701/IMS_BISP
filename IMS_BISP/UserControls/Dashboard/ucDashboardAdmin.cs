using IMS_BISP.DAL.Data;
using IMS_BISP.Sessions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_BISP.UserControls.Dashboard
{
    public partial class ucDashboardAdmin : UserControl
    {
        public ucDashboardAdmin()
        {
            InitializeComponent();
        }

        private void ucDashboardAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                lblHeader.Text = $"Welcome, {UserSession.FullName} — System Administrator";

                var stats = DashboardRepository.GetAdminStats();

                lblActiveStores.Text     = stats.TotalActiveStores.ToString();
                lblActiveUsers.Text      = stats.TotalActiveUsers.ToString();
                lblTotalProducts.Text    = stats.TotalProducts.ToString();
                lblPendingRequests.Text  = stats.TotalPendingRequests.ToString();

                if (stats.TotalPendingRequests > 0)
                    lblPendingRequests.ForeColor = Color.FromArgb(211, 84, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
