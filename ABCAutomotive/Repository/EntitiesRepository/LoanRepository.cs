using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using DAL;
using Types;
using System.Windows.Forms;

namespace Repository
{
    public class LoanRepository
    {
        //Check Out
        #region CheckOut
        public List<Loan> RetriveStudentLoans(string studentId)
        {
            List<Loan> loans = new List<Loan>();
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@StudentID", studentId, 8, SqlDbType.Char));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("RetriveStudentLoans", CommandType.StoredProcedure, parameters);

            foreach (DataRow row in dt.Rows)
            {
                loans.Add(PopulateLoan(row));
            }

            return loans;
        }

        public List<Loan> RetriveAllLoans()
        {
            List<Loan> loans = new List<Loan>();

            List<Parameter> parameters = new List<Parameter>();

            DataAccess db = new DataAccess();

            string sql = "SELECT * FROM Loan";

            DataTable dt = db.Execute(sql, CommandType.Text);

            foreach (DataRow row in dt.Rows)
            {
                loans.Add(PopulateLoan(row));
            }

            return loans;
        }



        public bool Insert(Loan loan)
        {

            List<Parameter> parameters = new List<Parameter>();

            parameters.Add(new Parameter("@CheckOutDate", loan.CheckOutDate, 0, SqlDbType.DateTime));
            parameters.Add(new Parameter("@DueDate", loan.DueDate, 0, SqlDbType.Date));
            parameters.Add(new Parameter("@CheckInDate", loan.CheckInDate, 0, SqlDbType.DateTime));
            parameters.Add(new Parameter("@Status", loan.Status, 50, SqlDbType.Int));
            parameters.Add(new Parameter("@StudentID", loan.StudentID, 8, SqlDbType.Char));
            parameters.Add(new Parameter("@RessourceID", loan.RessourceID, 0, SqlDbType.Int));

            DataAccess db = new DataAccess();
            int retVal = db.ExecuteNonQuery("Insert_Loan", CommandType.StoredProcedure, parameters);

            if (retVal == 0)
            {
                return false;
            }

            return true;
        }

        public string RessourceType(int ressourceId)
        {
            List<Parameter> parameters = new List<Parameter>();

            parameters.Add(new Parameter("@RessourceID", ressourceId, 0, SqlDbType.Int));

            string sql = "SELECT Type FROM Ressource WHERE Ressource.ID = @RessourceID";

            DataAccess db = new DataAccess();

            return db.ExecuteScalar(sql, CommandType.Text, parameters).ToString();
        }

        public int NumberOfLoansByStudent(string studentId)
        {
            List<Parameter> parameters = new List<Parameter>();

            parameters.Add(new Parameter("@StudentID", studentId, 8, SqlDbType.Char));

            string sql = "SELECT COUNT(*) FROM Loan WHERE StudentId = @StudentID";

            DataAccess db = new DataAccess();

            return Convert.ToInt32(db.ExecuteScalar(sql, CommandType.Text, parameters));
        }


        private Loan PopulateLoan(DataRow row)
        {
            Loan loan = new Loan();

            loan.ID = PopulateProperty("ID", row, "integer");
            loan.RessourceID = PopulateProperty("RessourceID", row, "integer");
            loan.CheckOutDate = PopulateProperty("CheckOutDate", row, "datetime");
            loan.DueDate = PopulateProperty("DueDate", row, "datetime");
            loan.CheckInDate = PopulateProperty("CheckInDate", row, "datetime");
            loan.Status = PopulateProperty("Status", row, "LoanStatus");
            loan.StudentID = PopulateProperty("StudentID", row);

            return loan;
        }

        private dynamic PopulateProperty(string property, DataRow row, string type = null)
        {
            if (row[property] == DBNull.Value)
            {
                return null;
            }
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
            else if (type == "LoanStatus")
            {
                return (LoanStatus)row[property];
            }
            else
            {
                return row[property].ToString();
            }
        }
        #endregion CheckOut




        //Check In
        #region Check In
        //public DataTable GetCurrentLoansByStudentId(string studentID)
        //{
        //    List<Loan> loans = new List<Loan>();
        //    List<Parameter> parms = new List<Parameter>()
        //    {
        //        new Parameter("@StudentID", studentID, 8, SqlDbType.Char, ParameterDirection.Input)
        //    };
        //    string sql = "SELECT ID, CheckOutDate, DueDate, CheckInDate, [Status], StudentID, RessourceID FROM Loan WHERE StudentID = @StudentID";
        //    DataAccess db = new DataAccess();
        //    DataTable dt = db.Execute(sql, CommandType.Text, parms);
        //    return dt;
        //    //foreach (DataRow row in dt.Rows)
        //    //{
        //    //    loans.Add(PopulateLoanObject(row));
        //    //}
        //    //return loans;
        //}

        public Loan RetrieveLoanByID(int loanID)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@LoanID", loanID, 0, SqlDbType.Int));
            string sql = "SELECT * FROM Loan WHERE ID = @LoanID";

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute(sql, CommandType.Text, parameters);

            return PopulateLoan(dt.Rows[0]);
        }

        public bool UpdateLoanStatusForEach(List<Loan> loans)
        {
            int length = 0;
            DataAccess db = new DataAccess();
            foreach (Loan loan in loans)
            {
                List<Parameter> parms = new List<Parameter>()
                {
                    new Parameter("@ResourceID", loan.RessourceID, 0, SqlDbType.Int, ParameterDirection.Input),
                    new Parameter("@Status", loan.Status, 50, SqlDbType.Int, ParameterDirection.Input),
                    new Parameter("@CheckInDate", loan.CheckInDate, 0, SqlDbType.DateTime, ParameterDirection.Input)
                };
                if (db.ExecuteNonQuery("Update_Loan_Status", CommandType.StoredProcedure, parms) > 0)
                {
                    length++;
                }
            }
            if (length == loans.Count)
            {
                return true;
            }

            return false;
        }
        //private enum LoanStatus
        //{
        //    OnLoan = 1,
        //    Returned,
        //    ReturnedDamaged,
        //    NotReturned
        //}

        //private Loan PopulateLoanObject(DataRow row)
        //{
        //    Loan loan = new Loan();
        //    loan.ID = Convert.ToInt32(row["ID"]);
        //    loan.StudentID = Convert.ToInt32(row["StudentID"]);
        //    loan.RessourceID = Convert.ToInt32(row["RessourceID"]);
        //    loan.CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]);
        //    loan.DueDate = Convert.ToDateTime(row["DueDate"]);
        //    loan.Status = Convert.ToInt32(row["Status"]);
        //    loan.StartDate = Convert.ToDateTime(row["StartDate"]);
        //    return loan;
        //} 
        #endregion
    }
}
