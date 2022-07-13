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

        public bool Status { get; set; }

        public string Program { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string TimeStamp { get; set; }

    }
}
