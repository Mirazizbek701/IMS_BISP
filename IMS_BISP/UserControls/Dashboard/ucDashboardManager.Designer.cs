namespace IMS_BISP.UserControls.Dashboard
{
    partial class ucDashboardManager
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlTotalProducts = new System.Windows.Forms.Panel();
            this.lblTotalProductsTitle = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.pnlPublicProducts = new System.Windows.Forms.Panel();
            this.lblPublicProductsTitle = new System.Windows.Forms.Label();
            this.lblPublicProducts = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlIncoming = new System.Windows.Forms.Panel();
            this.lblIncomingTitle = new System.Windows.Forms.Label();
            this.lblIncoming = new System.Windows.Forms.Label();
            this.pnlSent = new System.Windows.Forms.Panel();
            this.lblSentTitle = new System.Windows.Forms.Label();
            this.lblSent = new System.Windows.Forms.Label();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.pnlTotalProducts.SuspendLayout();
            this.pnlPublicProducts.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlIncoming.SuspendLayout();
            this.pnlSent.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeader.Location = new System.Drawing.Point(28, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(204, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Store Dashboard";
            // 
            // pnlTotalProducts
            // 
            this.pnlTotalProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.pnlTotalProducts.Controls.Add(this.lblTotalProductsTitle);
            this.pnlTotalProducts.Controls.Add(this.lblTotalProducts);
            this.pnlTotalProducts.Location = new System.Drawing.Point(30, 62);
            this.pnlTotalProducts.Name = "pnlTotalProducts";
            this.pnlTotalProducts.Size = new System.Drawing.Size(255, 110);
            this.pnlTotalProducts.TabIndex = 0;
            // 
            // lblTotalProductsTitle
            // 
            this.lblTotalProductsTitle.AutoSize = true;
            this.lblTotalProductsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTotalProductsTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            this.lblTotalProductsTitle.Size = new System.Drawing.Size(103, 20);
            this.lblTotalProductsTitle.TabIndex = 0;
            this.lblTotalProductsTitle.Text = "Total Products";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.lblTotalProducts.Location = new System.Drawing.Point(10, 40);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(35, 41);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "0";
            // 
            // pnlPublicProducts
            // 
            this.pnlPublicProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.pnlPublicProducts.Controls.Add(this.lblPublicProductsTitle);
            this.pnlPublicProducts.Controls.Add(this.lblPublicProducts);
            this.pnlPublicProducts.Location = new System.Drawing.Point(315, 62);
            this.pnlPublicProducts.Name = "pnlPublicProducts";
            this.pnlPublicProducts.Size = new System.Drawing.Size(255, 110);
            this.pnlPublicProducts.TabIndex = 1;
            // 
            // lblPublicProductsTitle
            // 
            this.lblPublicProductsTitle.AutoSize = true;
            this.lblPublicProductsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPublicProductsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPublicProductsTitle.Location = new System.Drawing.Point(12, 13);
            this.lblPublicProductsTitle.Name = "lblPublicProductsTitle";
            this.lblPublicProductsTitle.Size = new System.Drawing.Size(110, 20);
            this.lblPublicProductsTitle.TabIndex = 0;
            this.lblPublicProductsTitle.Text = "Public Products";
            // 
            // lblPublicProducts
            // 
            this.lblPublicProducts.AutoSize = true;
            this.lblPublicProducts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPublicProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.lblPublicProducts.Location = new System.Drawing.Point(10, 40);
            this.lblPublicProducts.Name = "lblPublicProducts";
            this.lblPublicProducts.Size = new System.Drawing.Size(35, 41);
            this.lblPublicProducts.TabIndex = 1;
            this.lblPublicProducts.Text = "0";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(600, 62);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(255, 110);
            this.pnlLowStock.TabIndex = 2;
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLowStockTitle.Location = new System.Drawing.Point(12, 13);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(76, 20);
            this.lblLowStockTitle.TabIndex = 0;
            this.lblLowStockTitle.Text = "Low Stock";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(50)))), ((int)(((byte)(38)))));
            this.lblLowStock.Location = new System.Drawing.Point(10, 40);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(35, 41);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "0";
            // 
            // pnlIncoming
            // 
            this.pnlIncoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.pnlIncoming.Controls.Add(this.lblIncomingTitle);
            this.pnlIncoming.Controls.Add(this.lblIncoming);
            this.pnlIncoming.Location = new System.Drawing.Point(30, 192);
            this.pnlIncoming.Name = "pnlIncoming";
            this.pnlIncoming.Size = new System.Drawing.Size(255, 110);
            this.pnlIncoming.TabIndex = 3;
            // 
            // lblIncomingTitle
            // 
            this.lblIncomingTitle.AutoSize = true;
            this.lblIncomingTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIncomingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblIncomingTitle.Location = new System.Drawing.Point(12, 13);
            this.lblIncomingTitle.Name = "lblIncomingTitle";
            this.lblIncomingTitle.Size = new System.Drawing.Size(134, 20);
            this.lblIncomingTitle.TabIndex = 0;
            this.lblIncomingTitle.Text = "Incoming Requests";
            // 
            // lblIncoming
            // 
            this.lblIncoming.AutoSize = true;
            this.lblIncoming.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblIncoming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(125)))), ((int)(((byte)(10)))));
            this.lblIncoming.Location = new System.Drawing.Point(10, 40);
            this.lblIncoming.Name = "lblIncoming";
            this.lblIncoming.Size = new System.Drawing.Size(35, 41);
            this.lblIncoming.TabIndex = 1;
            this.lblIncoming.Text = "0";
            // 
            // pnlSent
            // 
            this.pnlSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.pnlSent.Controls.Add(this.lblSentTitle);
            this.pnlSent.Controls.Add(this.lblSent);
            this.pnlSent.Location = new System.Drawing.Point(315, 192);
            this.pnlSent.Name = "pnlSent";
            this.pnlSent.Size = new System.Drawing.Size(255, 110);
            this.pnlSent.TabIndex = 4;
            // 
            // lblSentTitle
            // 
            this.lblSentTitle.AutoSize = true;
            this.lblSentTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSentTitle.Location = new System.Drawing.Point(12, 13);
            this.lblSentTitle.Name = "lblSentTitle";
            this.lblSentTitle.Size = new System.Drawing.Size(101, 20);
            this.lblSentTitle.TabIndex = 0;
            this.lblSentTitle.Text = "Sent Requests";
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.lblSent.Location = new System.Drawing.Point(10, 40);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(35, 41);
            this.lblSent.TabIndex = 1;
            this.lblSent.Text = "0";
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.pnlInventory.Controls.Add(this.lblInventoryTitle);
            this.pnlInventory.Controls.Add(this.lblInventory);
            this.pnlInventory.Location = new System.Drawing.Point(600, 192);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(255, 110);
            this.pnlInventory.TabIndex = 5;
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInventoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblInventoryTitle.Location = new System.Drawing.Point(12, 13);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(110, 20);
            this.lblInventoryTitle.TabIndex = 0;
            this.lblInventoryTitle.Text = "Inventory Value";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(117)))));
            this.lblInventory.Location = new System.Drawing.Point(10, 40);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(91, 37);
            this.lblInventory.TabIndex = 1;
            this.lblInventory.Text = "0 UZS";
            // 
            // ucDashboardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlTotalProducts);
            this.Controls.Add(this.pnlPublicProducts);
            this.Controls.Add(this.pnlLowStock);
            this.Controls.Add(this.pnlIncoming);
            this.Controls.Add(this.pnlSent);
            this.Controls.Add(this.pnlInventory);
            this.Name = "ucDashboardManager";
            this.Size = new System.Drawing.Size(900, 335);
            this.Load += new System.EventHandler(this.ucDashboardManager_Load);
            this.pnlTotalProducts.ResumeLayout(false);
            this.pnlTotalProducts.PerformLayout();
            this.pnlPublicProducts.ResumeLayout(false);
            this.pnlPublicProducts.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlIncoming.ResumeLayout(false);
            this.pnlIncoming.PerformLayout();
            this.pnlSent.ResumeLayout(false);
            this.pnlSent.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Panel pnlTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsTitle;
        private System.Windows.Forms.Label lblTotalProducts;

        private System.Windows.Forms.Panel pnlPublicProducts;
        private System.Windows.Forms.Label lblPublicProductsTitle;
        private System.Windows.Forms.Label lblPublicProducts;

        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblLowStock;

        private System.Windows.Forms.Panel pnlIncoming;
        private System.Windows.Forms.Label lblIncomingTitle;
        private System.Windows.Forms.Label lblIncoming;

        private System.Windows.Forms.Panel pnlSent;
        private System.Windows.Forms.Label lblSentTitle;
        private System.Windows.Forms.Label lblSent;

        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Label lblInventory;
    }
}
