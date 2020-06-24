using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Repository
{
    public class BorrowingRepository
    {
        public List<Borrowing> RetrieveBorrowings(int resourceID)
        {
            DataAccess db = new DataAccess();
            List<Parameter> parms = new List<Parameter>(){
                new Parameter("@ResourceID", resourceID, 0, SqlDbType.Int, ParameterDirection.Input)
                };
            DataTable dt = db.Execute("CheckIn_Get_Borrowings", CommandType.StoredProcedure, parms);

            List<Borrowing> borrowings = new List<Borrowing>();

            foreach (DataRow row in dt.Rows)
            {
                borrowings.Add(PopulateBorrowing(row));
            }

            return borrowings;
        }

        private Borrowing PopulateBorrowing(DataRow row)
        {
            Borrowing borrowing = new Borrowing();

            borrowing.ResourceID = Convert.ToInt32(row["ResourceID"]);
            borrowing.LoanID = Convert.ToInt32(row["LoanID"]);
            borrowing.Title = row["Title"].ToString();
            borrowing.ResourceStatus = (ResourceStatus)row["ResourceStatus"];
            borrowing.ResourceType = (ResourceType)row["ResourceType"];
            borrowing.CheckOutDate = Convert.ToDateTime(row["CheckOutDate"].ToString());
            borrowing.DueDate = Convert.ToDateTime(row["DueDate"].ToString());

            return borrowing;
        }
    }
}
