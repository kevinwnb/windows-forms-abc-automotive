using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model
{
    public class Loan
    {
        public int ID { get; set; }

        public string StudentID { get; set; }

        public int RessourceID { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime DueDate { get; set; }

        public LoanStatus Status { get; set; }

        public DateTime? CheckInDate { get; set; }
    }
}
