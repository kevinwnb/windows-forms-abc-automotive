using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBL
    {
        public Login GetLogin(string userName, string password)
        {
            Login login = new Login();

            LoginRepository loginRepository = new LoginRepository();

            DataTable dt = loginRepository.RetrieveLogins(userName, password);

            if(dt.Rows.Count !=0)
            {
                login = PopulateLogin(dt.Rows[0]);
            }

            return login;
        }

        private Login PopulateLogin(DataRow row)
        {
            Login login = new Login();

            login.ID = Convert.ToInt32(row["ID"]);
            login.LoginUserName = row["LoginUserName"].ToString();
            login.Password = row["Password"].ToString();
            login.DepartementHead = Convert.ToInt32(row["DepartementHead"]);

            return login;
        }

    }
}
