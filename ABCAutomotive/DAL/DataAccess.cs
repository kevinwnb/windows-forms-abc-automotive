using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
namespace DAL
{
    public class DataAccess
    {
        private SqlCommand CreateCommand(string cmdText, CommandType cmdType, List<Parameter> parameters)
        {
            SqlConnection conn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["abc_automotive"].ConnectionString);

            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;

            if (parameters != null)
            {
                foreach (Parameter p in parameters)
                {
                    cmd.Parameters.Add(p.Name, p.DataType, p.Size).Value = p.Value;
                }
            }

            return cmd;
        }

        private static void UnloadParms(List<Parameter> parms, SqlCommand cmd)
        {
            if (parms != null)
            {
                for (int i = 0; i < parms.Count; i++)
                {
                    Parameter p = parms[i];
                    p.Value = cmd.Parameters[i].Value;
                    parms[i] = p;
                }
            }
        }

        public DataTable Execute(string cmdText, CommandType cmdType, List<Parameter> parameters = null)
        {
            SqlCommand cmd = CreateCommand(cmdText, cmdType, parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        public int ExecuteNonQuery(string cmdText, CommandType cmdType, List<Parameter> parameters = null)
        {
            SqlCommand cmd = CreateCommand(cmdText, cmdType, parameters);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
                UnloadParms(parameters, cmd);
            }
        }

        public object ExecuteScalar(string cmdText, CommandType cmdType, List<Parameter> parameters = null)
        {
            SqlCommand cmd = CreateCommand(cmdText, cmdType, parameters);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
