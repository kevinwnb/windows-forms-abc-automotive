using DAL;
using Model;
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
            LoginDAL logindal = new LoginDAL();
            return logindal.GetLogin(userName, password);
        }
    }
}
