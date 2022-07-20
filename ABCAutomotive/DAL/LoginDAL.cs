using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class LoginDAL
    {
        public Login GetLogin(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["abc_automotive"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetLogin", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Login login = new Login();

                    if (dr.HasRows)
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                login.Username = dr["Username"].ToString();
                            }
                        }
                        finally
                        {
                            // Always call Close when done reading.
                            dr.Close();
                        }

                        return login;
                    }

                    return null;
                }
            }
        }
    }
}
