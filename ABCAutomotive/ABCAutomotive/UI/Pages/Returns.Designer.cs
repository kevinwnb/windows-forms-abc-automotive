namespace ABCAutomotive.UI.Pages
{
    partial class Returns
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBorrowings = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvResource = new System.Windows.Forms.DataGridView();
            this.grpBorrower = new System.Windows.Forms.GroupBox();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtProgramType = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblProgramType = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblResourceMsg = new System.Windows.Forms.Label();
            this.grpBorrowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResource)).BeginInit();
            this.grpBorrower.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1720, 60);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBorrowings
            // 
            this.grpBorrowings.Controls.Add(this.btnReturn);
            this.grpBorrowings.Controls.Add(this.dgvResource);
            this.grpBorrowings.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.grpBorrowings.Location = new System.Drawing.Point(230, 678);
            this.grpBorrowings.Margin = new System.Windows.Forms.Padding(6);
            this.grpBorrowings.Name = "grpBorrowings";
            this.grpBorrowings.Padding = new System.Windows.Forms.Padding(6);
            this.grpBorrowings.Size = new System.Drawing.Size(1325, 411);
            this.grpBorrowings.TabIndex = 6;
            this.grpBorrowings.TabStop = false;
            this.grpBorrowings.Text = "Borrowings";
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(1051, 205);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(214, 81);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // dgvResource
            // 
            this.dgvResource.AllowUserToAddRows = false;
            this.dgvResource.AllowUserToDeleteRows = false;
            this.dgvResource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResource.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResource.Location = new System.Drawing.Point(12, 52);
            this.dgvResource.Margin = new System.Windows.Forms.Padding(6);
            this.dgvResource.Name = "dgvResource";
            this.dgvResource.RowHeadersWidth = 82;
            this.dgvResource.Size = new System.Drawing.Size(918, 342);
            this.dgvResource.TabIndex = 5;
            this.dgvResource.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResource_CellContentClick);
            this.dgvResource.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgvResource_RowStateChanged);
            // 
            // grpBorrower
            // 
            this.grpBorrower.Controls.Add(this.txtBalanceDue);
            this.grpBorrower.Controls.Add(this.lblBalanceDue);
            this.grpBorrower.Controls.Add(this.txtStartDate);
            this.grpBorrower.Controls.Add(this.txtProgramType);
            this.grpBorrower.Controls.Add(this.lblStartDate);
            this.grpBorrower.Controls.Add(this.lblProgramType);
            this.grpBorrower.Controls.Add(this.txtEndDate);
            this.grpBorrower.Controls.Add(this.txtLastName);
            this.grpBorrower.Controls.Add(this.lblEndDate);
            this.grpBorrower.Controls.Add(this.txtFirstName);
            this.grpBorrower.Controls.Add(this.lblLastName);
            this.grpBorrower.Controls.Add(this.txtID);
            this.grpBorrower.Controls.Add(this.lblFirstName);
            this.grpBorrower.Controls.Add(this.lblID);
            this.grpBorrower.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.grpBorrower.Location = new System.Drawing.Point(230, 298);
            this.grpBorrower.Margin = new System.Windows.Forms.Padding(6);
            this.grpBorrower.Name = "grpBorrower";
            this.grpBorrower.Padding = new System.Windows.Forms.Padding(6);
            this.grpBorrower.Size = new System.Drawing.Size(1325, 342);
            this.grpBorrower.TabIndex = 6;
            this.grpBorrower.TabStop = false;
            this.grpBorrower.Text = "Borrower";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalanceDue.Enabled = false;
            this.txtBalanceDue.ForeColor = System.Drawing.Color.Black;
            this.txtBalanceDue.Location = new System.Drawing.Point(264, 271);
            this.txtBalanceDue.Margin = new System.Windows.Forms.Padding(6);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Size = new System.Drawing.Size(196, 42);
            this.txtBalanceDue.TabIndex = 1;
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(258, 240);
            this.lblBalanceDue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(167, 34);
            this.lblBalanceDue.TabIndex = 0;
            this.lblBalanceDue.Text = "Balance Due:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStartDate.Enabled = false;
            this.txtStartDate.ForeColor = System.Drawing.Color.Black;
            this.txtStartDate.Location = new System.Drawing.Point(502, 177);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(196, 42);
            this.txtStartDate.TabIndex = 1;
            // 
            // txtProgramType
            // 
            this.txtProgramType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProgramType.Enabled = false;
            this.txtProgramType.ForeColor = System.Drawing.Color.Black;
            this.txtProgramType.Location = new System.Drawing.Point(264, 177);
            this.txtProgramType.Margin = new System.Windows.Forms.Padding(6);
            this.txtProgramType.Name = "txtProgramType";
            this.txtProgramType.Size = new System.Drawing.Size(196, 42);
            this.txtProgramType.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(496, 146);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(139, 34);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblProgramType
            // 
            this.lblProgramType.AutoSize = true;
            this.lblProgramType.Location = new System.Drawing.Point(258, 146);
            this.lblProgramType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProgramType.Name = "lblProgramType";
            this.lblProgramType.Size = new System.Drawing.Size(187, 34);
            this.lblProgramType.TabIndex = 0;
            this.lblProgramType.Text = "Program Type:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEndDate.Enabled = false;
            this.txtEndDate.ForeColor = System.Drawing.Color.Black;
            this.txtEndDate.Location = new System.Drawing.Point(742, 177);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(196, 42);
            this.txtEndDate.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.Enabled = false;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(742, 87);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(196, 42);
            this.txtLastName.TabIndex = 1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(736, 146);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(129, 34);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(502, 87);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(196, 42);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(736, 56);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(146, 34);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(264, 87);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 42);
            this.txtID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(496, 56);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(148, 34);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(258, 56);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 34);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.lblEnterID.Location = new System.Drawing.Point(501, 174);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(274, 34);
            this.lblEnterID.TabIndex = 9;
            this.lblEnterID.Text = "Enter the Resource ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnSearch.Location = new System.Drawing.Point(1014, 164);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 44);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.txtSearch.Location = new System.Drawing.Point(802, 168);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 42);
            this.txtSearch.TabIndex = 7;
            // 
            // lblResourceMsg
            // 
            this.lblResourceMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.lblResourceMsg.Location = new System.Drawing.Point(502, 235);
            this.lblResourceMsg.Name = "lblResourceMsg";
            this.lblResourceMsg.Size = new System.Drawing.Size(666, 46);
            this.lblResourceMsg.TabIndex = 10;
            this.lblResourceMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResourceMsg);
            this.Controls.Add(this.lblEnterID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBorrowings);
            this.Controls.Add(this.grpBorrower);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Returns";
            this.Size = new System.Drawing.Size(1720, 1150);
            this.grpBorrowings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResource)).EndInit();
            this.grpBorrower.ResumeLayout(false);
            this.grpBorrower.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBorrowings;
        private System.Windows.Forms.DataGridView dgvResource;
        private System.Windows.Forms.GroupBox grpBorrower;
        private System.Windows.Forms.TextBox txtBalanceDue;
        private System.Windows.Forms.Label lblBalanceDue;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtProgramType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblProgramType;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblResourceMsg;
    }
}
