using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model.Entities;
using System.Data;
using Types;

namespace Repository.EntitiesRepository
{
    public class PaymentRepository
    {
        public bool AddPayment(int studentID, decimal payment, string type)
        {
            List<Parameter> parms = new List<Parameter>()
            {
                new Parameter("@StudentID", studentID, 8, SqlDbType.Int, ParameterDirection.Input),
                new Parameter("@Payment", payment, 0, SqlDbType.Money, ParameterDirection.Input),
                new Parameter("@Date", DateTime.Now, 0, SqlDbType.DateTime, ParameterDirection.Input),
                new Parameter("@Type", type, 30, SqlDbType.NVarChar, ParameterDirection.Input)
            };
            DataAccess db = new DataAccess();
            return db.ExecuteNonQuery("PaymentAddPayment", CommandType.StoredProcedure, parms) > 0;
        }
    }
}
