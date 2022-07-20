using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Types;
using DAL;

namespace BLL
{
    public class LoanBL
    {
        LoanDAL loanDAL = new LoanDAL();

        public List<Student> GetStudents(string lastName)
        {
            return loanDAL.GetStudents(lastName);
        }

        public Student GetStudent(int studentId)
        {
            return loanDAL.GetStudent(studentId);
        }

        public List<Loan> GetStudentLoans(int studentId)
        {
            return loanDAL.GetStudentLoans(studentId);
        }

        public Resource GetResourceById(int id)
        {
            return loanDAL.GetResourceById(id);
        }

        public bool CreateLoans(List<Loan> loans)
        {

        }
    }
}
