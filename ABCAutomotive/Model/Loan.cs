using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model
{
    public class Loan : Resource
    {
        [DisplayName("Loan ID")]
        public int ID { get; set; }
        [DisplayName("Student ID")]
        public string StudentID { get; set; }
        [DisplayName("Check Out Date")]
        public DateTime CheckOutDate { get; set; }
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        [DisplayName("Check In Date")]
        public DateTime? CheckInDate { get; set; }
    }
}
