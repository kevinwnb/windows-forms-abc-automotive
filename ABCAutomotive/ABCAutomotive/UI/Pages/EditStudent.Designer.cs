namespace ABCAutomotive.UI.Pages
{
    partial class EditStudent
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
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoDeleteStudent = new System.Windows.Forms.RadioButton();
            this.rdoEditStudent = new System.Windows.Forms.RadioButton();
            this.rdoAddStudent = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpMatchingStudents = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdoPartialLastName = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.grpStudentInformation = new System.Windows.Forms.GroupBox();
            this.lblDisplayD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProgramID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlChoice.SuspendLayout();
            this.grpMatchingStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpStudentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1235, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlChoice
            // 
            this.pnlChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChoice.Controls.Add(this.label7);
            this.pnlChoice.Controls.Add(this.rdoDeleteStudent);
            this.pnlChoice.Controls.Add(this.rdoEditStudent);
            this.pnlChoice.Controls.Add(this.rdoAddStudent);
            this.pnlChoice.Location = new System.Drawing.Point(175, 68);
            this.pnlChoice.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(703, 81);
            this.pnlChoice.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(701, 25);
            this.label7.TabIndex = 100;
            this.label7.Text = "What would you like to do?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoDeleteStudent
            // 
            this.rdoDeleteStudent.AutoSize = true;
            this.rdoDeleteStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.rdoDeleteStudent.Location = new System.Drawing.Point(525, 42);
            this.rdoDeleteStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDeleteStudent.Name = "rdoDeleteStudent";
            this.rdoDeleteStudent.Size = new System.Drawing.Size(145, 26);
            this.rdoDeleteStudent.TabIndex = 6;
            this.rdoDeleteStudent.TabStop = true;
            this.rdoDeleteStudent.Text = "Delete Student";
            this.rdoDeleteStudent.UseVisualStyleBackColor = true;
            this.rdoDeleteStudent.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoEditStudent
            // 
            this.rdoEditStudent.AutoSize = true;
            this.rdoEditStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.rdoEditStudent.Location = new System.Drawing.Point(281, 42);
            this.rdoEditStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rdoEditStudent.Name = "rdoEditStudent";
            this.rdoEditStudent.Size = new System.Drawing.Size(125, 26);
            this.rdoEditStudent.TabIndex = 5;
            this.rdoEditStudent.TabStop = true;
            this.rdoEditStudent.Text = "Edit Student";
            this.rdoEditStudent.UseVisualStyleBackColor = true;
            this.rdoEditStudent.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoAddStudent
            // 
            this.rdoAddStudent.AutoSize = true;
            this.rdoAddStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.rdoAddStudent.Location = new System.Drawing.Point(37, 42);
            this.rdoAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAddStudent.Name = "rdoAddStudent";
            this.rdoAddStudent.Size = new System.Drawing.Size(127, 26);
            this.rdoAddStudent.TabIndex = 4;
            this.rdoAddStudent.TabStop = true;
            this.rdoAddStudent.Text = "Add Student";
            this.rdoAddStudent.UseVisualStyleBackColor = true;
            this.rdoAddStudent.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnConfirm.Location = new System.Drawing.Point(389, 808);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(283, 35);
            this.btnConfirm.TabIndex = 79;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grpMatchingStudents
            // 
            this.grpMatchingStudents.Controls.Add(this.btnLast);
            this.grpMatchingStudents.Controls.Add(this.btnNext);
            this.grpMatchingStudents.Controls.Add(this.btnPrevious);
            this.grpMatchingStudents.Controls.Add(this.btnFirst);
            this.grpMatchingStudents.Controls.Add(this.dgvStudents);
            this.grpMatchingStudents.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMatchingStudents.Location = new System.Drawing.Point(73, 372);
            this.grpMatchingStudents.Name = "grpMatchingStudents";
            this.grpMatchingStudents.Size = new System.Drawing.Size(445, 398);
            this.grpMatchingStudents.TabIndex = 81;
            this.grpMatchingStudents.TabStop = false;
            this.grpMatchingStudents.Text = "Matching Student(s)";
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(336, 344);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(77, 38);
            this.btnLast.TabIndex = 55;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(219, 344);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(77, 38);
            this.btnNext.TabIndex = 54;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(124, 344);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(77, 38);
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnFirst.Location = new System.Drawing.Point(20, 344);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(77, 38);
            this.btnFirst.TabIndex = 52;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(20, 40);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 82;
            this.dgvStudents.RowTemplate.Height = 33;
            this.dgvStudents.Size = new System.Drawing.Size(392, 278);
            this.dgvStudents.TabIndex = 48;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.rdoPartialLastName);
            this.grpSearch.Controls.Add(this.rdoID);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearchStudent);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(73, 179);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(445, 180);
            this.grpSearch.TabIndex = 82;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search By";
            // 
            // rdoPartialLastName
            // 
            this.rdoPartialLastName.AutoSize = true;
            this.rdoPartialLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPartialLastName.Location = new System.Drawing.Point(64, 53);
            this.rdoPartialLastName.Name = "rdoPartialLastName";
            this.rdoPartialLastName.Size = new System.Drawing.Size(208, 26);
            this.rdoPartialLastName.TabIndex = 12;
            this.rdoPartialLastName.Text = "Partial / Full Last Name";
            this.rdoPartialLastName.UseVisualStyleBackColor = true;
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Checked = true;
            this.rdoID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoID.Location = new System.Drawing.Point(64, 24);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(48, 26);
            this.rdoID.TabIndex = 11;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "ID";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 92);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 31);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.AutoSize = true;
            this.btnSearchStudent.Location = new System.Drawing.Point(64, 132);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(283, 32);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // grpStudentInformation
            // 
            this.grpStudentInformation.Controls.Add(this.dtpEndDate);
            this.grpStudentInformation.Controls.Add(this.dtpStartDate);
            this.grpStudentInformation.Controls.Add(this.lblDisplayD);
            this.grpStudentInformation.Controls.Add(this.label6);
            this.grpStudentInformation.Controls.Add(this.txtProgramID);
            this.grpStudentInformation.Controls.Add(this.label5);
            this.grpStudentInformation.Controls.Add(this.label4);
            this.grpStudentInformation.Controls.Add(this.chkIsActive);
            this.grpStudentInformation.Controls.Add(this.label3);
            this.grpStudentInformation.Controls.Add(this.txtBalanceDue);
            this.grpStudentInformation.Controls.Add(this.label2);
            this.grpStudentInformation.Controls.Add(this.txtLastName);
            this.grpStudentInformation.Controls.Add(this.label8);
            this.grpStudentInformation.Controls.Add(this.txtFirstName);
            this.grpStudentInformation.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentInformation.Location = new System.Drawing.Point(542, 187);
            this.grpStudentInformation.Name = "grpStudentInformation";
            this.grpStudentInformation.Size = new System.Drawing.Size(411, 584);
            this.grpStudentInformation.TabIndex = 83;
            this.grpStudentInformation.TabStop = false;
            this.grpStudentInformation.Text = "Student Information";
            // 
            // lblDisplayD
            // 
            this.lblDisplayD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDisplayD.Location = new System.Drawing.Point(3, 559);
            this.lblDisplayD.Name = "lblDisplayD";
            this.lblDisplayD.Size = new System.Drawing.Size(405, 22);
            this.lblDisplayD.TabIndex = 69;
            this.lblDisplayD.Text = "label1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "End Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProgramID
            // 
            this.txtProgramID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProgramID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramID.Location = new System.Drawing.Point(85, 212);
            this.txtProgramID.Name = "txtProgramID";
            this.txtProgramID.Size = new System.Drawing.Size(204, 29);
            this.txtProgramID.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Start Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Program Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            this.chkIsActive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkIsActive.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(85, 465);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(203, 24);
            this.chkIsActive.TabIndex = 60;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Balance Due :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalanceDue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceDue.Location = new System.Drawing.Point(85, 401);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Size = new System.Drawing.Size(204, 29);
            this.txtBalanceDue.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Last Name ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(85, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(204, 29);
            this.txtLastName.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "First Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(85, 83);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(204, 29);
            this.txtFirstName.TabIndex = 30;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(86, 274);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(203, 29);
            this.dtpStartDate.TabIndex = 70;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(86, 333);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(203, 29);
            this.dtpEndDate.TabIndex = 71;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpStudentInformation);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpMatchingStudents);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlChoice);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditStudent";
            this.Size = new System.Drawing.Size(1235, 886);
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.pnlChoice.ResumeLayout(false);
            this.pnlChoice.PerformLayout();
            this.grpMatchingStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpStudentInformation.ResumeLayout(false);
            this.grpStudentInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.RadioButton rdoDeleteStudent;
        private System.Windows.Forms.RadioButton rdoEditStudent;
        private System.Windows.Forms.RadioButton rdoAddStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox grpMatchingStudents;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdoPartialLastName;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.GroupBox grpStudentInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProgramID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalanceDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDisplayD;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}
