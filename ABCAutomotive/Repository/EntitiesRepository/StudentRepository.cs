using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Types;
using System.Data;
using DAL;

namespace Repository
{
    public class StudentRepository
    {

        //Check Out
        #region Check Out
        #region Public Methods

        public Student RetrieveStudentInformation(string id)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@StudentID", id, 8, SqlDbType.Char));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("RetriveStudentInformation", CommandType.StoredProcedure, parameters);

            return PopulateStudent(dt.Rows[0]);

        }

        public List<Student> RetrieveMatchingStudents(string id = null, string partialLastName = null)
        {
            List<Student> students = new List<Student>();

            List<Parameter> parameters = new List<Parameter>();
            if (id != null)
            {
                parameters.Add(new Parameter("@StudentID", id, 8, SqlDbType.Char));
            }
            else if (partialLastName != null)
            {
                parameters.Add(new Parameter("@PartialLastName", partialLastName, 50, SqlDbType.NVarChar));

            }

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("RetriveMatchingStudents", CommandType.StoredProcedure, parameters);

            foreach (DataRow row in dt.Rows)
            {
                students.Add(PopulateStudent(row, false));
            }

            return students;

        }

        //public bool Insert(Student student)
        //{
        //    List<Parameter> parameters = new List<Parameter>();


        //}

        public bool Delete(int studentId)
        {
            List<Parameter> parameters = new List<Parameter>();

            parameters.Add(new Parameter("@StudentID", studentId, 8, SqlDbType.Int));

            DataAccess db = new DataAccess();

            int retVal = db.ExecuteNonQuery("DeleteStudent", CommandType.StoredProcedure, parameters);

            return retVal > 0;

        }

        public bool Update(Student student)
        {
            //List<Parameter> parameters = new List<Parameter>();

            //parameters.Add(new Parameter("@TimeStamp", student.TimeStamp, 0, SqlDbType.Timestamp, ParameterDirection.InputOutput));
            //parameters.Add(new Parameter("@StudentID", student.ID, 8, SqlDbType.Int));
            //parameters.Add(new Parameter("@FirstName", student.FirstName, 50, SqlDbType.NVarChar));
            //parameters.Add(new Parameter("@LastName", student.LastName, 50, SqlDbType.NVarChar));
            //parameters.Add(new Parameter("@BalanceDue", student.BalanceDue, 0, SqlDbType.Money));
            //parameters.Add(new Parameter("@Status", student.Status, 0, SqlDbType.Bit));
            //parameters.Add(new Parameter("@ProgramID", student.ProgramID, 0, SqlDbType.Int));
            //parameters.Add(new Parameter("@StartDate", student.StartDate, 0, SqlDbType.DateTime));
            //parameters.Add(new Parameter("@EndDate", student.EndDate, 0, SqlDbType.DateTime));

            //DataAccess db = new DataAccess();

            //int retVal = db.ExecuteNonQuery("UpdateStudent", CommandType.StoredProcedure, parameters);

            //if (retVal > 0)
            //{
            //    student.TimeStamp = (byte[])parameters[0].Value;
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }

        public int GetLastID()
        {
            string sql = "SELECT MAX(ID) FROM Student";

            DataAccess db = new DataAccess();

            int retVal = Convert.ToInt32(db.ExecuteScalar(sql, CommandType.Text));

            return retVal;
        }


        #endregion Public Methods

        #region Private Methods
        private Student PopulateStudent(DataRow row, bool allProperties = true)
        {
            //Student student = new Student();

            //student.ID = PopulateProperty("ID", row, "integer");
            //student.FirstName = PopulateProperty("FirstName", row);
            //student.LastName = PopulateProperty("LastName", row);
            //student.TimeStamp = (byte[])row["TimeStamp"];

            //if (allProperties)
            //{
            //    student.ProgramID = PopulateProperty("ProgramID", row, "integer");
            //    student.BalanceDue = PopulateProperty("BalanceDue", row, "decimal");
            //    student.Status = PopulateProperty("Status", row, "status");
            //    student.StartDate = PopulateProperty("StartDate", row, "datetime");
            //    student.EndDate = PopulateProperty("EndDate", row, "datetime");

            //}

            return new Student();
        }

        private dynamic PopulateProperty(string property, DataRow row, string type = null)
        {
            if (type == "decimal")
            {
                return Convert.ToDecimal(row[property]);
            }

            else if (type == "integer")
            {
                return Convert.ToInt32(row[property]);
            }
            else if (type == "datetime")
            {
                return Convert.ToDateTime(row[property]);
            }
            else if(type == "status")
            {
                return (StudentStatus)Convert.ToInt32(row[property]);
            }
            else
            {
                return row[property].ToString();
            }
        }

