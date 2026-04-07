namespace IMS_BISP.UserControls.Dashboard
{
    partial class ucDashboardAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader               = new System.Windows.Forms.Label();

            this.pnlActiveStores         = new System.Windows.Forms.Panel();
            this.lblActiveStoresTitle    = new System.Windows.Forms.Label();
            this.lblActiveStores         = new System.Windows.Forms.Label();

            this.pnlActiveUsers          = new System.Windows.Forms.Panel();
            this.lblActiveUsersTitle     = new System.Windows.Forms.Label();
            this.lblActiveUsers          = new System.Windows.Forms.Label();

            this.pnlTotalProducts        = new System.Windows.Forms.Panel();
            this.lblTotalProductsTitle   = new System.Windows.Forms.Label();
            this.lblTotalProducts        = new System.Windows.Forms.Label();

            this.pnlPendingRequests      = new System.Windows.Forms.Panel();
            this.lblPendingRequestsTitle = new System.Windows.Forms.Label();
            this.lblPendingRequests      = new System.Windows.Forms.Label();

            this.pnlActiveStores.SuspendLayout();
            this.pnlActiveUsers.SuspendLayout();
            this.pnlTotalProducts.SuspendLayout();
            this.pnlPendingRequests.SuspendLayout();
            this.SuspendLayout();

            // ── Header ─────────────────────────────────────────────────────────
            this.lblHeader.AutoSize  = true;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeader.Location  = new System.Drawing.Point(28, 18);
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.Size      = new System.Drawing.Size(300, 32);
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "System Dashboard";

            // ── Card 1 — Active Stores ──────────────────────────────────────────
            this.pnlActiveStores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.pnlActiveStores.Controls.Add(this.lblActiveStoresTitle);
            this.pnlActiveStores.Controls.Add(this.lblActiveStores);
            this.pnlActiveStores.Location  = new System.Drawing.Point(30, 62);
            this.pnlActiveStores.Name      = "pnlActiveStores";
            this.pnlActiveStores.Size      = new System.Drawing.Size(255, 110);
            this.pnlActiveStores.TabIndex  = 1;

            this.lblActiveStoresTitle.AutoSize  = true;
            this.lblActiveStoresTitle.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActiveStoresTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblActiveStoresTitle.Location  = new System.Drawing.Point(12, 13);
            this.lblActiveStoresTitle.Name      = "lblActiveStoresTitle";
            this.lblActiveStoresTitle.Size      = new System.Drawing.Size(98, 20);
            this.lblActiveStoresTitle.TabIndex  = 0;
            this.lblActiveStoresTitle.Text      = "Active Stores";

            this.lblActiveStores.AutoSize  = true;
            this.lblActiveStores.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblActiveStores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.lblActiveStores.Location  = new System.Drawing.Point(10, 40);
            this.lblActiveStores.Name      = "lblActiveStores";
            this.lblActiveStores.Size      = new System.Drawing.Size(35, 41);
            this.lblActiveStores.TabIndex  = 1;
            this.lblActiveStores.Text      = "0";

            // ── Card 2 — Active Users ───────────────────────────────────────────
            this.pnlActiveUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.pnlActiveUsers.Controls.Add(this.lblActiveUsersTitle);
            this.pnlActiveUsers.Controls.Add(this.lblActiveUsers);
            this.pnlActiveUsers.Location  = new System.Drawing.Point(315, 62);
            this.pnlActiveUsers.Name      = "pnlActiveUsers";
            this.pnlActiveUsers.Size      = new System.Drawing.Size(255, 110);
            this.pnlActiveUsers.TabIndex  = 2;

            this.lblActiveUsersTitle.AutoSize  = true;
            this.lblActiveUsersTitle.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActiveUsersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblActiveUsersTitle.Location  = new System.Drawing.Point(12, 13);
            this.lblActiveUsersTitle.Name      = "lblActiveUsersTitle";
            this.lblActiveUsersTitle.Size      = new System.Drawing.Size(92, 20);
            this.lblActiveUsersTitle.TabIndex  = 0;
            this.lblActiveUsersTitle.Text      = "Active Users";

            this.lblActiveUsers.AutoSize  = true;
            this.lblActiveUsers.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblActiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.lblActiveUsers.Location  = new System.Drawing.Point(10, 40);
            this.lblActiveUsers.Name      = "lblActiveUsers";
            this.lblActiveUsers.Size      = new System.Drawing.Size(35, 41);
            this.lblActiveUsers.TabIndex  = 1;
            this.lblActiveUsers.Text      = "0";

            // ── Card 3 — Total Products ─────────────────────────────────────────
            this.pnlTotalProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnlTotalProducts.Controls.Add(this.lblTotalProductsTitle);
            this.pnlTotalProducts.Controls.Add(this.lblTotalProducts);
            this.pnlTotalProducts.Location  = new System.Drawing.Point(30, 192);
            this.pnlTotalProducts.Name      = "pnlTotalProducts";
            this.pnlTotalProducts.Size      = new System.Drawing.Size(255, 110);
            this.pnlTotalProducts.TabIndex  = 3;

            this.lblTotalProductsTitle.AutoSize  = true;
            this.lblTotalProductsTitle.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTotalProductsTitle.Location  = new System.Drawing.Point(12, 13);
            this.lblTotalProductsTitle.Name      = "lblTotalProductsTitle";
            this.lblTotalProductsTitle.Size      = new System.Drawing.Size(103, 20);
            this.lblTotalProductsTitle.TabIndex  = 0;
            this.lblTotalProductsTitle.Text      = "Total Products";

            this.lblTotalProducts.AutoSize  = true;
            this.lblTotalProducts.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.lblTotalProducts.Location  = new System.Drawing.Point(10, 40);
            this.lblTotalProducts.Name      = "lblTotalProducts";
            this.lblTotalProducts.Size      = new System.Drawing.Size(35, 41);
            this.lblTotalProducts.TabIndex  = 1;
            this.lblTotalProducts.Text      = "0";

            // ── Card 4 — Pending Requests ───────────────────────────────────────
            this.pnlPendingRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.pnlPendingRequests.Controls.Add(this.lblPendingRequestsTitle);
            this.pnlPendingRequests.Controls.Add(this.lblPendingRequests);
            this.pnlPendingRequests.Location  = new System.Drawing.Point(315, 192);
            this.pnlPendingRequests.Name      = "pnlPendingRequests";
            this.pnlPendingRequests.Size      = new System.Drawing.Size(255, 110);
            this.pnlPendingRequests.TabIndex  = 4;

            this.lblPendingRequestsTitle.AutoSize  = true;
            this.lblPendingRequestsTitle.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPendingRequestsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPendingRequestsTitle.Location  = new System.Drawing.Point(12, 13);
            this.lblPendingRequestsTitle.Name      = "lblPendingRequestsTitle";
            this.lblPendingRequestsTitle.Size      = new System.Drawing.Size(134, 20);
            this.lblPendingRequestsTitle.TabIndex  = 0;
            this.lblPendingRequestsTitle.Text      = "Pending Requests";

            this.lblPendingRequests.AutoSize  = true;
            this.lblPendingRequests.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPendingRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.lblPendingRequests.Location  = new System.Drawing.Point(10, 40);
            this.lblPendingRequests.Name      = "lblPendingRequests";
            this.lblPendingRequests.Size      = new System.Drawing.Size(35, 41);
            this.lblPendingRequests.TabIndex  = 1;
            this.lblPendingRequests.Text      = "0";

            // ── UserControl ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlActiveStores);
            this.Controls.Add(this.pnlActiveUsers);
            this.Controls.Add(this.pnlTotalProducts);
            this.Controls.Add(this.pnlPendingRequests);
            this.Name  = "ucDashboardAdmin";
            this.Size  = new System.Drawing.Size(630, 335);
            this.Load += new System.EventHandler(this.ucDashboardAdmin_Load);

            this.pnlActiveStores.ResumeLayout(false);
            this.pnlActiveStores.PerformLayout();
            this.pnlActiveUsers.ResumeLayout(false);
            this.pnlActiveUsers.PerformLayout();
            this.pnlTotalProducts.ResumeLayout(false);
            this.pnlTotalProducts.PerformLayout();
            this.pnlPendingRequests.ResumeLayout(false);
            this.pnlPendingRequests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Panel pnlActiveStores;
        private System.Windows.Forms.Label lblActiveStoresTitle;
        private System.Windows.Forms.Label lblActiveStores;

        private System.Windows.Forms.Panel pnlActiveUsers;
        private System.Windows.Forms.Label lblActiveUsersTitle;
        private System.Windows.Forms.Label lblActiveUsers;

        private System.Windows.Forms.Panel pnlTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsTitle;
        private System.Windows.Forms.Label lblTotalProducts;

        private System.Windows.Forms.Panel pnlPendingRequests;
        private System.Windows.Forms.Label lblPendingRequestsTitle;
        private System.Windows.Forms.Label lblPendingRequests;
    }
}
