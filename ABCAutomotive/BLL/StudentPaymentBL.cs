using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using Repository.EntitiesRepository;
using Types;

namespace BLL
{
    public class StudentPaymentBL
    {
        //Payment
        public List<StudentPayment> GetStudentInfo(string studentID)
        {
            StudentPaymentRepository repo = new StudentPaymentRepository();
            return repo.GetStudentInfo(studentID);
        }
    }
}
