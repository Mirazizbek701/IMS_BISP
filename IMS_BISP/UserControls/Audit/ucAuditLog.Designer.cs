namespace IMS_BISP.UserControls.Audit
{
    partial class ucAuditLog
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
            this.lblTitle      = new System.Windows.Forms.Label();
            this.btnRefresh    = new System.Windows.Forms.Button();
            this.dgvAuditLog   = new System.Windows.Forms.DataGridView();
            this.colLogId      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionType   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoggedAt   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Audit Log";
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
            // dgvAuditLog
            this.dgvAuditLog.AllowUserToAddRows          = false;
            this.dgvAuditLog.AllowUserToDeleteRows       = false;
            this.dgvAuditLog.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvAuditLog.AutoGenerateColumns         = false;
            this.dgvAuditLog.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditLog.BackgroundColor             = System.Drawing.Color.White;
            this.dgvAuditLog.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditLog.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuditLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditLog.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvAuditLog.Location                    = new System.Drawing.Point(20, 103);
            this.dgvAuditLog.MultiSelect                 = false;
            this.dgvAuditLog.Name                        = "dgvAuditLog";
            this.dgvAuditLog.ReadOnly                    = true;
            this.dgvAuditLog.RowHeadersVisible           = false;
            this.dgvAuditLog.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditLog.Size                        = new System.Drawing.Size(910, 417);
            this.dgvAuditLog.TabIndex                    = 2;
            // colLogId
            this.colLogId.DataPropertyName = "LogId";
            this.colLogId.FillWeight       = 5F;
            this.colLogId.HeaderText       = "ID";
            this.colLogId.MinimumWidth     = 45;
            this.colLogId.Name             = "colLogId";
            this.colLogId.ReadOnly         = true;
            // colUsername
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.FillWeight       = 14F;
            this.colUsername.HeaderText       = "Username";
            this.colUsername.MinimumWidth     = 100;
            this.colUsername.Name             = "colUsername";
            this.colUsername.ReadOnly         = true;
            // colFullName
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.FillWeight       = 18F;
            this.colFullName.HeaderText       = "Full Name";
            this.colFullName.MinimumWidth     = 130;
            this.colFullName.Name             = "colFullName";
            this.colFullName.ReadOnly         = true;
            // colActionType
            this.colActionType.DataPropertyName = "ActionType";
            this.colActionType.FillWeight       = 14F;
            this.colActionType.HeaderText       = "Action";
            this.colActionType.MinimumWidth     = 110;
            this.colActionType.Name             = "colActionType";
            this.colActionType.ReadOnly         = true;
            // colActionDetail
            this.colActionDetail.DataPropertyName = "ActionDetail";
            this.colActionDetail.FillWeight       = 36F;
            this.colActionDetail.HeaderText       = "Detail";
            this.colActionDetail.MinimumWidth     = 200;
            this.colActionDetail.Name             = "colActionDetail";
            this.colActionDetail.ReadOnly         = true;
            // colLoggedAt
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.Format = "dd.MM.yyyy HH:mm:ss";
            this.colLoggedAt.DataPropertyName = "LoggedAt";
            this.colLoggedAt.DefaultCellStyle = dataGridViewCellStyle1;
            this.colLoggedAt.FillWeight       = 16F;
            this.colLoggedAt.HeaderText       = "Logged At";
            this.colLoggedAt.MinimumWidth     = 140;
            this.colLoggedAt.Name             = "colLoggedAt";
            this.colLoggedAt.ReadOnly         = true;
            this.dgvAuditLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLogId, this.colUsername, this.colFullName,
                this.colActionType, this.colActionDetail, this.colLoggedAt });
            // ucAuditLog
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvAuditLog);
            this.Name  = "ucAuditLog";
            this.Size  = new System.Drawing.Size(950, 540);
            this.Load += new System.EventHandler(this.ucAuditLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label              lblTitle;
        private System.Windows.Forms.Button             btnRefresh;
        private System.Windows.Forms.DataGridView       dgvAuditLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoggedAt;
    }
}
