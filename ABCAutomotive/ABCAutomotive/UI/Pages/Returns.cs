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
using Types;

namespace ABCAutomotive.UI.Pages
{
    public partial class Returns : PageControl
    {
        private int validationCount; //Has to be 3
        public Returns()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
                dgvResource.ColumnHeadersVisible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void Search()
        {
            lblResourceMsg.ResetText();

            if (int.TryParse(txtSearch.Text, out int result) && Convert.ToInt32(txtSearch.Text) >= 0)
            {
                StudentBL studentBL = new StudentBL();
                Student student = studentBL.GetStudentByResourceId(Convert.ToInt32(txtSearch.Text));
                if (student.ID != null)
                {
                    PopulateStudentForm(student);
                }

                dgvResource.Columns.Clear();
                //ResourceBL resourceBL = new ResourceBL();
                //DataTable dt = resourceBL.GetResource(Convert.ToInt32(txtSearch.Text));

                int resourceID = Convert.ToInt32(txtSearch.Text);
                BorrowingBL borrowingBL = new BorrowingBL();
                List<Borrowing> borrowings = borrowingBL.GetBorrowings(resourceID);

                if (borrowings.Count > 0)
                {
                    dgvResource.DataSource = borrowings;
                    dgvResource.Columns["LoanID"].Visible = false;

                    foreach (DataGridViewColumn column in dgvResource.Columns)
                    {
                        column.ReadOnly = true;
                    }
                    DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                    checkColumn.Name = "returnedDamaged";
                    checkColumn.HeaderText = "Returned Damaged";
                    checkColumn.Width = 50;
                    checkColumn.ReadOnly = false;
                    checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                    dgvResource.Columns.Add(checkColumn);

                    DataGridViewCheckBoxColumn checkColumn2 = new DataGridViewCheckBoxColumn();
                    checkColumn2.Name = "notReturned";
                    checkColumn2.HeaderText = "Not Returned";
                    checkColumn2.Width = 50;
                    checkColumn2.ReadOnly = false;
                    checkColumn2.FillWeight = 10;
                    dgvResource.Columns.Add(checkColumn2);
                    //DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
                    //textColumn.Name = "replacementPrice";
                    //textColumn.HeaderText = "Replacement Price";
                    //textColumn.ReadOnly = false;
                    //dgvResource.Columns.Add(textColumn);

      
                }
                else
                {
                    ResetFormFields();
                    lblResourceMsg.Text = "This resource is not on loan";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID to search for", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateStudentForm(Student student)
        {
            txtID.Text = student.ID.ToString();
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtProgramType.Text = student.ProgramID.ToString();
            txtStartDate.Text = student.StartDate.ToString();
            txtEndDate.Text = student.EndDate.ToString();
            txtBalanceDue.Text = student.BalanceDue.ToString();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResource.Columns["LoanID"].Visible = false;
                validationCount = 0;
                LoanBL loanBL = new LoanBL();
                List<Loan> loans = new List<Loan>();
                foreach (DataGridViewRow row in dgvResource.SelectedRows)
                {
                    Loan loan = loanBL.GetLoanByID(Convert.ToInt32(row.Cells["LoanID"].Value));
                    //loan.RessourceID = Convert.ToInt32(row.Cells["ID"].Value);
                    if (Convert.ToBoolean(row.Cells["returnedDamaged"].Value))
                    {
                        loan.Status = LoanStatus.ReturnedDamaged;
                        loan.CheckInDate = DateTime.Now;

                    }
                    else if (Convert.ToBoolean(row.Cells["notReturned"].Value))
                    {
                        loan.Status = LoanStatus.NotReturned;
                    }
                    else
                    {
                        loan.Status = LoanStatus.Returned;
                        loan.CheckInDate = DateTime.Now;
                    }
                    loans.Add(loan);
                }
                if (loanBL.UpdateLoanStatus(loans))
                {
                    //success
                    validationCount++;
                }

                ResourceBL resourceBL = new ResourceBL();
                List<Resource> resources = new List<Resource>();
                foreach (DataGridViewRow row in dgvResource.SelectedRows)
                {
                    Resource resource = resourceBL.GetResourceToUpDate(Convert.ToInt32(row.Cells["ResourceID"].Value));

                    if (Convert.ToBoolean(row.Cells["notReturned"].Value) || Convert.ToBoolean(row.Cells["returnedDamaged"].Value))
                    {
                        resource.Status = ResourceStatus.NotAvailable;
                        resource.DateRemoved = DateTime.Now;
                    }
                    resources.Add(resource);
                }
                if (resourceBL.UpdateResourceStatus(resources))
                {
                    //success
                    validationCount++;
                }

                StudentBL studentBL = new StudentBL();
                Student student = new Student();
                student.ID = Convert.ToInt32(txtID.Text);
                student.BalanceDue = Convert.ToDecimal(txtBalanceDue.Text);
                decimal replacementAmount = 0;
                int numDaysOverDue = 0;
                foreach (DataGridViewRow row in dgvResource.SelectedRows)
                {
                    if (Convert.ToBoolean(row.Cells["returnedDamaged"].Value) || Convert.ToBoolean(row.Cells["notReturned"].Value))
                    {
                        resourceBL = new ResourceBL();
                        decimal resourcePrice = Convert.ToDecimal(resourceBL.GetResourcePrice(Convert.ToInt32(row.Cells["ResourceID"].Value)).Rows[0]["Price"]);
                        replacementAmount += resourcePrice;
                    }
                    if ((DateTime.Now - Convert.ToDateTime(row.Cells["DueDate"].Value)).Milliseconds > 0)
                    {
                        numDaysOverDue += (DateTime.Now - Convert.ToDateTime(row.Cells["DueDate"].Value)).Days;
                    }
                    if (numDaysOverDue > 10)
                    {
                        decimal resourcePrice = Convert.ToDecimal(resourceBL.GetResourcePrice(Convert.ToInt32(row.Cells["ResourceID"].Value)).Rows[0]["Price"]);
                        replacementAmount += resourcePrice;
                    }
                }
                if (studentBL.UpdateStudentBalanceDue(numDaysOverDue, replacementAmount, student))
                {
                    //success
                    validationCount++;
                }


                if (validationCount == 3)
                {
                    //Search();
                    ResetFormFields(true);
                    txtSearch.ResetText();
                    MessageBox.Show("The selected loans were updated correctly");
                }
                else
                {
                    MessageBox.Show("The record has been updated", "Update Succesful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DgvResource_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {

                if (dgvResource.SelectedRows.Count > 0)
                {
                    btnReturn.Enabled = true;
                }
                else
                {
                    btnReturn.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvResource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string name = dgvResource.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name;


                if (name == "returnedDamaged")
                {
                    if (Convert.ToBoolean(dgvResource.Rows[e.RowIndex].Cells[name].Value) == false)
                    {
                        dgvResource.Rows[e.RowIndex].Cells[name].Value = true;
                        dgvResource.Rows[e.RowIndex].Cells["notReturned"].Value = false;
                    }

                }

                if (name == "notReturned")
                {
                    if (Convert.ToBoolean(dgvResource.Rows[e.RowIndex].Cells[name].Value) == false)
                    {
                        dgvResource.Rows[e.RowIndex].Cells[name].Value = true;
                        dgvResource.Rows[e.RowIndex].Cells["returnedDamaged"].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFormFields(bool returned = false)
        {
            
            foreach(Control ctl in grpBorrower.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.ResetText();
                }
            }

            if (returned == true)
            {
                if (dgvResource.Columns.Count != 0)
                {
                    dgvResource.ColumnHeadersVisible = false;
                }
            }

            dgvResource.DataSource = null;

            
            

            //lblResourceMsg.ResetText();
        }
    }
}
