namespace ABCAutomotive.UI.Pages
{
    partial class Payment
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rdoDebit = new System.Windows.Forms.RadioButton();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.rdoCredit = new System.Windows.Forms.RadioButton();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.rdoFullOrLastName = new System.Windows.Forms.RadioButton();
            this.rdoStudentID = new System.Windows.Forms.RadioButton();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 107);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1121, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 105);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(67, 443);
            this.dgvStudentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.RowHeadersWidth = 51;
            this.dgvStudentInfo.Size = new System.Drawing.Size(616, 86);
            this.dgvStudentInfo.TabIndex = 3;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(67, 255);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.Size = new System.Drawing.Size(616, 155);
            this.dgvStudents.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Information";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(78, 128);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(177, 29);
            this.txtPayment.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnConfirm.Location = new System.Drawing.Point(78, 168);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(179, 65);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // rdoDebit
            // 
            this.rdoDebit.AutoSize = true;
            this.rdoDebit.Location = new System.Drawing.Point(82, 52);
            this.rdoDebit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDebit.Name = "rdoDebit";
            this.rdoDebit.Size = new System.Drawing.Size(72, 26);
            this.rdoDebit.TabIndex = 7;
            this.rdoDebit.TabStop = true;
            this.rdoDebit.Text = "Debit";
            this.rdoDebit.UseVisualStyleBackColor = true;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblMsg2);
            this.grpPayment.Controls.Add(this.rdoCredit);
            this.grpPayment.Controls.Add(this.btnConfirm);
            this.grpPayment.Controls.Add(this.txtPayment);
            this.grpPayment.Controls.Add(this.rdoDebit);
            this.grpPayment.Enabled = false;
            this.grpPayment.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.grpPayment.Location = new System.Drawing.Point(691, 255);
            this.grpPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPayment.Size = new System.Drawing.Size(336, 274);
            this.grpPayment.TabIndex = 8;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Make Payment";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMsg2.Location = new System.Drawing.Point(78, 105);
            this.lblMsg2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(0, 22);
            this.lblMsg2.TabIndex = 8;
            // 
            // rdoCredit
            // 
            this.rdoCredit.AutoSize = true;
            this.rdoCredit.Location = new System.Drawing.Point(188, 52);
            this.rdoCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoCredit.Name = "rdoCredit";
            this.rdoCredit.Size = new System.Drawing.Size(77, 26);
            this.rdoCredit.TabIndex = 7;
            this.rdoCredit.TabStop = true;
            this.rdoCredit.Text = "Credit";
            this.rdoCredit.UseVisualStyleBackColor = true;
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMsg1.Location = new System.Drawing.Point(8, 87);
            this.lblMsg1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(0, 22);
            this.lblMsg1.TabIndex = 8;
            // 
            // rdoFullOrLastName
            // 
            this.rdoFullOrLastName.AutoSize = true;
            this.rdoFullOrLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.rdoFullOrLastName.Location = new System.Drawing.Point(8, 30);
            this.rdoFullOrLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoFullOrLastName.Name = "rdoFullOrLastName";
            this.rdoFullOrLastName.Size = new System.Drawing.Size(164, 26);
            this.rdoFullOrLastName.TabIndex = 7;
            this.rdoFullOrLastName.TabStop = true;
            this.rdoFullOrLastName.Text = "Full or Last Name";
            this.rdoFullOrLastName.UseVisualStyleBackColor = true;
            // 
            // rdoStudentID
            // 
            this.rdoStudentID.AutoSize = true;
            this.rdoStudentID.Location = new System.Drawing.Point(8, 58);
            this.rdoStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoStudentID.Name = "rdoStudentID";
            this.rdoStudentID.Size = new System.Drawing.Size(113, 26);
            this.rdoStudentID.TabIndex = 7;
            this.rdoStudentID.TabStop = true;
            this.rdoStudentID.Text = "Student ID";
            this.rdoStudentID.UseVisualStyleBackColor = true;
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.txtSearch);
            this.grpSearchBy.Controls.Add(this.lblMsg1);
            this.grpSearchBy.Controls.Add(this.btnSearch);
            this.grpSearchBy.Controls.Add(this.rdoFullOrLastName);
            this.grpSearchBy.Controls.Add(this.rdoStudentID);
            this.grpSearchBy.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.grpSearchBy.Location = new System.Drawing.Point(420, 70);
            this.grpSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSearchBy.Size = new System.Drawing.Size(263, 143);
            this.grpSearchBy.TabIndex = 9;
            this.grpSearchBy.TabStop = false;
            this.grpSearchBy.Text = "Search by";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpSearchBy);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.dgvStudentInfo);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1121, 624);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rdoDebit;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.RadioButton rdoCredit;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.RadioButton rdoFullOrLastName;
        private System.Windows.Forms.RadioButton rdoStudentID;
        private System.Windows.Forms.GroupBox grpSearchBy;
    }
}
