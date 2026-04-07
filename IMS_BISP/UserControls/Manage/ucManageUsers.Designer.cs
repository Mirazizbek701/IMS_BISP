namespace IMS_BISP.UserControls.Manage
{
    partial class ucManageUsers
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
            this.lblTitle          = new System.Windows.Forms.Label();
            this.btnAdd            = new System.Windows.Forms.Button();
            this.btnEdit           = new System.Windows.Forms.Button();
            this.btnToggleActive   = new System.Windows.Forms.Button();
            this.btnResetPassword  = new System.Windows.Forms.Button();
            this.btnRefresh        = new System.Windows.Forms.Button();
            this.dgvUsers          = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Manage Users";
            //
            // btnAdd
            //
            this.btnAdd.BackColor                  = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAdd.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize  = 0;
            this.btnAdd.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor                  = System.Drawing.Color.White;
            this.btnAdd.Location                   = new System.Drawing.Point(20, 58);
            this.btnAdd.Name                       = "btnAdd";
            this.btnAdd.Size                       = new System.Drawing.Size(110, 32);
            this.btnAdd.TabIndex                   = 1;
            this.btnAdd.Text                       = "Add User";
            this.btnAdd.UseVisualStyleBackColor    = false;
            this.btnAdd.Click                     += new System.EventHandler(this.btnAdd_Click);
            //
            // btnEdit
            //
            this.btnEdit.BackColor                  = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnEdit.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize  = 0;
            this.btnEdit.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor                  = System.Drawing.Color.White;
            this.btnEdit.Location                   = new System.Drawing.Point(140, 58);
            this.btnEdit.Name                       = "btnEdit";
            this.btnEdit.Size                       = new System.Drawing.Size(110, 32);
            this.btnEdit.TabIndex                   = 2;
            this.btnEdit.Text                       = "Edit User";
            this.btnEdit.UseVisualStyleBackColor    = false;
            this.btnEdit.Click                     += new System.EventHandler(this.btnEdit_Click);
            //
            // btnToggleActive
            //
            this.btnToggleActive.BackColor                  = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnToggleActive.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnToggleActive.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleActive.FlatAppearance.BorderSize  = 0;
            this.btnToggleActive.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleActive.ForeColor                  = System.Drawing.Color.White;
            this.btnToggleActive.Location                   = new System.Drawing.Point(260, 58);
            this.btnToggleActive.Name                       = "btnToggleActive";
            this.btnToggleActive.Size                       = new System.Drawing.Size(120, 32);
            this.btnToggleActive.TabIndex                   = 3;
            this.btnToggleActive.Text                       = "Deactivate";
            this.btnToggleActive.UseVisualStyleBackColor    = false;
            this.btnToggleActive.Click                     += new System.EventHandler(this.btnToggleActive_Click);
            //
            // btnResetPassword
            //
            this.btnResetPassword.BackColor                  = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnResetPassword.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.FlatAppearance.BorderSize  = 0;
            this.btnResetPassword.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor                  = System.Drawing.Color.White;
            this.btnResetPassword.Location                   = new System.Drawing.Point(390, 58);
            this.btnResetPassword.Name                       = "btnResetPassword";
            this.btnResetPassword.Size                       = new System.Drawing.Size(140, 32);
            this.btnResetPassword.TabIndex                   = 4;
            this.btnResetPassword.Text                       = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor    = false;
            this.btnResetPassword.Click                     += new System.EventHandler(this.btnResetPassword_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.White;
            this.btnRefresh.Location                   = new System.Drawing.Point(540, 58);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex                   = 5;
            this.btnRefresh.Text                       = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvUsers
            //
            this.dgvUsers.AllowUserToAddRows          = false;
            this.dgvUsers.AllowUserToDeleteRows       = false;
            this.dgvUsers.Anchor                      = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvUsers.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor             = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvUsers.Location                    = new System.Drawing.Point(20, 103);
            this.dgvUsers.MultiSelect                 = false;
            this.dgvUsers.Name                        = "dgvUsers";
            this.dgvUsers.ReadOnly                    = true;
            this.dgvUsers.RowHeadersVisible           = false;
            this.dgvUsers.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size                        = new System.Drawing.Size(860, 370);
            this.dgvUsers.TabIndex                    = 6;
            this.dgvUsers.SelectionChanged           += new System.EventHandler(this.dgvUsers_SelectionChanged);
            //
            // ucManageUsers
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnToggleActive);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvUsers);
            this.Name  = "ucManageUsers";
            this.Size  = new System.Drawing.Size(900, 490);
            this.Load += new System.EventHandler(this.ucManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label           lblTitle;
        private System.Windows.Forms.Button          btnAdd;
        private System.Windows.Forms.Button          btnEdit;
        private System.Windows.Forms.Button          btnToggleActive;
        private System.Windows.Forms.Button          btnResetPassword;
        private System.Windows.Forms.Button          btnRefresh;
        private System.Windows.Forms.DataGridView    dgvUsers;
    }
}
