namespace ABCAutomotive
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnModifyStudent);
            this.panel1.Controls.Add(this.btnReserve);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnReturns);
            this.panel1.Controls.Add(this.btnLoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 523);
            this.panel1.TabIndex = 1;
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.FlatAppearance.BorderSize = 0;
            this.btnModifyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyStudent.ForeColor = System.Drawing.Color.White;
            this.btnModifyStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyStudent.Location = new System.Drawing.Point(9, 379);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(197, 58);
            this.btnModifyStudent.TabIndex = 6;
            this.btnModifyStudent.Text = "Add | Edit\r\nStudent\r\n";
            this.btnModifyStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(12, 318);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(197, 54);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 144);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(12, 258);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(197, 54);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnReturns
            // 
            this.btnReturns.FlatAppearance.BorderSize = 0;
            this.btnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturns.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturns.ForeColor = System.Drawing.Color.White;
            this.btnReturns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturns.Location = new System.Drawing.Point(12, 204);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(197, 54);
            this.btnReturns.TabIndex = 4;
            this.btnReturns.Text = "Returns";
            this.btnReturns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturns.UseVisualStyleBackColor = true;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(12, 144);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(197, 54);
            this.btnLoan.TabIndex = 4;
            this.btnLoan.Text = "Loans";
            this.btnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 523);
            this.panel2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "ABC Automotive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnReturns;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnModifyStudent;
    }
}

