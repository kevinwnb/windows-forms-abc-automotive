using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Types;
using Model.Entities;
using System.Data;

namespace Repository.EntitiesRepository
{
    public class StudentPaymentRepository
    {
        //Payment
        public List<StudentPayment> GetStudentInfo(string studentID)
        {
            List<StudentPayment> students = new List<StudentPayment>();
            List<Parameter> parms = new List<Parameter>()
            {
                new Parameter("@StudentID", studentID, 8, SqlDbType.Char, ParameterDirection.Input)
            };
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("PaymentRetrieveStudentInfo", CommandType.StoredProcedure, parms);
            foreach (DataRow row in dt.Rows)
            {
                students.Add(PopulateStudentByRow(row));
            }
            return students;
        }

        private StudentPayment PopulateStudentByRow(DataRow r)
        {
            StudentPayment student = new StudentPayment();
            student.FirstName = r["FirstName"].ToString();
            student.LastName = r["LastName"].ToString();
            student.BalanceDue = (decimal)r["BalanceDue"];
            student.Program = r["Program"].ToString();
            student.StartDate = (DateTime)r["StartDate"];
            student.EndDate = (DateTime)r["EndDate"];
            student.Status = (StudentStatus)Convert.ToInt32(r["Status"]);
            return student;
        }
    }
}
