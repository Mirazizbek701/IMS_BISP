namespace IMS_BISP.UserControls.Manage
{
    partial class ucContracts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colContractId   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStoreName    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthlyRent  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContractFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaysLeft     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle        = new System.Windows.Forms.Label();
            this.btnAdd          = new System.Windows.Forms.Button();
            this.btnEdit         = new System.Windows.Forms.Button();
            this.btnDelete       = new System.Windows.Forms.Button();
            this.btnOpenFile     = new System.Windows.Forms.Button();
            this.btnRefresh      = new System.Windows.Forms.Button();
            this.dgvContracts    = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            //
            // colContractId
            //
            this.colContractId.DataPropertyName = "ContractId";
            this.colContractId.HeaderText       = "ID";
            this.colContractId.Name             = "colContractId";
            this.colContractId.Visible          = false;
            //
            // colStoreName
            //
            this.colStoreName.DataPropertyName = "StoreName";
            this.colStoreName.FillWeight       = 25F;
            this.colStoreName.HeaderText       = "Store Name";
            this.colStoreName.MinimumWidth     = 140;
            this.colStoreName.Name             = "colStoreName";
            //
            // colStartDate
            //
            dataGridViewCellStyle1.Format      = "dd.MM.yyyy";
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colStartDate.FillWeight       = 15F;
            this.colStartDate.HeaderText       = "Start Date";
            this.colStartDate.MinimumWidth     = 100;
            this.colStartDate.Name             = "colStartDate";
            //
            // colEndDate
            //
            dataGridViewCellStyle2.Format    = "dd.MM.yyyy";
            this.colEndDate.DataPropertyName = "EndDate";
            this.colEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEndDate.FillWeight       = 15F;
            this.colEndDate.HeaderText       = "End Date";
            this.colEndDate.MinimumWidth     = 100;
            this.colEndDate.Name             = "colEndDate";
            //
            // colMonthlyRent
            //
            dataGridViewCellStyle3.Format           = "$ #,##0.00";
            this.colMonthlyRent.DataPropertyName    = "MonthlyRent";
            this.colMonthlyRent.DefaultCellStyle    = dataGridViewCellStyle3;
            this.colMonthlyRent.FillWeight          = 18F;
            this.colMonthlyRent.HeaderText          = "Monthly Rent";
            this.colMonthlyRent.MinimumWidth        = 120;
            this.colMonthlyRent.Name                = "colMonthlyRent";
            //
            // colContractFile
            //
            this.colContractFile.DataPropertyName = "ContractFile";
            this.colContractFile.FillWeight       = 20F;
            this.colContractFile.HeaderText       = "Contract File";
            this.colContractFile.MinimumWidth     = 130;
            this.colContractFile.Name             = "colContractFile";
            //
            // colDaysLeft
            //
            dataGridViewCellStyle4.Alignment      = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDaysLeft.DataPropertyName     = "DaysLeft";
            this.colDaysLeft.DefaultCellStyle     = dataGridViewCellStyle4;
            this.colDaysLeft.FillWeight           = 10F;
            this.colDaysLeft.HeaderText           = "Days Left";
            this.colDaysLeft.MinimumWidth         = 80;
            this.colDaysLeft.Name                 = "colDaysLeft";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitle.Location  = new System.Drawing.Point(18, 15);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "Contracts";
            //
            // btnAdd
            //
            this.btnAdd.BackColor                 = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAdd.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor                 = System.Drawing.Color.White;
            this.btnAdd.Location                  = new System.Drawing.Point(20, 58);
            this.btnAdd.Name                      = "btnAdd";
            this.btnAdd.Size                      = new System.Drawing.Size(120, 32);
            this.btnAdd.TabIndex                  = 1;
            this.btnAdd.Text                      = "Add Contract";
            this.btnAdd.UseVisualStyleBackColor   = false;
            this.btnAdd.Click                    += new System.EventHandler(this.btnAdd_Click);
            //
            // btnEdit
            //
            this.btnEdit.BackColor                 = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnEdit.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor                 = System.Drawing.Color.White;
            this.btnEdit.Location                  = new System.Drawing.Point(150, 58);
            this.btnEdit.Name                      = "btnEdit";
            this.btnEdit.Size                      = new System.Drawing.Size(120, 32);
            this.btnEdit.TabIndex                  = 2;
            this.btnEdit.Text                      = "Edit Contract";
            this.btnEdit.UseVisualStyleBackColor   = false;
            this.btnEdit.Click                    += new System.EventHandler(this.btnEdit_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor                 = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor                 = System.Drawing.Color.White;
            this.btnDelete.Location                  = new System.Drawing.Point(280, 58);
            this.btnDelete.Name                      = "btnDelete";
            this.btnDelete.Size                      = new System.Drawing.Size(130, 32);
            this.btnDelete.TabIndex                  = 3;
            this.btnDelete.Text                      = "Delete Contract";
            this.btnDelete.UseVisualStyleBackColor   = false;
            this.btnDelete.Click                    += new System.EventHandler(this.btnDelete_Click);
            //
            // btnOpenFile
            //
            this.btnOpenFile.BackColor                 = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnOpenFile.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpenFile.ForeColor                 = System.Drawing.Color.White;
            this.btnOpenFile.Location                  = new System.Drawing.Point(420, 58);
            this.btnOpenFile.Name                      = "btnOpenFile";
            this.btnOpenFile.Size                      = new System.Drawing.Size(100, 32);
            this.btnOpenFile.TabIndex                  = 4;
            this.btnOpenFile.Text                      = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor   = false;
            this.btnOpenFile.Click                    += new System.EventHandler(this.btnOpenFile_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.BackColor                 = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnRefresh.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor                 = System.Drawing.Color.White;
            this.btnRefresh.Location                  = new System.Drawing.Point(530, 58);
            this.btnRefresh.Name                      = "btnRefresh";
            this.btnRefresh.Size                      = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex                  = 5;
            this.btnRefresh.Text                      = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor   = false;
            this.btnRefresh.Click                    += new System.EventHandler(this.btnRefresh_Click);
            //
            // dgvContracts
            //
            this.dgvContracts.AllowUserToAddRows    = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.Anchor                = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top    |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left   |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvContracts.AutoGenerateColumns         = false;
            this.dgvContracts.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.BackgroundColor             = System.Drawing.Color.White;
            this.dgvContracts.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvContracts.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.BackColor              = System.Drawing.Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle5.Font                   = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor              = System.Drawing.Color.White;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colContractId,
                this.colStoreName,
                this.colStartDate,
                this.colEndDate,
                this.colMonthlyRent,
                this.colContractFile,
                this.colDaysLeft});
            dataGridViewCellStyle6.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvContracts.DefaultCellStyle            = dataGridViewCellStyle6;
            this.dgvContracts.EnableHeadersVisualStyles   = false;
            this.dgvContracts.GridColor                   = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvContracts.Location                    = new System.Drawing.Point(20, 103);
            this.dgvContracts.MultiSelect                 = false;
            this.dgvContracts.Name                        = "dgvContracts";
            this.dgvContracts.ReadOnly                    = true;
            this.dgvContracts.RowHeadersVisible           = false;
            this.dgvContracts.RowTemplate.Height          = 28;
            this.dgvContracts.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size                        = new System.Drawing.Size(860, 367);
            this.dgvContracts.TabIndex                    = 6;
            this.dgvContracts.CellFormatting             += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContracts_CellFormatting);
            //
            // ucContracts
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvContracts);
            this.Name  = "ucContracts";
            this.Size  = new System.Drawing.Size(900, 490);
            this.Load += new System.EventHandler(this.ucContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colContractId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthlyRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContractFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaysLeft;
        private System.Windows.Forms.Label        lblTitle;
        private System.Windows.Forms.Button       btnAdd;
        private System.Windows.Forms.Button       btnEdit;
        private System.Windows.Forms.Button       btnDelete;
        private System.Windows.Forms.Button       btnOpenFile;
        private System.Windows.Forms.Button       btnRefresh;
        private System.Windows.Forms.DataGridView dgvContracts;
    }
}
