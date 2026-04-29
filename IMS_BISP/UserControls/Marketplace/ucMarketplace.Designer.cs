namespace IMS_BISP.UserControls.Marketplace
{
    partial class ucMarketplace
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle          = new System.Windows.Forms.Label();
            this.tbxSearch         = new System.Windows.Forms.TextBox();
            this.btnSearch         = new System.Windows.Forms.Button();
            this.btnClearSearch    = new System.Windows.Forms.Button();
            this.btnRequestProduct = new System.Windows.Forms.Button();
            this.btnRefresh        = new System.Windows.Forms.Button();
            this.dgvMarketplace    = new System.Windows.Forms.DataGridView();
            this.colProductId      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSKU            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStoreName      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarketplace)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Marketplace";
            // tbxSearch
            this.tbxSearch.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxSearch.Location = new System.Drawing.Point(20, 58);
            this.tbxSearch.Name     = "tbxSearch";
            this.tbxSearch.Size     = new System.Drawing.Size(220, 26);
            this.tbxSearch.TabIndex = 1;
            // btnSearch
            this.btnSearch.BackColor                  = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnSearch.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize  = 0;
            this.btnSearch.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor                  = System.Drawing.Color.White;
            this.btnSearch.Location                   = new System.Drawing.Point(248, 57);
            this.btnSearch.Name                       = "btnSearch";
            this.btnSearch.Size                       = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex                   = 2;
            this.btnSearch.Text                       = "Search";
            this.btnSearch.UseVisualStyleBackColor    = false;
            this.btnSearch.Click                     += new System.EventHandler(this.btnSearch_Click);
            // btnClearSearch
            this.btnClearSearch.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnClearSearch.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.FlatAppearance.BorderSize  = 0;
            this.btnClearSearch.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearSearch.ForeColor                  = System.Drawing.Color.White;
            this.btnClearSearch.Location                   = new System.Drawing.Point(336, 57);
            this.btnClearSearch.Name                       = "btnClearSearch";
            this.btnClearSearch.Size                       = new System.Drawing.Size(70, 28);
            this.btnClearSearch.TabIndex                   = 3;
            this.btnClearSearch.Text                       = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor    = false;
            this.btnClearSearch.Click                     += new System.EventHandler(this.btnClearSearch_Click);
            // btnRequestProduct
            this.btnRequestProduct.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnRequestProduct.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRequestProduct.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestProduct.FlatAppearance.BorderSize  = 0;
            this.btnRequestProduct.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRequestProduct.ForeColor                  = System.Drawing.Color.White;
            this.btnRequestProduct.Location                   = new System.Drawing.Point(20, 100);
            this.btnRequestProduct.Name                       = "btnRequestProduct";
            this.btnRequestProduct.Size                       = new System.Drawing.Size(140, 32);
            this.btnRequestProduct.TabIndex                   = 4;
            this.btnRequestProduct.Text                       = "Request Product";
            this.btnRequestProduct.UseVisualStyleBackColor    = false;
            this.btnRequestProduct.Click                     += new System.EventHandler(this.btnRequestProduct_Click);
            // btnRefresh
            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.White;
            this.btnRefresh.Location                   = new System.Drawing.Point(170, 100);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex                   = 5;
            this.btnRefresh.Text                       = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.btnRefresh_Click);
            // dgvMarketplace
            this.dgvMarketplace.AllowUserToAddRows          = false;
            this.dgvMarketplace.AllowUserToDeleteRows       = false;
            this.dgvMarketplace.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvMarketplace.AutoGenerateColumns         = false;
            this.dgvMarketplace.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarketplace.BackgroundColor             = System.Drawing.Color.White;
            this.dgvMarketplace.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvMarketplace.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarketplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarketplace.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvMarketplace.Location                    = new System.Drawing.Point(20, 146);
            this.dgvMarketplace.MultiSelect                 = false;
            this.dgvMarketplace.Name                        = "dgvMarketplace";
            this.dgvMarketplace.ReadOnly                    = true;
            this.dgvMarketplace.RowHeadersVisible           = false;
            this.dgvMarketplace.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarketplace.Size                        = new System.Drawing.Size(910, 374);
            this.dgvMarketplace.TabIndex                    = 6;
            // colProductId
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.HeaderText       = "ID";
            this.colProductId.Name             = "colProductId";
            this.colProductId.ReadOnly         = true;
            this.colProductId.Visible          = false;
            // colSKU
            this.colSKU.DataPropertyName = "SKU";
            this.colSKU.FillWeight       = 10F;
            this.colSKU.HeaderText       = "SKU";
            this.colSKU.MinimumWidth     = 80;
            this.colSKU.Name             = "colSKU";
            this.colSKU.ReadOnly         = true;
            // colProductName
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.FillWeight       = 22F;
            this.colProductName.HeaderText       = "Product Name";
            this.colProductName.MinimumWidth     = 150;
            this.colProductName.Name             = "colProductName";
            this.colProductName.ReadOnly         = true;
            // colCategoryName
            this.colCategoryName.DataPropertyName = "CategoryName";
            this.colCategoryName.FillWeight       = 12F;
            this.colCategoryName.HeaderText       = "Category";
            this.colCategoryName.MinimumWidth     = 90;
            this.colCategoryName.Name             = "colCategoryName";
            this.colCategoryName.ReadOnly         = true;
            // colStoreName
            this.colStoreName.DataPropertyName = "StoreName";
            this.colStoreName.FillWeight       = 18F;
            this.colStoreName.HeaderText       = "Supplier Store";
            this.colStoreName.MinimumWidth     = 130;
            this.colStoreName.Name             = "colStoreName";
            this.colStoreName.ReadOnly         = true;
            // colQuantity
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.FillWeight       = 10F;
            this.colQuantity.HeaderText       = "Available Qty";
            this.colQuantity.MinimumWidth     = 80;
            this.colQuantity.Name             = "colQuantity";
            this.colQuantity.ReadOnly         = true;
            // colUnitPrice
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Format = "N2";
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colUnitPrice.FillWeight       = 12F;
            this.colUnitPrice.HeaderText       = "Listed Price";
            this.colUnitPrice.MinimumWidth     = 90;
            this.colUnitPrice.Name             = "colUnitPrice";
            this.colUnitPrice.ReadOnly         = true;
            this.dgvMarketplace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductId, this.colSKU, this.colProductName,
                this.colCategoryName, this.colStoreName, this.colQuantity, this.colUnitPrice });
            // ucMarketplace
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnRequestProduct);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvMarketplace);
            this.Name  = "ucMarketplace";
            this.Size  = new System.Drawing.Size(950, 540);
            this.Load += new System.EventHandler(this.ucMarketplace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarketplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label              lblTitle;
        private System.Windows.Forms.TextBox            tbxSearch;
        private System.Windows.Forms.Button             btnSearch;
        private System.Windows.Forms.Button             btnClearSearch;
        private System.Windows.Forms.Button             btnRequestProduct;
        private System.Windows.Forms.Button             btnRefresh;
        private System.Windows.Forms.DataGridView       dgvMarketplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    }
}
