namespace ABCAutomotive.UI.Pages
{
    partial class Loans
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpRessourceToBorrow = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvRessourceToBorrow = new System.Windows.Forms.DataGridView();
            this.picBorrowRessource = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRessourceID = new System.Windows.Forms.TextBox();
            this.btnSearchRessource = new System.Windows.Forms.Button();
            this.grpMatchingStudents = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.picLoanRessource = new System.Windows.Forms.PictureBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.rdoPartialLastName = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.grpStudentInformations = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.grpLoans = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.grpRessourceToBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRessourceToBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrowRessource)).BeginInit();
            this.grpMatchingStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoanRessource)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpStudentInformations.SuspendLayout();
            this.grpLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1037, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Balance Due";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvLoans
            // 
            this.dgvLoans.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(6, 35);
            this.dgvLoans.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersWidth = 82;
            this.dgvLoans.RowTemplate.Height = 33;
            this.dgvLoans.Size = new System.Drawing.Size(413, 164);
            this.dgvLoans.TabIndex = 55;
            this.dgvLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellClick);
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalanceDue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceDue.Location = new System.Drawing.Point(64, 152);
            this.txtBalanceDue.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(154, 25);
            this.txtBalanceDue.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Last Name ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(428, 43);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(154, 25);
            this.txtLastName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(246, 43);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(154, 25);
            this.txtFirstName.TabIndex = 30;
            // 
            // grpRessourceToBorrow
            // 
            this.grpRessourceToBorrow.Controls.Add(this.btnConfirm);
            this.grpRessourceToBorrow.Controls.Add(this.dgvRessourceToBorrow);
            this.grpRessourceToBorrow.Controls.Add(this.picBorrowRessource);
            this.grpRessourceToBorrow.Controls.Add(this.label8);
            this.grpRessourceToBorrow.Controls.Add(this.label10);
            this.grpRessourceToBorrow.Controls.Add(this.txtRessourceID);
            this.grpRessourceToBorrow.Controls.Add(this.btnSearchRessource);
            this.grpRessourceToBorrow.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRessourceToBorrow.Location = new System.Drawing.Point(370, 502);
            this.grpRessourceToBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.grpRessourceToBorrow.Name = "grpRessourceToBorrow";
            this.grpRessourceToBorrow.Padding = new System.Windows.Forms.Padding(2);
            this.grpRessourceToBorrow.Size = new System.Drawing.Size(635, 236);
            this.grpRessourceToBorrow.TabIndex = 50;
            this.grpRessourceToBorrow.TabStop = false;
            this.grpRessourceToBorrow.Text = "Ressource To Borrow";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(18, 199);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(413, 25);
            this.btnConfirm.TabIndex = 47;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvRessourceToBorrow
            // 
            this.dgvRessourceToBorrow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRessourceToBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRessourceToBorrow.Location = new System.Drawing.Point(18, 64);
            this.dgvRessourceToBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRessourceToBorrow.Name = "dgvRessourceToBorrow";
            this.dgvRessourceToBorrow.RowHeadersWidth = 82;
            this.dgvRessourceToBorrow.RowTemplate.Height = 33;
            this.dgvRessourceToBorrow.Size = new System.Drawing.Size(413, 120);
            this.dgvRessourceToBorrow.TabIndex = 56;
            // 
            // picBorrowRessource
            // 
            this.picBorrowRessource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBorrowRessource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBorrowRessource.Location = new System.Drawing.Point(449, 64);
            this.picBorrowRessource.Margin = new System.Windows.Forms.Padding(2);
            this.picBorrowRessource.Name = "picBorrowRessource";
            this.picBorrowRessource.Size = new System.Drawing.Size(158, 161);
            this.picBorrowRessource.TabIndex = 57;
            this.picBorrowRessource.TabStop = false;
            this.picBorrowRessource.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Image";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "ID :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRessourceID
            // 
            this.txtRessourceID.Location = new System.Drawing.Point(148, 29);
            this.txtRessourceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRessourceID.Multiline = true;
            this.txtRessourceID.Name = "txtRessourceID";
            this.txtRessourceID.Size = new System.Drawing.Size(132, 26);
            this.txtRessourceID.TabIndex = 3;
            // 
            // btnSearchRessource
            // 
            this.btnSearchRessource.AutoSize = true;
            this.btnSearchRessource.Location = new System.Drawing.Point(290, 29);
            this.btnSearchRessource.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRessource.Name = "btnSearchRessource";
            this.btnSearchRessource.Size = new System.Drawing.Size(103, 28);
            this.btnSearchRessource.TabIndex = 4;
            this.btnSearchRessource.Text = "Search";
            this.btnSearchRessource.UseVisualStyleBackColor = true;
            this.btnSearchRessource.Click += new System.EventHandler(this.btnSearchRessource_Click);
            // 
            // grpMatchingStudents
            // 
            this.grpMatchingStudents.Controls.Add(this.btnLast);
            this.grpMatchingStudents.Controls.Add(this.btnNext);
            this.grpMatchingStudents.Controls.Add(this.btnPrevious);
            this.grpMatchingStudents.Controls.Add(this.btnFirst);
            this.grpMatchingStudents.Controls.Add(this.dgvStudents);
            this.grpMatchingStudents.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMatchingStudents.Location = new System.Drawing.Point(30, 363);
            this.grpMatchingStudents.Margin = new System.Windows.Forms.Padding(2);
            this.grpMatchingStudents.Name = "grpMatchingStudents";
            this.grpMatchingStudents.Padding = new System.Windows.Forms.Padding(2);
            this.grpMatchingStudents.Size = new System.Drawing.Size(324, 333);
            this.grpMatchingStudents.TabIndex = 52;
            this.grpMatchingStudents.TabStop = false;
            this.grpMatchingStudents.Text = "Matching Student(s)";
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(252, 279);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(58, 31);
            this.btnLast.TabIndex = 55;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(164, 279);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 31);
            this.btnNext.TabIndex = 54;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(93, 279);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(58, 31);
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F);
            this.btnFirst.Location = new System.Drawing.Point(15, 279);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(58, 31);
            this.btnFirst.TabIndex = 52;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(15, 32);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 82;
            this.dgvStudents.RowTemplate.Height = 33;
            this.dgvStudents.Size = new System.Drawing.Size(294, 226);
            this.dgvStudents.TabIndex = 48;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(27, 707);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(326, 31);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(436, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Image";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // picLoanRessource
            // 
            this.picLoanRessource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picLoanRessource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLoanRessource.Location = new System.Drawing.Point(436, 35);
            this.picLoanRessource.Margin = new System.Windows.Forms.Padding(2);
            this.picLoanRessource.Name = "picLoanRessource";
            this.picLoanRessource.Size = new System.Drawing.Size(158, 166);
            this.picLoanRessource.TabIndex = 46;
            this.picLoanRessource.TabStop = false;
            this.picLoanRessource.Visible = false;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.rdoPartialLastName);
            this.grpSearch.Controls.Add(this.rdoID);
            this.grpSearch.Controls.Add(this.txtSearchStudent);
            this.grpSearch.Controls.Add(this.btnSearchStudent);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(30, 69);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpSearch.Size = new System.Drawing.Size(324, 263);
            this.grpSearch.TabIndex = 48;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search By";
            // 
            // rdoPartialLastName
            // 
            this.rdoPartialLastName.AutoSize = true;
            this.rdoPartialLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPartialLastName.Location = new System.Drawing.Point(93, 94);
            this.rdoPartialLastName.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPartialLastName.Name = "rdoPartialLastName";
            this.rdoPartialLastName.Size = new System.Drawing.Size(167, 22);
            this.rdoPartialLastName.TabIndex = 12;
            this.rdoPartialLastName.Text = "Partial / Full Last Name";
            this.rdoPartialLastName.UseVisualStyleBackColor = true;
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Checked = true;
            this.rdoID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoID.Location = new System.Drawing.Point(93, 63);
            this.rdoID.Margin = new System.Windows.Forms.Padding(2);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(40, 22);
            this.rdoID.TabIndex = 11;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "ID";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(56, 145);
            this.txtSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchStudent.Multiline = true;
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(210, 26);
            this.txtSearchStudent.TabIndex = 1;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.AutoSize = true;
            this.btnSearchStudent.Location = new System.Drawing.Point(56, 188);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(208, 44);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // grpStudentInformations
            // 
            this.grpStudentInformations.Controls.Add(this.label11);
            this.grpStudentInformations.Controls.Add(this.label6);
            this.grpStudentInformations.Controls.Add(this.txtStartDate);
            this.grpStudentInformations.Controls.Add(this.txtEndDate);
            this.grpStudentInformations.Controls.Add(this.txtProgram);
            this.grpStudentInformations.Controls.Add(this.label5);
            this.grpStudentInformations.Controls.Add(this.label4);
            this.grpStudentInformations.Controls.Add(this.label9);
            this.grpStudentInformations.Controls.Add(this.txtStudentID);
            this.grpStudentInformations.Controls.Add(this.chkIsActive);
            this.grpStudentInformations.Controls.Add(this.grpLoans);
            this.grpStudentInformations.Controls.Add(this.label3);
            this.grpStudentInformations.Controls.Add(this.txtBalanceDue);
            this.grpStudentInformations.Controls.Add(this.label2);
            this.grpStudentInformations.Controls.Add(this.txtLastName);
            this.grpStudentInformations.Controls.Add(this.label1);
            this.grpStudentInformations.Controls.Add(this.txtFirstName);
            this.grpStudentInformations.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentInformations.Location = new System.Drawing.Point(370, 69);
            this.grpStudentInformations.Margin = new System.Windows.Forms.Padding(2);
            this.grpStudentInformations.Name = "grpStudentInformations";
            this.grpStudentInformations.Padding = new System.Windows.Forms.Padding(2);
            this.grpStudentInformations.Size = new System.Drawing.Size(635, 421);
            this.grpStudentInformations.TabIndex = 49;
            this.grpStudentInformations.TabStop = false;
            this.grpStudentInformations.Text = "Student";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 401);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(631, 18);
            this.label11.TabIndex = 0;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "End Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(246, 99);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(154, 25);
            this.txtStartDate.TabIndex = 65;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(428, 99);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(154, 25);
            this.txtEndDate.TabIndex = 67;
            // 
            // txtProgram
            // 
            this.txtProgram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProgram.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.Location = new System.Drawing.Point(64, 99);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(2);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(154, 25);
            this.txtProgram.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Start Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Program";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(64, 43);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(154, 25);
            this.txtStudentID.TabIndex = 61;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Enabled = false;
            this.chkIsActive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkIsActive.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Tai Le", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(246, 152);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(152, 20);
            this.chkIsActive.TabIndex = 60;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // grpLoans
            // 
            this.grpLoans.Controls.Add(this.dgvLoans);
            this.grpLoans.Controls.Add(this.label7);
            this.grpLoans.Controls.Add(this.picLoanRessource);
            this.grpLoans.Location = new System.Drawing.Point(12, 188);
            this.grpLoans.Margin = new System.Windows.Forms.Padding(2);
            this.grpLoans.Name = "grpLoans";
            this.grpLoans.Padding = new System.Windows.Forms.Padding(2);
            this.grpLoans.Size = new System.Drawing.Size(604, 207);
            this.grpLoans.TabIndex = 46;
            this.grpLoans.TabStop = false;
            this.grpLoans.Text = "Loans";
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grpRessourceToBorrow);
            this.Controls.Add(this.grpMatchingStudents);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpStudentInformations);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loans";
            this.Size = new System.Drawing.Size(1037, 779);
            this.Load += new System.EventHandler(this.Loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.grpRessourceToBorrow.ResumeLayout(false);
            this.grpRessourceToBorrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRessourceToBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrowRessource)).EndInit();
            this.grpMatchingStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoanRessource)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpStudentInformations.ResumeLayout(false);
            this.grpStudentInformations.PerformLayout();
            this.grpLoans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.TextBox txtBalanceDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpRessourceToBorrow;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvRessourceToBorrow;
        private System.Windows.Forms.PictureBox picBorrowRessource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRessourceID;
        private System.Windows.Forms.Button btnSearchRessource;
        private System.Windows.Forms.GroupBox grpMatchingStudents;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLoanRessource;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rdoPartialLastName;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.GroupBox grpStudentInformations;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox grpLoans;
    }
}
