namespace IMS_BISP.Forms
{
    partial class frmLowStock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle centerStyle       = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.dgvLowStock      = new System.Windows.Forms.DataGridView();
            this.btnClose         = new System.Windows.Forms.Button();
            this.colProductName   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSKU           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinThreshold  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailable     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(0, 12);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(750, 28);
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Low Stock Products";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // center style
            centerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // colProductName
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText       = "Product Name";
            this.colProductName.Name             = "colProductName";
            this.colProductName.FillWeight       = 25;
            this.colProductName.MinimumWidth      = 130;
            // colSKU
            this.colSKU.DataPropertyName = "SKU";
            this.colSKU.HeaderText       = "SKU";
            this.colSKU.Name             = "colSKU";
            this.colSKU.FillWeight       = 12;
            this.colSKU.MinimumWidth      = 75;
            // colCategoryName
            this.colCategoryName.DataPropertyName = "CategoryName";
            this.colCategoryName.HeaderText       = "Category";
            this.colCategoryName.Name             = "colCategoryName";
            this.colCategoryName.FillWeight       = 15;
            this.colCategoryName.MinimumWidth      = 90;
            // colQuantity
            this.colQuantity.DataPropertyName      = "Quantity";
            this.colQuantity.HeaderText            = "Qty";
            this.colQuantity.Name                  = "colQuantity";
            this.colQuantity.FillWeight            = 8;
            this.colQuantity.MinimumWidth           = 50;
            this.colQuantity.DefaultCellStyle       = centerStyle;
            // colMinThreshold
            this.colMinThreshold.DataPropertyName = "MinThreshold";
            this.colMinThreshold.HeaderText       = "Min";
            this.colMinThreshold.Name             = "colMinThreshold";
            this.colMinThreshold.FillWeight       = 8;
            this.colMinThreshold.MinimumWidth      = 50;
            this.colMinThreshold.DefaultCellStyle  = centerStyle;
            // colAvailable
            this.colAvailable.DataPropertyName = "Available";
            this.colAvailable.HeaderText       = "Available";
            this.colAvailable.Name             = "colAvailable";
            this.colAvailable.FillWeight       = 8;
            this.colAvailable.MinimumWidth      = 60;
            this.colAvailable.DefaultCellStyle  = centerStyle;
            // dgvLowStock
            this.dgvLowStock.AllowUserToAddRows          = false;
            this.dgvLowStock.AllowUserToDeleteRows       = false;
            this.dgvLowStock.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvLowStock.AutoGenerateColumns         = false;
            this.dgvLowStock.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor             = System.Drawing.Color.White;
            this.dgvLowStock.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.EnableHeadersVisualStyles   = false;
            this.dgvLowStock.DefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLowStock.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvLowStock.Location                    = new System.Drawing.Point(15, 52);
            this.dgvLowStock.MultiSelect                 = false;
            this.dgvLowStock.Name                        = "dgvLowStock";
            this.dgvLowStock.ReadOnly                    = true;
            this.dgvLowStock.RowHeadersVisible           = false;
            this.dgvLowStock.RowTemplate.Height          = 28;
            this.dgvLowStock.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size                        = new System.Drawing.Size(720, 300);
            this.dgvLowStock.TabIndex                    = 1;
            this.dgvLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductName,
                this.colSKU,
                this.colCategoryName,
                this.colQuantity,
                this.colMinThreshold,
                this.colAvailable });
            this.dgvLowStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLowStock_DataBindingComplete);
            // btnClose
            this.btnClose.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnClose.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult               = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize  = 0;
            this.btnClose.Font                       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor                  = System.Drawing.Color.White;
            this.btnClose.Location                   = new System.Drawing.Point(635, 365);
            this.btnClose.Name                       = "btnClose";
            this.btnClose.Size                       = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex                   = 2;
            this.btnClose.Text                       = "Close";
            this.btnClose.UseVisualStyleBackColor    = false;
            this.btnClose.Click                     += new System.EventHandler(this.btnClose_Click);
            // frmLowStock
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.CancelButton        = this.btnClose;
            this.ClientSize          = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox      = false;
            this.MinimizeBox      = false;
            this.Name             = "frmLowStock";
            this.StartPosition    = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text             = "Low Stock Products";
            this.Load            += new System.EventHandler(this.frmLowStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label                       lblTitle;
        private System.Windows.Forms.DataGridView                dgvLowStock;
        private System.Windows.Forms.Button                      btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colMinThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colAvailable;
    }
}
