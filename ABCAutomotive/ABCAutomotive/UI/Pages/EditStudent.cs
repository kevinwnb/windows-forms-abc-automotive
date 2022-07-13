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
using System.Text.RegularExpressions;

namespace ABCAutomotive.UI.Pages
{
    public partial class EditStudent : PageControl
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        Student student;

        string _studentID = string.Empty;

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton rdoSender = (RadioButton)sender;
                switch (rdoSender.Name)
                {
                    case "rdoAddStudent":
                        EnableGroupBoxes(true);
                        break;

                    default:
                        EnableGroupBoxes(false);
                        break;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EnableFields(bool state)
        {
            foreach (Control ctl in grpStudentInformation.Controls)
            {
                if (ctl is TextBox && ctl != txtSearch)
                {
                    ctl.Enabled = state;
                }
            }
        }

        private void EnableGroupBoxes(bool state)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is GroupBox)
                {
                    if (ctl != grpStudentInformation)
                    {
                        ctl.Enabled = !state;

                    }

                    grpStudentInformation.Enabled = state;
                }
            }
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            grpStudentInformation.Enabled = false;
            grpSearch.Enabled = false;
            grpMatchingStudents.Enabled = false;
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                StudentBL studentBL = new StudentBL();

                student = studentBL.GetStudent(txtSearch.Text);

                PopulateStudentFields(student);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopulateStudentFields(Student student)
        {
            //txtFirstName.Text = student.FirstName;
            //txtLastName.Text = student.LastName;
            //txtProgramID.Text = student.ProgramID.ToString();
            //dtpStartDate.Value = student.StartDate;
            //dtpEndDate.Value = student.EndDate;
            //txtBalanceDue.Text = student.BalanceDue.ToString();
            //chkIsActive.Checked = Convert.ToBoolean(student.Status);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdoAddStudent.Checked == false && rdoDeleteStudent.Checked ==false && rdoEditStudent.Checked == false)
                {
                    MessageBox.Show("Please select an specific action", "Missing Information");
                    return;
                }
                StudentBL studentBL = new StudentBL();
                if (rdoAddStudent.Checked)
                {
                    Student student = new Student();
                    PopulateSudentObject(student);
                    if (studentBL.Add(student))
                    {
                        int studentId = studentBL.GetLastID();
                        MessageBox.Show($"New Student Created:" +
                            $" \n Student ID: {studentBL.GetLastID()}");                      
                    }
                }
                else
                {
                    PopulateSudentObject();

                    if (rdoEditStudent.Checked)
                    {

                        if (studentBL.Edit(student))
                        {
                            MessageBox.Show("Updated SuccessFully");
                        }

                    }

                    if (rdoDeleteStudent.Checked)
                    {

                        if (studentBL.Remove(student.ID))
                        {
                            MessageBox.Show("Deleted SuccessFully");
                        }
                    }
                }

                ResetFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string parameter = txtSearch.Text;

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

        private string ValidateForm(object sender)
        {
            string errorMessage = string.Empty;


            if (sender == btnSearchStudent)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
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

                    if (!reg.IsMatch(txtSearch.Text))
                    {
                        errorMessage = "Please enter a valid 8 digits number for the student Id.";
                    }
                }

            }
            return errorMessage;

        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                string studentID = dgvStudents.Rows[selectedRow].Cells["ID"].Value.ToString();

                _studentID = studentID;



                StudentBL studentBL = new StudentBL();

                student = studentBL.GetStudent(id: studentID);

                grpStudentInformation.Enabled = true;

                PopulateStudentFields(student);

            }
            else
            {
                MessageBox.Show("Please select  a valid row.", "Invalid Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateSudentObject()
        {

            
            //student.ID = Convert.ToInt32(_studentID);
            //student.FirstName = txtFirstName.Text;
            //student.LastName = txtLastName.Text;
            //student.BalanceDue = Convert.ToDecimal(txtBalanceDue.Text);
            //student.Status = (StudentStatus)Convert.ToInt32(chkIsActive.Checked);
            //student.ProgramID = Convert.ToInt32(txtProgramID.Text);
            //student.StartDate = dtpEndDate.Value;
            //student.EndDate = dtpEndDate.Value;


        }

        private void PopulateSudentObject(Student student)
        {


            //student.FirstName = txtFirstName.Text;
            //student.LastName = txtLastName.Text;
            //student.BalanceDue = Convert.ToDecimal(txtBalanceDue.Text);
            //student.Status = (StudentStatus)Convert.ToInt32(chkIsActive.Checked);
            //student.ProgramID = Convert.ToInt32(txtProgramID.Text);
            //student.StartDate = dtpEndDate.Value;
            //student.EndDate = dtpEndDate.Value;


        }

        private void ResetFields()
        {
            foreach(Control ctl in grpStudentInformation.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.ResetText();
                }
            }

            txtSearch.ResetText();

            rdoAddStudent.Checked = false;
            rdoDeleteStudent.Checked = false;
            rdoEditStudent.Checked = false;

            dgvStudents.DataSource = null;

            grpStudentInformation.Enabled = false;
            grpSearch.Enabled = false;
            grpMatchingStudents.Enabled = false;

            chkIsActive.Checked = false;
           

        }

    }
}
