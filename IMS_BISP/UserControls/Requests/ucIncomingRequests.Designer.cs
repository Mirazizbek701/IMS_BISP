namespace IMS_BISP.UserControls.Requests
{
    partial class ucIncomingRequests
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
            this.btnAccept           = new System.Windows.Forms.Button();
            this.btnReject           = new System.Windows.Forms.Button();
            this.btnRefresh          = new System.Windows.Forms.Button();
            this.dgvIncomingRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingRequests)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Incoming Requests";
            // btnAccept
            this.btnAccept.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAccept.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.FlatAppearance.BorderSize  = 0;
            this.btnAccept.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor                  = System.Drawing.Color.White;
            this.btnAccept.Location                   = new System.Drawing.Point(20, 58);
            this.btnAccept.Name                       = "btnAccept";
            this.btnAccept.Size                       = new System.Drawing.Size(110, 32);
            this.btnAccept.TabIndex                   = 1;
            this.btnAccept.Text                       = "Accept";
            this.btnAccept.UseVisualStyleBackColor    = false;
            this.btnAccept.Enabled                    = false;
            this.btnAccept.Click                     += new System.EventHandler(this.btnAccept_Click);
            // btnReject
            this.btnReject.BackColor                  = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnReject.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.FlatAppearance.BorderSize  = 0;
            this.btnReject.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor                  = System.Drawing.Color.White;
            this.btnReject.Location                   = new System.Drawing.Point(140, 58);
            this.btnReject.Name                       = "btnReject";
            this.btnReject.Size                       = new System.Drawing.Size(110, 32);
            this.btnReject.TabIndex                   = 2;
            this.btnReject.Text                       = "Reject";
            this.btnReject.UseVisualStyleBackColor    = false;
            this.btnReject.Enabled                    = false;
            this.btnReject.Click                     += new System.EventHandler(this.btnReject_Click);
            // btnRefresh
            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.White;
            this.btnRefresh.Location                   = new System.Drawing.Point(260, 58);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex                   = 3;
            this.btnRefresh.Text                       = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.btnRefresh_Click);
            // dgvIncomingRequests
            this.dgvIncomingRequests.AllowUserToAddRows          = false;
            this.dgvIncomingRequests.AllowUserToDeleteRows       = false;
            this.dgvIncomingRequests.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvIncomingRequests.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncomingRequests.BackgroundColor             = System.Drawing.Color.White;
            this.dgvIncomingRequests.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvIncomingRequests.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIncomingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomingRequests.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvIncomingRequests.Location                    = new System.Drawing.Point(20, 103);
            this.dgvIncomingRequests.MultiSelect                 = false;
            this.dgvIncomingRequests.Name                        = "dgvIncomingRequests";
            this.dgvIncomingRequests.ReadOnly                    = true;
            this.dgvIncomingRequests.RowHeadersVisible           = false;
            this.dgvIncomingRequests.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingRequests.Size                        = new System.Drawing.Size(910, 417);
            this.dgvIncomingRequests.TabIndex                    = 4;
            this.dgvIncomingRequests.SelectionChanged           += new System.EventHandler(this.dgvIncomingRequests_SelectionChanged);
            this.dgvIncomingRequests.DataBindingComplete        += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIncomingRequests_DataBindingComplete);
            // ucIncomingRequests
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvIncomingRequests);
            this.Name  = "ucIncomingRequests";
            this.Size  = new System.Drawing.Size(950, 540);
            this.Load += new System.EventHandler(this.ucIncomingRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Button          btnAccept;
        private System.Windows.Forms.Button          btnReject;
        private System.Windows.Forms.Button          btnRefresh;
        private System.Windows.Forms.DataGridView    dgvIncomingRequests;
    }
}
