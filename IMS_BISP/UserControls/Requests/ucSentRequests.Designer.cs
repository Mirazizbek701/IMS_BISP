namespace IMS_BISP.UserControls.Requests
{
    partial class ucSentRequests
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
            this.lblTitle        = new System.Windows.Forms.Label();
            this.btnRefresh      = new System.Windows.Forms.Button();
            this.dgvSentRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentRequests)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Sent Requests";
            // btnRefresh
            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.White;
            this.btnRefresh.Location                   = new System.Drawing.Point(20, 58);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex                   = 1;
            this.btnRefresh.Text                       = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.btnRefresh_Click);
            // dgvSentRequests
            this.dgvSentRequests.AllowUserToAddRows          = false;
            this.dgvSentRequests.AllowUserToDeleteRows       = false;
            this.dgvSentRequests.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvSentRequests.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentRequests.BackgroundColor             = System.Drawing.Color.White;
            this.dgvSentRequests.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvSentRequests.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentRequests.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvSentRequests.Location                    = new System.Drawing.Point(20, 103);
            this.dgvSentRequests.MultiSelect                 = false;
            this.dgvSentRequests.Name                        = "dgvSentRequests";
            this.dgvSentRequests.ReadOnly                    = true;
            this.dgvSentRequests.RowHeadersVisible           = false;
            this.dgvSentRequests.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentRequests.Size                        = new System.Drawing.Size(910, 417);
            this.dgvSentRequests.TabIndex                    = 2;
            this.dgvSentRequests.DataBindingComplete        += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSentRequests_DataBindingComplete);
            // ucSentRequests
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvSentRequests);
            this.Name  = "ucSentRequests";
            this.Size  = new System.Drawing.Size(950, 540);
            this.Load += new System.EventHandler(this.ucSentRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Button          btnRefresh;
        private System.Windows.Forms.DataGridView    dgvSentRequests;
    }
}
