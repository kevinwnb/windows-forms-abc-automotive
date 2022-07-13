using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class LoanDAL
    {
        public List<Student> GetStudents(string lastName)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["abc_automotive"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetStudentsByLastName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    List<Student> students = new List<Student>();

                    try
                    {
                        while (dr.Read())
                        {
                            Student student = new Student();
                            student.ID = Convert.ToInt32(dr["ID"]);
                            student.FirstName = dr["FirstName"].ToString();
                            student.LastName = dr["LastName"].ToString();
                            student.BalanceDue = Convert.ToDecimal(dr["BalanceDue"]);
                            student.Status = Convert.ToBoolean(dr["Status"]);
                            student.Program = dr["Program"].ToString();
                            student.StartDate = Convert.ToDateTime(dr["StartDate"]);
                            student.EndDate = Convert.ToDateTime(dr["EndDate"]);
                            student.TimeStamp = Convert.ToString(dr["TimeStamp"]);
                            students.Add(student);
                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        dr.Close();
                    }

                    return students;
                }
            }
        }

        public Student GetStudent(int studentId)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["abc_automotive"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_get_student", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = studentId;

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    Student student = new Student();
                    student.FirstName = dr["FirstName"].ToString();
                    student.LastName = dr["LastName"].ToString();
                    student.BalanceDue = Convert.ToDecimal(dr["BalanceDue"]);
                    student.Status = Convert.ToBoolean(dr["Status"]);
                    student.Program = dr["Program"].ToString();
                    student.TimeStamp = dr["TimeStamp"].ToString();

                    return student;
                }
            }
        }
    }
}
