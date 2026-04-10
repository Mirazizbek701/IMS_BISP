using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;
using IMS_BISP.Forms;
using IMS_BISP.Sessions;
using System;
using System.Collections.Generic;
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

        private void pnlLowStock_Click(object sender, EventArgs e)
        {
            if (!UserSession.StoreId.HasValue)
            {
                MessageBox.Show("No store assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<Product> products = ProductRepository.GetLowStock(UserSession.StoreId.Value);
                if (products.Count == 0)
                {
                    MessageBox.Show("No low stock products.", "Low Stock",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var frm = new frmLowStock(products);
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + (ex.InnerException != null ? "\n" + ex.InnerException.Message : ""),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            try
            {
                var reqStats   = DashboardRepository.GetRequestStats(UserSession.StoreId.Value);
                var lastUpdate = DashboardRepository.GetLastInventoryUpdate(UserSession.StoreId.Value);

                lblLastUpdated.Text = "Last Updated: " + (lastUpdate.HasValue
                                          ? lastUpdate.Value.ToString("dd.MM.yyyy HH:mm")
                                          : "—");
                lblAccepted.Text = $"Accepted Requests: {reqStats.AcceptedCount}";
                lblRejected.Text = $"Rejected Requests: {reqStats.RejectedCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load additional dashboard stats: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
