using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model
{
    public class Student
    {
        //IsValidId()
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal BalanceDue { get; set; }

        public StudentStatus Status { get; set; }

        public int ProgramID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public byte[] TimeStamp { get; set; }

    }
}
