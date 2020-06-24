using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LoginRepository
    {
        public DataTable RetrieveLogins(string userName , string password)
        {
            DataAccess db = new DataAccess();

            string sql = $" SELECT * FROM Login WHERE LoginUserName = '{userName}' AND Password = '{password}'";

            DataTable dt = db.Execute(sql, CommandType.Text);

            return dt;
        }
    }
}
