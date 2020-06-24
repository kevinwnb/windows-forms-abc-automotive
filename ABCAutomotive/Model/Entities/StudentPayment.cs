using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model.Entities
{
    public class StudentPayment
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BalanceDue { get; set; }
        public string Program { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StudentStatus Status { get; set; }
    }
}
