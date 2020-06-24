using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Repository
{
    public class StudentLoanInfoRepository
    {
        public List<StudentLoanInfo> RetrieveStudentLoanInfo(string studentID)
        {
            List<StudentLoanInfo> studentLoanInfos = new List<StudentLoanInfo>();

            DataAccess db = new DataAccess();

            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@StudentID", studentID, 8, SqlDbType.Char));

            string sql = "SELECT Ressource.ID AS ResourceID, Ressource.Title, Ressource.[Type], Loan.CheckOutDate, Ressource.ImagePath, Loan.DueDate, Loan.ID AS LoanID, Loan.Status AS LoanStatus " +
                "FROM Ressource INNER JOIN Loan ON Ressource.ID = Loan.RessourceID WHERE Loan.StudentID = @StudentID" ;

            DataTable dt = db.Execute(sql, CommandType.Text, parameters);

            foreach(DataRow row in dt.Rows)
            {
                studentLoanInfos.Add(PopulateStudentLoanInfo(row));
            }

            return studentLoanInfos;
            
        }

        public StudentLoanInfo PopulateStudentLoanInfo(DataRow row)
        {
            StudentLoanInfo studentLoanInfo = new StudentLoanInfo();

            studentLoanInfo.ResourceID = Convert.ToInt32(row["ResourceID"]);
            studentLoanInfo.Title = row["Title"].ToString();
            studentLoanInfo.ResourceType = (ResourceType)row["Type"];
            studentLoanInfo.CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]);
            studentLoanInfo.DueDate = Convert.ToDateTime(row["DueDate"]);
            studentLoanInfo.ImagePath = row["ImagePath"].ToString();
            studentLoanInfo.LoanID = Convert.ToInt32(row["LoanID"]);
            studentLoanInfo.LoanStatus = (LoanStatus)row["LoanStatus"];

            return studentLoanInfo;

        }
    }
}
