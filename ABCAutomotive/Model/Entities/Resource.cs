using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model
{
    public class Resource
    {
        [DisplayName("Resource ID")]
        public int ResourceID { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string ImagePath { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; }

        public string ReserveStatus { get; set; }
        
        public DateTime? DateRemoved { get; set; }

        public string ReservingStudentID { get; set; }
    }
}
