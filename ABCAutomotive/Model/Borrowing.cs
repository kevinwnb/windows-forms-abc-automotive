using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model
{
    public class Borrowing
    {
        public int ResourceID { get; set; }

        public int LoanID { get; set; }

        public string Title { get; set; }

        public ResourceType ResourceType { get; set; }

        public ResourceStatus ResourceStatus { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime DueDate { get; set; }

    }
}