        public bool InsertStudent(Student student)
        {
            //List<Parameter> parameters = new List<Parameter>();

            //parameters.Add(new Parameter("@FirstName", student.FirstName, 50, SqlDbType.NVarChar));
            //parameters.Add(new Parameter("@LastName", student.LastName, 50, SqlDbType.NVarChar));
            //parameters.Add(new Parameter("@BalanceDue", student.BalanceDue, 0, SqlDbType.Money));
            //parameters.Add(new Parameter("@Status", student.Status, 0, SqlDbType.Bit));
            //parameters.Add(new Parameter("@ProgramID", student.ProgramID, 0, SqlDbType.Int));
            //parameters.Add(new Parameter("@StartDate", student.StartDate, 0, SqlDbType.DateTime));
            //parameters.Add(new Parameter("@EndDate", student.EndDate, 0, SqlDbType.DateTime));

            //DataAccess db = new DataAccess();

            //int retVal = db.ExecuteNonQuery("InsertStudent", CommandType.StoredProcedure, parameters);

            //if (retVal > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }



        #endregion Private Methods 
        #endregion




        //Check In
        #region Check In
        public Student RetrieveStudentByResourceId(int id)
        {
            DataAccess db = new DataAccess();
            List<Parameter> parms = new List<Parameter>(){
                new Parameter("@RessourceID", id, 0, SqlDbType.Int, ParameterDirection.Input)
                };
            //string sql = "SELECT * FROM Student INNER JOIN Loan ON Student.ID = Loan.StudentID WHERE RessourceID = @RessourceID";

            string sql = "SELECT  Student.ID AS StudentID, FirstName, LastName, BalanceDue, Student.Status AS StudentStatus, ProgramID, StartDate, EndDate, TimeStamp, Loan.ID, CheckOutDate,DueDate, CheckInDate, Loan.Status AS LoanStatus, Loan.StudentID, Loan.RessourceID FROM Student INNER JOIN Loan ON Student.ID = Loan.StudentID WHERE RessourceID = @RessourceID AND Loan.Status = 1";
            DataTable dt = db.Execute(sql, CommandType.Text, parms);
            if (dt.Rows.Count > 0)
            {
                return PopulateStudent(dt);
            }

            return new Student();
        }

        public bool UpdateStudentBalanceDue(Student student)
        {
            List<Parameter> parms = new List<Parameter>()
            {
                new Parameter("@StudentID", student.ID, 8, SqlDbType.Int, ParameterDirection.Input),
                new Parameter("@NewBalanceDue", student.BalanceDue, 0, SqlDbType.Money, ParameterDirection.Input)
            };
            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("Update_Student_BalanceDue", CommandType.StoredProcedure, parms) > 0;
        }

        private Student PopulateStudent(DataTable dt)
        {
            //Student student = new Student();
            //student.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            //student.FirstName = dt.Rows[0]["FirstName"].ToString();
            //student.LastName = dt.Rows[0]["LastName"].ToString();
            //student.BalanceDue = Convert.ToDecimal(dt.Rows[0]["BalanceDue"]);
            //student.Status = (StudentStatus)(Convert.ToInt32(dt.Rows[0]["StudentStatus"]));
            //student.ProgramID = (int)dt.Rows[0]["ProgramID"];
            //student.StartDate = (DateTime)dt.Rows[0]["StartDate"];
            //student.EndDate = (DateTime)dt.Rows[0]["EndDate"];
            //return student;
            return new Student();
        }
        #endregion



        //Payment
        #region Payment
        public List<Student> PaymentGetStudents(string searchCriteria, int searchBy)
        {
            List<Student> students = new List<Student>();
            List<Parameter> parms = new List<Parameter>()
            {
                new Parameter("@SearchCriteria", searchCriteria, int.MaxValue, SqlDbType.NVarChar, ParameterDirection.Input),
                new Parameter("@SearchBy", searchBy, 0, SqlDbType.Int, ParameterDirection.Input)
            };
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("PaymentRetrieveStudents", CommandType.StoredProcedure, parms);
            foreach (DataRow row in dt.Rows)
            {
                students.Add(new Student() { ID = Convert.ToInt32(row["ID"]), FirstName = row["FirstName"].ToString(), LastName = row["LastName"].ToString() });
            }
            return students;
        }

        public bool MakePayment(string studentID, decimal payment)
        {
            List<Parameter> parms = new List<Parameter>()
            {
                new Parameter("@StudentID", studentID, 8, SqlDbType.Char, ParameterDirection.Input),
                new Parameter("@Payment", payment, 0, SqlDbType.Money, ParameterDirection.Input)
            };
            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("PaymentMakePayment", CommandType.StoredProcedure, parms) > 0;
        }
        #endregion
    }
}
