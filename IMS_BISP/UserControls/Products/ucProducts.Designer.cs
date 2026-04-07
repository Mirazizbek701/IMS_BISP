namespace IMS_BISP.UserControls.Products
{
    partial class ucProducts
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
            this.lblTitle            = new System.Windows.Forms.Label();
            this.tbxSearch           = new System.Windows.Forms.TextBox();
            this.btnSearch           = new System.Windows.Forms.Button();
            this.btnClearSearch      = new System.Windows.Forms.Button();
            this.btnAdd              = new System.Windows.Forms.Button();
            this.btnEdit             = new System.Windows.Forms.Button();
            this.btnDelete           = new System.Windows.Forms.Button();
            this.btnToggleVisibility = new System.Windows.Forms.Button();
            this.btnRefresh          = new System.Windows.Forms.Button();
            this.dgvProducts         = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "My Products";
            // tbxSearch
            this.tbxSearch.Font        = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tbxSearch.Location    = new System.Drawing.Point(20, 58);
            this.tbxSearch.Name        = "tbxSearch";
            this.tbxSearch.Size        = new System.Drawing.Size(220, 26);
            this.tbxSearch.TabIndex    = 1;
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
            // btnAdd
            this.btnAdd.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAdd.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize  = 0;
            this.btnAdd.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor                  = System.Drawing.Color.White;
            this.btnAdd.Location                   = new System.Drawing.Point(20, 100);
            this.btnAdd.Name                       = "btnAdd";
            this.btnAdd.Size                       = new System.Drawing.Size(110, 32);
            this.btnAdd.TabIndex                   = 4;
            this.btnAdd.Text                       = "Add Product";
            this.btnAdd.UseVisualStyleBackColor    = false;
            this.btnAdd.Click                     += new System.EventHandler(this.btnAdd_Click);
            // btnEdit
            this.btnEdit.BackColor                  = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnEdit.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize  = 0;
            this.btnEdit.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor                  = System.Drawing.Color.White;
            this.btnEdit.Location                   = new System.Drawing.Point(140, 100);
            this.btnEdit.Name                       = "btnEdit";
            this.btnEdit.Size                       = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex                   = 5;
            this.btnEdit.Text                       = "Edit";
            this.btnEdit.UseVisualStyleBackColor    = false;
            this.btnEdit.Click                     += new System.EventHandler(this.btnEdit_Click);
            // btnDelete
            this.btnDelete.BackColor                  = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize  = 0;
            this.btnDelete.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor                  = System.Drawing.Color.White;
            this.btnDelete.Location                   = new System.Drawing.Point(250, 100);
            this.btnDelete.Name                       = "btnDelete";
            this.btnDelete.Size                       = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex                   = 6;
            this.btnDelete.Text                       = "Delete";
            this.btnDelete.UseVisualStyleBackColor    = false;
            this.btnDelete.Click                     += new System.EventHandler(this.btnDelete_Click);
            // btnToggleVisibility
            this.btnToggleVisibility.BackColor                  = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnToggleVisibility.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnToggleVisibility.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleVisibility.FlatAppearance.BorderSize  = 0;
            this.btnToggleVisibility.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleVisibility.ForeColor                  = System.Drawing.Color.White;
            this.btnToggleVisibility.Location                   = new System.Drawing.Point(360, 100);
            this.btnToggleVisibility.Name                       = "btnToggleVisibility";
            this.btnToggleVisibility.Size                       = new System.Drawing.Size(130, 32);
            this.btnToggleVisibility.TabIndex                   = 7;
            this.btnToggleVisibility.Text                       = "Make Private";
            this.btnToggleVisibility.UseVisualStyleBackColor    = false;
            this.btnToggleVisibility.Click                     += new System.EventHandler(this.btnToggleVisibility_Click);
            // btnRefresh
            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.White;
            this.btnRefresh.Location                   = new System.Drawing.Point(500, 100);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex                   = 8;
            this.btnRefresh.Text                       = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.btnRefresh_Click);
            // dgvProducts
            this.dgvProducts.AllowUserToAddRows          = false;
            this.dgvProducts.AllowUserToDeleteRows       = false;
            this.dgvProducts.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvProducts.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor             = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvProducts.Location                    = new System.Drawing.Point(20, 146);
            this.dgvProducts.MultiSelect                 = false;
            this.dgvProducts.Name                        = "dgvProducts";
            this.dgvProducts.ReadOnly                    = true;
            this.dgvProducts.RowHeadersVisible           = false;
            this.dgvProducts.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size                        = new System.Drawing.Size(910, 374);
            this.dgvProducts.TabIndex                    = 9;
            this.dgvProducts.SelectionChanged           += new System.EventHandler(this.dgvProducts_SelectionChanged);
            this.dgvProducts.DataBindingComplete        += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProducts_DataBindingComplete);
            // ucProducts
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnToggleVisibility);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvProducts);
            this.Name  = "ucProducts";
            this.Size  = new System.Drawing.Size(950, 540);
            this.Load += new System.EventHandler(this.ucProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.TextBox         tbxSearch;
        private System.Windows.Forms.Button          btnSearch;
        private System.Windows.Forms.Button          btnClearSearch;
        private System.Windows.Forms.Button          btnAdd;
        private System.Windows.Forms.Button          btnEdit;
        private System.Windows.Forms.Button          btnDelete;
        private System.Windows.Forms.Button          btnToggleVisibility;
        private System.Windows.Forms.Button          btnRefresh;
        private System.Windows.Forms.DataGridView    dgvProducts;
    }
}
