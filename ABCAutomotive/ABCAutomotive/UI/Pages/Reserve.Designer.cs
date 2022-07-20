namespace ABCAutomotive.UI.Pages
{
    partial class Reserve
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
            this.lblEnterID = new System.Windows.Forms.Label();
            this.btnSearchRessource = new System.Windows.Forms.Button();
            this.txtResourceID = new System.Windows.Forms.TextBox();
            this.lstResourceInfo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpStudentInformation = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.rdoPartialLastName = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtProgramID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpStudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(2172, 60);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.lblEnterID.Location = new System.Drawing.Point(79, 75);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(161, 34);
            this.lblEnterID.TabIndex = 12;
            this.lblEnterID.Text = "Resource ID:";
            // 
            // btnSearchRessource
            // 
            this.btnSearchRessource.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnSearchRessource.Location = new System.Drawing.Point(85, 169);
            this.btnSearchRessource.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchRessource.Name = "btnSearchRessource";
            this.btnSearchRessource.Size = new System.Drawing.Size(311, 44);
            this.btnSearchRessource.TabIndex = 11;
            this.btnSearchRessource.Text = "Search";
            this.btnSearchRessource.UseVisualStyleBackColor = true;
            // 
            // txtResourceID
            // 
            this.txtResourceID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.txtResourceID.Location = new System.Drawing.Point(85, 115);
            this.txtResourceID.Margin = new System.Windows.Forms.Padding(6);
            this.txtResourceID.Name = "txtResourceID";
            this.txtResourceID.Size = new System.Drawing.Size(311, 42);
            this.txtResourceID.TabIndex = 10;
            // 
            // lstResourceInfo
            // 
            this.lstResourceInfo.Enabled = false;
            this.lstResourceInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.lstResourceInfo.FormattingEnabled = true;
            this.lstResourceInfo.ItemHeight = 34;
            this.lstResourceInfo.Items.AddRange(new object[] {
            ""});
            this.lstResourceInfo.Location = new System.Drawing.Point(471, 73);
            this.lstResourceInfo.Name = "lstResourceInfo";
            this.lstResourceInfo.Size = new System.Drawing.Size(749, 140);
            this.lstResourceInfo.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtResourceID);
            this.panel1.Controls.Add(this.lstResourceInfo);
            this.panel1.Controls.Add(this.lblEnterID);
            this.panel1.Controls.Add(this.btnSearchRessource);
            this.panel1.Location = new System.Drawing.Point(78, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 287);
            this.panel1.TabIndex = 14;
            // 
            // grpStudentInformation
            // 
            this.grpStudentInformation.Controls.Add(this.dgvStudents);
            this.grpStudentInformation.Controls.Add(this.rdoPartialLastName);
            this.grpStudentInformation.Controls.Add(this.rdoID);
            this.grpStudentInformation.Controls.Add(this.txtSearchStudent);
            this.grpStudentInformation.Controls.Add(this.btnSearchStudent);
            this.grpStudentInformation.Controls.Add(this.label11);
            this.grpStudentInformation.Controls.Add(this.panel2);
            this.grpStudentInformation.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.grpStudentInformation.Location = new System.Drawing.Point(78, 418);
            this.grpStudentInformation.Name = "grpStudentInformation";
            this.grpStudentInformation.Size = new System.Drawing.Size(1267, 784);
            this.grpStudentInformation.TabIndex = 15;
            this.grpStudentInformation.TabStop = false;
            this.grpStudentInformation.Text = "Students Information";
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(473, 75);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 82;
            this.dgvStudents.RowTemplate.Height = 33;
            this.dgvStudents.Size = new System.Drawing.Size(749, 240);
            this.dgvStudents.TabIndex = 62;
            // 
            // rdoPartialLastName
            // 
            this.rdoPartialLastName.AutoSize = true;
            this.rdoPartialLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPartialLastName.Location = new System.Drawing.Point(87, 121);
            this.rdoPartialLastName.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPartialLastName.Name = "rdoPartialLastName";
            this.rdoPartialLastName.Size = new System.Drawing.Size(320, 38);
            this.rdoPartialLastName.TabIndex = 61;
            this.rdoPartialLastName.Text = "Partial / Full Last Name";
            this.rdoPartialLastName.UseVisualStyleBackColor = true;
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Checked = true;
            this.rdoID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoID.Location = new System.Drawing.Point(87, 75);
            this.rdoID.Margin = new System.Windows.Forms.Padding(4);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(72, 38);
            this.rdoID.TabIndex = 60;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "ID";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(87, 180);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStudent.Multiline = true;
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(311, 46);
            this.txtSearchStudent.TabIndex = 58;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.AutoSize = true;
            this.btnSearchStudent.Location = new System.Drawing.Point(87, 255);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(311, 47);
            this.btnSearchStudent.TabIndex = 59;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 746);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1261, 35);
            this.label11.TabIndex = 54;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtStartDate);
            this.panel2.Controls.Add(this.txtEndDate);
            this.panel2.Controls.Add(this.txtProgramID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtStudentID);
            this.panel2.Controls.Add(this.chkIsActive);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBalanceDue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Location = new System.Drawing.Point(73, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 370);
            this.panel2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1156, 39);
            this.label7.TabIndex = 99;
            this.label7.Text = "Student Personal Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 31);
            this.label6.TabIndex = 98;
            this.label6.Text = "End Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(423, 201);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(304, 42);
            this.txtStartDate.TabIndex = 95;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(787, 201);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(304, 42);
            this.txtEndDate.TabIndex = 97;
            // 
            // txtProgramID
            // 
            this.txtProgramID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProgramID.Enabled = false;
            this.txtProgramID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramID.Location = new System.Drawing.Point(59, 201);
            this.txtProgramID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgramID.Name = "txtProgramID";
            this.txtProgramID.ReadOnly = true;
            this.txtProgramID.Size = new System.Drawing.Size(304, 42);
            this.txtProgramID.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 31);
            this.label5.TabIndex = 96;
            this.label5.Text = "Start Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 94;
            this.label4.Text = "Program Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 31);
            this.label9.TabIndex = 92;
            this.label9.Text = "ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(59, 94);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(304, 42);
            this.txtStudentID.TabIndex = 91;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Enabled = false;
            this.chkIsActive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkIsActive.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(423, 303);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(304, 38);
            this.chkIsActive.TabIndex = 90;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 31);
            this.label3.TabIndex = 89;
            this.label3.Text = "Balance Due :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalanceDue.Enabled = false;
            this.txtBalanceDue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceDue.Location = new System.Drawing.Point(59, 303);
            this.txtBalanceDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(304, 42);
            this.txtBalanceDue.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 87;
            this.label2.Text = "Last Name ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(787, 94);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(304, 42);
            this.txtLastName.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(423, 94);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(304, 42);
            this.txtFirstName.TabIndex = 84;
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnReserve.Location = new System.Drawing.Point(511, 1245);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(323, 64);
            this.btnReserve.TabIndex = 16;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.grpStudentInformation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Name = "Reserve";
            this.Size = new System.Drawing.Size(2172, 1339);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpStudentInformation.ResumeLayout(false);
            this.grpStudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.Button btnSearchRessource;
        private System.Windows.Forms.TextBox txtResourceID;
        private System.Windows.Forms.ListBox lstResourceInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpStudentInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtProgramID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalanceDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.RadioButton rdoPartialLastName;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnReserve;
    }
}
