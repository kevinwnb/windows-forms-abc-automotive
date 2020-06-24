using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Model
{
    public class Resource
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public ResourceType Type { get; set; }

        public decimal Price { get; set; }

        public string ImagePath { get; set; }

        public ResourceStatus Status { get; set; }

        public ReserveStatus ReserveStatus { get; set; }
        
        public DateTime? DateRemoved { get; set; }

        public string ReservingStudentID { get; set; }
    }
}
