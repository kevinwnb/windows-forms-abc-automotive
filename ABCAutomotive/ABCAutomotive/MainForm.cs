using ABCAutomotive.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCAutomotive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private PageControl current_page = null;

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Loans loans = new Loans();
            SidePanel.Height = btnLoan.Height;
            SidePanel.Top = btnLoan.Top;

            if (current_page != null)
            {
                current_page.Close();
            }

            panel2.Controls.Add(loans);

            this.current_page = loans;
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            Returns returns = new Returns();
            SidePanel.Height = btnReturns.Height;
            SidePanel.Top = btnReturns.Top;

            if (current_page != null)
            {
                current_page.Close();
            }

            panel2.Controls.Add(returns);
            
            this.current_page = returns;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            SidePanel.Height = btnPayment.Height;
            SidePanel.Top = btnPayment.Top;

            if (current_page != null)
            {
                current_page.Close();
            }

            panel2.Controls.Add(payment);

            current_page = payment;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            if (login.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            SidePanel.Height = btnReserve.Height;
            SidePanel.Top = btnReserve.Top;

            if (current_page != null)
            {
                current_page.Close();
            }

            panel2.Controls.Add(reserve);

            current_page = reserve;

        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            EditStudent student = new EditStudent();
            SidePanel.Height = btnModifyStudent.Height;
            SidePanel.Top = btnModifyStudent.Top;

            if (current_page != null)
            {
                current_page.Close();
            }

            panel2.Controls.Add(student);

            current_page = student;
        }
    }
}
