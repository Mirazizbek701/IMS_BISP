using IMS_BISP.DAL.Models;
using IMS_BISP.Sessions;
using IMS_BISP.UserControls.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_BISP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void SetupMenuByRole()
        {
            myProductsToolStripMenuItem.Visible = false;
            marketplaceToolStripMenuItem.Visible = false;
            sentRequestsToolStripMenuItem.Visible = false;
            incomingRequestsToolStripMenuItem.Visible = false;
            storesToolStripMenuItem.Visible = false;
            usersToolStripMenuItem.Visible = false;
            auditLogToolStripMenuItem.Visible = false;

            if (UserSession.IsAdmin())
            {
                storesToolStripMenuItem.Visible = true;
                usersToolStripMenuItem.Visible = true;
                auditLogToolStripMenuItem.Visible = true;
            }
            else if (UserSession.IsManager())
            {
                myProductsToolStripMenuItem.Visible = true;
                marketplaceToolStripMenuItem.Visible = true;
                requestsToolStripMenuItem.Visible = true;
                incomingRequestsToolStripMenuItem.Visible = true;
            }
            else if (UserSession.IsStaff())
            {
                myProductsToolStripMenuItem.Visible = true;
            }

            this.Text = $"IMS - {UserSession.FullName} ({UserSession.RoleName})";
        }

        private void LoadControl(Control uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(ucDashboard.Load());
        }

        private void myProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucProducts());
        }

        private void marketplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucMarketplace());
        }

        private void sentRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucSentRequests());
        }

        private void incomingRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucIncomingRequests());
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucManageStores());
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucManageUsers());

        }

        private void auditLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new ucAuditLog());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.Clear();
                new Forms.frmLogin().Show();
                this.Close();
            }
        }
    }
}
