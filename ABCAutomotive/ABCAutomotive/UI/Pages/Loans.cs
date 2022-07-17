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

                string errorMessage = ValidateForm(sender);

                if (errorMessage == string.Empty)
                {
                    if (rdoID.Checked)
                    {
                        matchingStudents.Add(loanBL.GetStudent(Convert.ToInt32(parameter)));
                    }

                    if (rdoPartialLastName.Checked)
                    {
                        matchingStudents = loanBL.GetStudents(parameter);
                    }

                    if (matchingStudents.Count == 0)
                    {
                        errorMessage = "No matching student";
                        MessageBox.Show(errorMessage);
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
                else
                {
                    MessageBox.Show(errorMessage);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvRessourceToBorrow.DataSource != null)
            //{
            //    ResourceBL ressourceBL = new ResourceBL();
            //    LoanBL loanBL = new LoanBL();
            //    StudentLoanInfoBL loanInfoBL = new StudentLoanInfoBL();

            //    int ressourceID = Convert.ToInt32(txtRessourceID.Text);
            //    Resource ressource = ressourceBL.GetRessourceDetails(ressourceID);

            //    Loan loan = PopulateLoanObject(ressource, txtStudentID.Text);

            //    //loanBL._loans = (List<Loan>)dgvLoans.DataSource;

            //    List<StudentLoanInfo> studentLoanInfos = (List<StudentLoanInfo>)dgvLoans.DataSource;

            //    foreach (StudentLoanInfo stli in studentLoanInfos)
            //    {
            //        Loan studentLoan = loanBL.GetLoanByID(stli.LoanID);

            //        loanBL._loans.Add(studentLoan);
            //    }



            //    if (loanBL.AddLoan(loan))
            //    {
            //        string msg = string.Empty;
            //        if (ressourceBL.ModifyRessource(ressource, txtStudentID.Text))
            //        {
            //            msg = "\nRessource status set to \"On Loan\"";
            //        }

            //        PopulateDgvRessource(ressource.ID);
            //        PopulateStudentLoans(txtStudentID.Text, loanInfoBL);

            //        txtRessourceID.ResetText();
            //        dgvRessourceToBorrow.DataSource = null;

            //        MessageBox.Show("Resource succesfuly added to the student Loans." + msg);
            //    }
            //    else
            //    {
            //        string msg = string.Empty;

            //        foreach (ValidationError error in loanBL.Errors)
            //        {
            //            msg += error.Description + "\n";
            //        }





            //        if (msg != string.Empty)
            //        {
            //            dgvRessourceToBorrow.DataSource = null;
            //            txtRessourceID.ResetText();
            //            txtRessourceID.Focus();

            //            MessageBox.Show(msg);
            //        }

            //    }

            //}


            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.GetType().ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
            }
            catch (Exception)
            {
                throw;
            }

            //string errorMessage = ValidateForm(sender);

            //if (errorMessage == string.Empty)
            //{
            //    PopulateDgvRessource(Convert.ToInt32(txtRessourceID.Text));

            //    int ressourceID = Convert.ToInt32(dgvRessourceToBorrow.Rows[0].Cells["ID"].Value.ToString()); ;
            //    FillPictureBox(ressourceID, picBorrowRessource);
            //}
            //else
            //{
            //    MessageBox.Show(errorMessage);
            //}

        }

        private void PopulateStudentLoans(string retrievedStudentID, StudentLoanInfoBL studentLoanInfoBL)
        {
            //List<Loan> loans = loanBL.GetStudentLoans(retrievedStudentID);

            List<StudentLoanInfo> loans = studentLoanInfoBL.GetStudentLoanInformation(retrievedStudentID);

            dgvLoans.DataSource = loans;
            dgvLoans.Columns["ImagePath"].Visible = false;
            dgvLoans.Columns["LoanID"].Visible = false;

            //dgvLoans.Columns["ID"].Visible = false;
            //dgvLoans.Columns["StudentID"].Visible = false;
            //dgvLoans.Columns["CheckInDate"].Visible = false;



            grpResourceToBorrow.Enabled = true;
            label11.ResetText();
        }

        private void PopulateStudentFields(Student student)
        {
            //txtStudentID.Text = student.ID.ToString();
            //txtFirstName.Text = student.FirstName;
            //txtLastName.Text = student.LastName;
            //txtProgramID.Text = student.ProgramID.ToString();
            //txtStartDate.Text = student.StartDate.ToString();
            //txtEndDate.Text = student.EndDate.ToString();
            //txtBalanceDue.Text = student.BalanceDue.ToString();
            //chkIsActive.Checked = Convert.ToBoolean(student.Status);
        }

        private void PopulateDgvRessource(int parameter)
        {
            ResourceBL ressourceBL = new ResourceBL();

            //ressourceBL.GetRessourceDetails(id: parameter);

            List<Resource> ressources = new List<Resource>() { ressourceBL.GetRessourceDetails(id: parameter) };

            dgvResourceToBorrow.DataSource = ressources;
            dgvResourceToBorrow.Columns["DateRemoved"].Visible = false;
            dgvResourceToBorrow.Columns["Price"].Visible = false;
            dgvResourceToBorrow.Columns["ImagePath"].Visible = false;
        }

        private void FillPictureBox(int resourrceID, PictureBox pic)
        {
            ResourceBL resourceBL = new ResourceBL();

            Resource resource = resourceBL.GetRessourceDetails(resourrceID);

            if (!string.IsNullOrEmpty(resource.ImagePath))
            {
                pic.ImageLocation = resource.ImagePath;
            }
        }

        private Loan PopulateLoanObject(Resource resource, string studentID)
        {
            Loan loan = new Loan();

            loan.CheckOutDate = DateTime.Now;

            if (loan.CheckOutDate.DayOfWeek == DayOfWeek.Friday)
            {
                loan.DueDate = loan.CheckOutDate.AddDays(4);
            }
            else
            {
                loan.DueDate = loan.CheckOutDate.AddDays(2);
            }

            loan.ResourceID = resource.ResourceID;

            loan.StudentID = studentID;

            loan.Status = "On Loan";

            return loan;
        }

        private string ValidateForm(object sender)
        {
            string errorMessage = string.Empty;


            if (sender == btnSearchStudent)
            {
                if (string.IsNullOrEmpty(txtSearchStudent.Text))
                {
                    if (rdoID.Checked)
                    {
                        errorMessage = "You must enter a Student ID.";
                    }
                    if (rdoPartialLastName.Checked)
                    {
                        errorMessage = "You lust enter a Partial Last Name.";
                    }
                }
                else if (rdoID.Checked)
                {
                    string path = "[0-9]{8}";
                    Regex reg = new Regex(path);

                    if (!reg.IsMatch(txtSearchStudent.Text))
                    {
                        errorMessage = "Please enter a valid 8 digits number for the student Id.";
                    }
                }

            }

            if (sender == btnSearchResource)
            {
                if (txtResourceID.Text == string.Empty)
                {
                    errorMessage = "You must enter a ressource ID.";
                }
                else if (!int.TryParse(txtResourceID.Text, out int ressourceID))
                {
                    errorMessage = "Please enter a valid Ressource Id number.";
                }
            }
            if (sender == btnConfirm && dgvResourceToBorrow.Rows.Count == 0)
            {

                errorMessage = "You must retrieve a ressource first.";

            }

            return errorMessage;

        }

        private void ResetForm()
        {
            rdoID.Checked = true;

            txtSearchStudent.ResetText();

            dgvStudents.DataSource = null;

            foreach (Control ctl in grpStudentInformations.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }

            dgvLoans.DataSource = null;

            txtResourceID.ResetText();

            dgvResourceToBorrow.DataSource = null;

            grpStudentInformations.Enabled = false;
            grpResourceToBorrow.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure? Your data may not be saved.", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetForm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = e.RowIndex;
                int ressourceID = Convert.ToInt32(dgvLoans.Rows[selectedRow].Cells["RessourceID"].Value.ToString()); ;
                FillPictureBox(ressourceID, picLoanRessource);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
