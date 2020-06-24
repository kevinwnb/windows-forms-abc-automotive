using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentLoanInfoBL
    {
        public List<StudentLoanInfo> GetStudentLoanInformation(string studentID)
        {
            StudentLoanInfoRepository studentLoanInfoRepository = new StudentLoanInfoRepository();

            return studentLoanInfoRepository.RetrieveStudentLoanInfo(studentID);

        }
    }
}
