using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Text.RegularExpressions;

namespace ABCAutomotive.UI.Pages
{
    public partial class Payment : PageControl
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg1.Text = string.Empty;
                int searchBy = 0;

                if (rdoStudentID.Checked)
                {
                    searchBy = 1;
                }

                Regex reg = new Regex("[0-9]{8}");
                if (rdoStudentID.Checked && !reg.IsMatch(txtSearch.Text))
                {
                    lblMsg1.Text = "Please enter a valid 8 digits number for the student Id.";
                }
                else
                {
                    StudentBL studentBL = new StudentBL();
                    dgvStudents.DataSource = studentBL.PaymentGetStudents(txtSearch.Text, searchBy);
                    dgvStudents.Columns["ID"].Visible = false;
                    dgvStudents.Columns["BalanceDue"].Visible = false;
                    dgvStudents.Columns["Status"].Visible = false;
                    dgvStudents.Columns["ProgramID"].Visible = false;
                    dgvStudents.Columns["StartDate"].Visible = false;
                    dgvStudents.Columns["EndDate"].Visible = false;
                    foreach (DataGridViewColumn column in dgvStudents.Columns)
                    {
                        column.ReadOnly = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StudentPaymentBL studentPaymentBL = new StudentPaymentBL();
                string studentID = dgvStudents.CurrentRow.Cells["ID"].Value.ToString();

                dgvStudentInfo.DataSource = studentPaymentBL.GetStudentInfo(studentID);
                foreach (DataGridViewColumn column in dgvStudentInfo.Columns)
                {
                    column.ReadOnly = true;
                }

                if (dgvStudentInfo.DataSource != null && dgvStudentInfo.Rows.Count != 0 && dgvStudents.Rows.Count != 0 && dgvStudents.DataSource != null)
                {
                    grpPayment.Enabled = true;
                }
                else
                {
                    grpPayment.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg2.Text = string.Empty;
                if (Convert.ToDecimal(dgvStudentInfo.Rows[0].Cells["BalanceDue"].Value) <= 0)
                {
                    lblMsg2.Text = "This student has not any balance due";
                    //MessageBox.Show("This student has not any balance due");
                }
                else if (txtPayment.Text == string.Empty)
                {
                    lblMsg2.Text = "Enter a valid amount";
                }
                else if (Convert.ToDecimal(txtPayment.Text) > Convert.ToDecimal(dgvStudentInfo.Rows[0].Cells["BalanceDue"].Value))
                {
                    lblMsg2.Text = "The payment cannot be greater than the student's current balancedue";
                    //MessageBox.Show("The payment cannot be greater than the student's current balancedue");
                }
                else if (txtPayment.Text == string.Empty)
                {
                    lblMsg2.Text = "Please enter the amount to pay";
                    //MessageBox.Show("Please enter the amount to pay");
                }
                else
                {
                    StudentBL studentBL = new StudentBL();
                    PaymentBL paymentBL = new PaymentBL();

                    string type = string.Empty;
                    if (rdoCredit.Checked == true)
                    {
                        type = "Credit";
                    }
                    else
                    {
                        type = "Debit";
                    }

                    if (studentBL.MakePayment(dgvStudents.CurrentRow.Cells["ID"].Value.ToString(), Convert.ToDecimal(txtPayment.Text)) &&
                        paymentBL.AddPayment(Convert.ToInt32(dgvStudents.CurrentRow.Cells["ID"].Value), Convert.ToDecimal(txtPayment.Text), type))
                    {
                        MessageBox.Show("Payment was successful");
                        txtSearch.Clear();
                        txtPayment.Clear();
                        rdoDebit.Checked = true;
                        dgvStudents.DataSource = null;
                        dgvStudentInfo.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Payment failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            try
            {
                rdoFullOrLastName.Checked = true;
                rdoDebit.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
