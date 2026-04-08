namespace IMS_BISP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Silver;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.marketplaceToolStripMenuItem,
            this.requestsToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.auditLogToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1066, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProductsToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // myProductsToolStripMenuItem
            // 
            this.myProductsToolStripMenuItem.Name = "myProductsToolStripMenuItem";
            this.myProductsToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.myProductsToolStripMenuItem.Text = "My Products";
            this.myProductsToolStripMenuItem.Click += new System.EventHandler(this.myProductsToolStripMenuItem_Click);
            // 
            // marketplaceToolStripMenuItem
            // 
            this.marketplaceToolStripMenuItem.Name = "marketplaceToolStripMenuItem";
            this.marketplaceToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.marketplaceToolStripMenuItem.Text = "Marketplace";
            this.marketplaceToolStripMenuItem.Click += new System.EventHandler(this.marketplaceToolStripMenuItem_Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sentRequestsToolStripMenuItem,
            this.incomingRequestsToolStripMenuItem});
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.requestsToolStripMenuItem.Text = "Requests";
            // 
            // sentRequestsToolStripMenuItem
            // 
            this.sentRequestsToolStripMenuItem.Name = "sentRequestsToolStripMenuItem";
            this.sentRequestsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sentRequestsToolStripMenuItem.Text = "Sent Requests";
            this.sentRequestsToolStripMenuItem.Click += new System.EventHandler(this.sentRequestsToolStripMenuItem_Click);
            // 
            // incomingRequestsToolStripMenuItem
            // 
            this.incomingRequestsToolStripMenuItem.Name = "incomingRequestsToolStripMenuItem";
            this.incomingRequestsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.incomingRequestsToolStripMenuItem.Text = "Incoming Requests";
            this.incomingRequestsToolStripMenuItem.Click += new System.EventHandler(this.incomingRequestsToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // auditLogToolStripMenuItem
            // 
            this.auditLogToolStripMenuItem.Name = "auditLogToolStripMenuItem";
            this.auditLogToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.auditLogToolStripMenuItem.Text = "Audit Log";
            this.auditLogToolStripMenuItem.Click += new System.EventHandler(this.auditLogToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 28);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1066, 703);
            this.pnlContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 731);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}