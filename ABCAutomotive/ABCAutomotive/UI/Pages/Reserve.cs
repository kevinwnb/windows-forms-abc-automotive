using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using Types;
using System.Text.RegularExpressions;

namespace ABCAutomotive.UI.Pages
{
    public partial class Reserve : PageControl
    {
        public static Reserve _instance;

        public static Reserve Instance
        {
            get
            {
                if (_instance == null || _instance.HasBeenClosed)
                {
                    _instance = new Reserve();
                    _instance.Position = 0;
                }

                return _instance;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _instance.Close();
        }

        public Reserve()
        {
            InitializeComponent();
        }

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = ValidateForm(sender);
                if (errorMessage == string.Empty)
                {
                    ResourceBL resourceBL = new ResourceBL();
                    int resourceID = Convert.ToInt32(txtResourceID.Text);
                    Resource resource = resourceBL.GetResourceToUpDate(resourceID);

                    List<string> resourceInfo = new List<string>()
                {
                    $"Resource Title: \t {resource.Title}",
                    $"Resource Type: \t {resource.Type}\n",
                    $"Resource Status: \t {resource.Status} \n",
                    $"Reserve Status: \t {resource.ReserveStatus}"
                };

                    lstResourceInfo.DataSource = resourceInfo;

                    lstResourceInfo.SelectedIndex = -1;
                }
                else
                {
                    lstResourceInfo.DataSource = null;
                    MessageBox.Show(errorMessage);
                }

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
                string parameter = txtSearchStudent.Text;

                StudentBL studentBL = new StudentBL();

                List<Student> matchingStudents = new List<Student>();

                string errorMessage = ValidateForm(sender);

                if (errorMessage == string.Empty)
                {
                    if (rdoID.Checked)
                    {
                        matchingStudents = studentBL.GetMatchingStudents(id: parameter);
                    }

                    if (rdoPartialLastName.Checked)
                    {
                        matchingStudents = studentBL.GetMatchingStudents(parttialLastName: parameter);
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
                label11.Text = string.Empty;
                int selectedRow = e.RowIndex;
                if (selectedRow != -1)
                {
                    string studentID = dgvStudents.Rows[selectedRow].Cells["ID"].Value.ToString();



                    StudentBL studentBL = new StudentBL();

                    Student retrievedStudent = studentBL.GetStudent(id: studentID);

                    if (studentBL.Errors.Count == 0)
                    {

                        PopulateStudentFields(retrievedStudent);

                    }
                    else
                    {
                        PopulateStudentFields(retrievedStudent);

                        foreach (ValidationError error in studentBL.Errors)
                        {
                            label11.Text += error.Description + "\n";
                            label11.ForeColor = Color.Red;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select  a valid row.", "Invalid Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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

            if (sender == btnSearchRessource)
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


            return errorMessage;

        }

        private void PopulateStudentFields(Student student)
        {
            txtStudentID.Text = student.ID.ToString();
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtProgramID.Text = student.ProgramID.ToString();
            txtStartDate.Text = student.StartDate.ToString();
            txtEndDate.Text = student.EndDate.ToString();
            txtBalanceDue.Text = student.BalanceDue.ToString();
            chkIsActive.Checked = Convert.ToBoolean(student.Status);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceBL resourceBL = new ResourceBL();
                int resourceID = Convert.ToInt32(txtResourceID.Text);
                Resource resource = resourceBL.GetResourceToUpDate(resourceID);

                if (resourceBL.ModifyReserveStatus(resourceID, txtStudentID.Text))
                {
                    MessageBox.Show($"Resource succesfuly reserved by {txtFirstName.Text} {txtLastName.Text} !");

                    txtResourceID.ResetText();
                    lstResourceInfo.DataSource = null;

                    rdoID.Checked = true;

                    txtSearchStudent.ResetText();
                    dgvStudents.DataSource = null;

                    foreach (Control ctl in this.panel2.Controls)
                    {
                        if (ctl is TextBox)
                        {
                            ctl.Text = string.Empty;
                        }
                    }

                    chkIsActive.Checked = false;
                }
                else
                {
                    string msg = string.Empty;

                    foreach (ValidationError error in resourceBL.Errors)
                    {
                        msg += error.Description + "\n";
                    }

                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

    }
}
