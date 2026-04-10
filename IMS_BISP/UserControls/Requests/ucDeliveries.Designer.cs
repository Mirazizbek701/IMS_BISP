namespace IMS_BISP.UserControls.Requests
{
    partial class ucDeliveries
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
            System.Windows.Forms.DataGridViewCellStyle priceStyle      = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dateStyle       = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle               = new System.Windows.Forms.Label();
            this.btnMarkDelivered       = new System.Windows.Forms.Button();
            this.btnMarkNotDelivered    = new System.Windows.Forms.Button();
            this.btnRefresh             = new System.Windows.Forms.Button();
            this.dgvDeliveries          = new System.Windows.Forms.DataGridView();
            this.colRequestId           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequesterStoreName  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSKU                 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityRequested   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProposedPrice       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRespondedAt         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Deliveries";
            // cell styles
            priceStyle.Format = "N2";
            dateStyle.Format  = "dd.MM.yyyy HH:mm";
            // colRequestId
            this.colRequestId.DataPropertyName = "RequestId";
            this.colRequestId.HeaderText       = "ID";
            this.colRequestId.Name             = "colRequestId";
            this.colRequestId.Visible          = false;
            // colRequesterStoreName
            this.colRequesterStoreName.DataPropertyName = "RequesterStoreName";
            this.colRequesterStoreName.HeaderText       = "Requester Store";
            this.colRequesterStoreName.Name             = "colRequesterStoreName";
            this.colRequesterStoreName.FillWeight       = 20;
            this.colRequesterStoreName.MinimumWidth      = 130;
            // colProductName
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText       = "Product";
            this.colProductName.Name             = "colProductName";
            this.colProductName.FillWeight       = 22;
            this.colProductName.MinimumWidth      = 130;
            // colSKU
            this.colSKU.DataPropertyName = "SKU";
            this.colSKU.HeaderText       = "SKU";
            this.colSKU.Name             = "colSKU";
            this.colSKU.FillWeight       = 10;
            this.colSKU.MinimumWidth      = 75;
            // colQuantityRequested
            this.colQuantityRequested.DataPropertyName = "QuantityRequested";
            this.colQuantityRequested.HeaderText       = "Qty";
            this.colQuantityRequested.Name             = "colQuantityRequested";
            this.colQuantityRequested.FillWeight       = 7;
            this.colQuantityRequested.MinimumWidth      = 50;
            // colProposedPrice
            this.colProposedPrice.DataPropertyName  = "ProposedPrice";
            this.colProposedPrice.HeaderText        = "Proposed Price";
            this.colProposedPrice.Name              = "colProposedPrice";
            this.colProposedPrice.FillWeight        = 13;
            this.colProposedPrice.MinimumWidth       = 95;
            this.colProposedPrice.DefaultCellStyle   = priceStyle;
            // colRespondedAt
            this.colRespondedAt.DataPropertyName  = "RespondedAt";
            this.colRespondedAt.HeaderText        = "Responded At";
            this.colRespondedAt.Name              = "colRespondedAt";
            this.colRespondedAt.FillWeight        = 15;
            this.colRespondedAt.MinimumWidth       = 110;
            this.colRespondedAt.DefaultCellStyle   = dateStyle;
            // btnMarkDelivered
            this.btnMarkDelivered.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnMarkDelivered.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnMarkDelivered.Enabled                    = false;
            this.btnMarkDelivered.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkDelivered.FlatAppearance.BorderSize  = 0;
            this.btnMarkDelivered.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkDelivered.ForeColor                  = System.Drawing.Color.White;
            this.btnMarkDelivered.Location                   = new System.Drawing.Point(20, 58);
            this.btnMarkDelivered.Name                       = "btnMarkDelivered";
            this.btnMarkDelivered.Size                       = new System.Drawing.Size(150, 32);
            this.btnMarkDelivered.TabIndex                   = 1;
            this.btnMarkDelivered.Text                       = "Mark Delivered";
            this.btnMarkDelivered.UseVisualStyleBackColor    = false;
            this.btnMarkDelivered.Click                     += new System.EventHandler(this.btnMarkDelivered_Click);
            // btnMarkNotDelivered
            this.btnMarkNotDelivered.BackColor                  = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnMarkNotDelivered.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnMarkNotDelivered.Enabled                    = false;
            this.btnMarkNotDelivered.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkNotDelivered.FlatAppearance.BorderSize  = 0;
            this.btnMarkNotDelivered.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkNotDelivered.ForeColor                  = System.Drawing.Color.White;
            this.btnMarkNotDelivered.Location                   = new System.Drawing.Point(180, 58);
            this.btnMarkNotDelivered.Name                       = "btnMarkNotDelivered";
            this.btnMarkNotDelivered.Size                       = new System.Drawing.Size(170, 32);
            this.btnMarkNotDelivered.TabIndex                   = 2;
            this.btnMarkNotDelivered.Text                       = "Mark Not Delivered";
            this.btnMarkNotDelivered.UseVisualStyleBackColor    = false;
            this.btnMarkNotDelivered.Click                     += new System.EventHandler(this.btnMarkNotDelivered_Click);
            // btnRefresh
            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.White;
            this.btnRefresh.Location                   = new System.Drawing.Point(360, 58);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex                   = 3;
            this.btnRefresh.Text                       = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.btnRefresh_Click);
            // dgvDeliveries
            this.dgvDeliveries.AllowUserToAddRows          = false;
            this.dgvDeliveries.AllowUserToDeleteRows       = false;
            this.dgvDeliveries.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvDeliveries.AutoGenerateColumns         = false;
            this.dgvDeliveries.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveries.BackgroundColor             = System.Drawing.Color.White;
            this.dgvDeliveries.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvDeliveries.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.EnableHeadersVisualStyles   = false;
            this.dgvDeliveries.DefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDeliveries.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvDeliveries.Location                    = new System.Drawing.Point(20, 103);
            this.dgvDeliveries.MultiSelect                 = false;
            this.dgvDeliveries.Name                        = "dgvDeliveries";
            this.dgvDeliveries.ReadOnly                    = true;
            this.dgvDeliveries.RowHeadersVisible           = false;
            this.dgvDeliveries.RowTemplate.Height          = 28;
            this.dgvDeliveries.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Size                        = new System.Drawing.Size(910, 417);
            this.dgvDeliveries.TabIndex                    = 4;
            this.dgvDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRequestId,
                this.colRequesterStoreName,
                this.colProductName,
                this.colSKU,
                this.colQuantityRequested,
                this.colProposedPrice,
                this.colRespondedAt });
            this.dgvDeliveries.SelectionChanged     += new System.EventHandler(this.dgvDeliveries_SelectionChanged);
            this.dgvDeliveries.DataBindingComplete  += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDeliveries_DataBindingComplete);
            // ucDeliveries
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMarkDelivered);
            this.Controls.Add(this.btnMarkNotDelivered);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvDeliveries);
            this.Name  = "ucDeliveries";
            this.Size  = new System.Drawing.Size(950, 540);
            this.Load += new System.EventHandler(this.ucDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label                       lblTitle;
        private System.Windows.Forms.Button                      btnMarkDelivered;
        private System.Windows.Forms.Button                      btnMarkNotDelivered;
        private System.Windows.Forms.Button                      btnRefresh;
        private System.Windows.Forms.DataGridView                dgvDeliveries;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colRequesterStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colQuantityRequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colProposedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn   colRespondedAt;
    }
}
