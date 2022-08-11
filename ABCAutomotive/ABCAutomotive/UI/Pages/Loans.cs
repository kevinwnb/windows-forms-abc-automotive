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
using Model;
using System.Text.RegularExpressions;
using Types;

namespace ABCAutomotive.UI.Pages
{
    public partial class Loans : PageControl
    {
        //Try Catch
        public Loans()
        {
            InitializeComponent();
        }

        private List<Loan> loans = new List<Loan>();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            try
            {
                dgvStudents.AutoResizeColumns();
                dgvLoans.AutoResizeColumns();
                dgvResourceToBorrow.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                LoanBL loanBL = new LoanBL();
                List<Student> matchingStudents = new List<Student>();

                string parameter = txtSearchStudent.Text;

                if (rdoID.Checked)
                {
                    matchingStudents.Add(loanBL.GetStudent(Convert.ToInt32(txtSearchStudent.Text)));
                }

                if (rdoPartialLastName.Checked)
                {
                    matchingStudents = loanBL.GetStudents(parameter);
                }

                if (matchingStudents.Count == 0)
                {
                    Error("No matching student");
                }
                else
                {
                    dgvStudents.DataSource = matchingStudents;

                    foreach (DataGridViewColumn column in dgvStudents.Columns)
                    {
                        if (column != dgvStudents.Columns["FirstName"] && column != dgvStudents.Columns["LastName"])
                        {
                            column.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudents.CurrentRow != null)
                {
                    LoanBL loanBL = new LoanBL();
                    DataGridViewCellCollection cells = dgvStudents.CurrentRow.Cells;
                    txtStudentID.Text = cells["ID"].Value.ToString();
                    txtFirstName.Text = cells["FirstName"].Value.ToString();
                    txtLastName.Text = cells["LastName"].Value.ToString();
                    txtProgram.Text = cells["Program"].Value.ToString();
                    txtBalanceDue.Text = cells["BalanceDue"].Value.ToString();
                    txtStartDate.Text = Convert.ToDateTime(cells["StartDate"].Value).Date.ToString("d");
                    txtEndDate.Text = Convert.ToDateTime(cells["EndDate"].Value).Date.ToString("d");
                    chkIsActive.Checked = Convert.ToBoolean(cells["Status"].Value);

                    dgvLoans.DataSource = loanBL.GetStudentLoans(Convert.ToInt32(cells["ID"].Value));
                    dgvLoans.Columns["ID"].Visible = false;
                    dgvLoans.Columns["StudentID"].Visible = false;
                    dgvLoans.Columns["Status"].Visible = false;
                    dgvLoans.Columns["CheckInDate"].Visible = false;
                    dgvLoans.Columns["Price"].Visible = false;
                    dgvLoans.Columns["ReserveStatus"].Visible = false;
                    dgvLoans.Columns["DateRemoved"].Visible = false;
                    dgvLoans.Columns["ReservingStudentID"].Visible = false;
                    dgvLoans.Columns["ResourceID"].DisplayIndex = 0;
                    dgvLoans.Columns["Title"].DisplayIndex = 1;
                    dgvLoans.Columns["Type"].DisplayIndex = 2;
                    dgvLoans.Columns["CheckOutDate"].DisplayIndex = 3;
                    dgvLoans.Columns["ImagePath"].DisplayIndex = 4;
                    dgvLoans.Columns["DueDate"].DisplayIndex = 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                LoanBL loanBL = new LoanBL();
                List<Resource> resources = new List<Resource>();
                Resource resource = loanBL.GetResourceById(Convert.ToInt32(txtResourceID.Text));
                resources.Add(resource);
                dgvResourceToBorrow.DataSource = resources;
                dgvResourceToBorrow.Columns["ResourceID"].Visible = false;
                dgvResourceToBorrow.Columns["Price"].Visible = false;
                dgvResourceToBorrow.Columns["ReservingStudentID"].Visible = false;
                dgvResourceToBorrow.Columns["DateRemoved"].Visible = false;
                dgvResourceToBorrow.Columns["ImagePath"].Visible = false;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.ResourceID = Convert.ToInt32(dgvResourceToBorrow.CurrentRow.Cells["ResourceID"].Value);
            loan.Title = dgvResourceToBorrow.CurrentRow.Cells["Title"].Value.ToString();
            loan.DueDate = DateTime.Today.AddDays(2).AddHours(8.5);
            
            if (this.loans.Any(l => l.ResourceID == loan.ResourceID))
            {
                Error("The selected resource is already added to the list");
                return;
            }

            this.loans.Add(loan);
            dgvAddedResources.DataSource = null;
            dgvAddedResources.DataSource = loans;
            foreach (DataGridViewColumn column in dgvAddedResources.Columns)
            {
                if (column.Name != "Title" && column.Name != "DueDate")
                {
                    column.Visible = false;
                }
            }
        }

        private void Error(string msg)
        {
            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
