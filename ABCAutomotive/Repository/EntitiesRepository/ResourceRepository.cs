using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using DAL;
using Types;

namespace Repository
{
    public class ResourceRepository
    {
        //Check Out
        #region Check Out
        Resource _ressource;

        public Resource RetrieveRessourceDetails(int ressourceId)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@RessourceID", ressourceId, 0, SqlDbType.Int));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("RetriveRessourceDetails", CommandType.StoredProcedure, parameters);

            dt.Columns["ReservingStudentID"].AllowDBNull = true;


            return (PopulateRessource(dt.Rows[0]));
        }

        public bool Update(Resource ressource, string studentID)
        {
            _ressource = ressource;

            List<Parameter> parms = new List<Parameter>();
            parms.Add(new Parameter("@RessourceID", _ressource.ID, 0, SqlDbType.Int));

            DataAccess db = new DataAccess();
            int retVal = 0;

            if (IsAvailable())
            {
                if(_ressource.ReserveStatus == ReserveStatus.Reserved)         
                {
                    if (RetrieveReservingStudentID(_ressource.ID) == studentID)
                    {
                        List<Parameter> parameters = new List<Parameter>();
                        parameters.Add(new Parameter("@RessourceID", _ressource.ID, 0, SqlDbType.Int));
                        string sql = "UPDATE Ressource SET ReserveStatus = 0, ReservingStudentID = NULL WHERE ID = @RessourceID";

                        retVal = db.ExecuteNonQuery(sql, CommandType.Text, parameters);
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                retVal = db.ExecuteNonQuery("UpdateRessource_Status", CommandType.StoredProcedure, parms);
            }

            //if (IsOnLoan())
            //{
            //    parms.Add(new Parameter("@StudentID", studentID, 8, SqlDbType.Char));

            //    retVal = db.ExecuteNonQuery("UpdateRessource_ReserveStatus", CommandType.StoredProcedure, parms);
            //}

            if (retVal > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateReserveStatus(int resourceID, string studentID)
        {
            List<Parameter> parms = new List<Parameter>();
            parms.Add(new Parameter("@RessourceID", resourceID, 0, SqlDbType.Int));
            parms.Add(new Parameter("@StudentID", studentID, 8, SqlDbType.Char));

            DataAccess db = new DataAccess();
            int retVal = db.ExecuteNonQuery("UpdateRessource_ReserveStatus", CommandType.StoredProcedure, parms);

            return retVal > 0;
        }


        public string RetrieveReservingStudentID(int ressourceID)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@RessourceID", ressourceID, 0, SqlDbType.Int));

            string sql = "SELECT  ReservingStudentID FROM Ressource " +
                        "WHERE ID = @RessourceID";

            DataAccess db = new DataAccess();

            return db.ExecuteScalar(sql, CommandType.Text, parameters).ToString();
        }

        private bool IsAvailable()
        {
            return _ressource.Status == ResourceStatus.Available;
        }

        private bool IsOnLoan()
        {
            return _ressource.Status == ResourceStatus.OnLoan;
        }

        private Resource PopulateRessource(DataRow row)
        {
            Resource ressource = new Resource();

            ressource.ID = PopulateProperty("ID", row, "integer");
            ressource.Type = PopulateProperty("Type", row, "ResourceType");
            ressource.Price = PopulateProperty("Price", row, "decimal");
            ressource.Title = PopulateProperty("Title", row);
            ressource.Status = PopulateProperty("Status", row, "ResourceStatus");
            ressource.ReserveStatus = PopulateProperty("ReserveStatus", row, "ReserveStatus");
            ressource.ImagePath = PopulateProperty("ImagePath", row);
            ressource.ReservingStudentID = PopulateProperty("ReservingStudentID", row);


            return ressource;
        }

        private dynamic PopulateProperty(string property, DataRow row, string type = null)
        {
            if (type == "decimal")
            {
                return Convert.ToDecimal(row[property]);
            }

            else if (type == "integer")
            {
                if (row[property] != DBNull.Value)
                {
                    return Convert.ToInt32(row[property]);
                }
                else
                {
                    return null;
                }
            }
            else if (type == "datetime")
            {
                return Convert.ToDateTime(row[property]);
            }
            else if(type == "ResourceType")
            {
                return (ResourceType)row[property];
            }
            else if(type == "ResourceStatus")
            {
                return (ResourceStatus)row[property];
            }
            else if(type == "ReserveStatus")
            {
                int reserveStatus = Convert.ToInt32(row[property]);

                return (ReserveStatus)reserveStatus;
            }
            else
            {
                return row[property].ToString();
            }
        }
        #endregion




        //Check In
        #region Check In

        

        public Resource RetrieveResourceToUpdate(int resourceID)
        {
            List<Parameter> parameters = new List<Parameter>();
            parameters.Add(new Parameter("@ResourceID", resourceID, 0, SqlDbType.Int));
            string sql = "SELECT * FROM Ressource WHERE ID = @ResourceID";

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute(sql, CommandType.Text, parameters);

            return PopulateRessource(dt.Rows[0]);
        }

        public DataTable RetrieveResourceById(int id)
        {
            DataAccess db = new DataAccess();
            List<Parameter> parms = new List<Parameter>(){
                new Parameter("@ResourceID", id, 0, SqlDbType.Int, ParameterDirection.Input)
                };
            DataTable dt = db.Execute("CheckIn_Get_Borrowings", CommandType.StoredProcedure, parms);

            
            return dt;
        }

        

        public DataTable RetrieveResourcePriceById(int id)
        {
            DataAccess db = new DataAccess();
            List<Parameter> parms = new List<Parameter>(){
                new Parameter("@ResourceID", id, 0, SqlDbType.Int, ParameterDirection.Input)
                };
            DataTable dt = db.Execute("SELECT Price FROM Ressource WHERE ID = @ResourceID", CommandType.Text, parms);
            return dt;
        }

        public bool UpdateResourceStatusForEach(List<Resource> resources)
        {
            int length = 0;
            DataAccess db = new DataAccess();
            foreach (Resource resource in resources)
            {
                List<Parameter> parms = new List<Parameter>()
                {
                    new Parameter("@ResourceID", resource.ID, 0, SqlDbType.Int, ParameterDirection.Input),
                    new Parameter("@ResourceStatus", resource.Status, 50, SqlDbType.Int, ParameterDirection.Input),
                    new Parameter("@DateRemoved", resource.DateRemoved, 0, SqlDbType.DateTime, ParameterDirection.Input)
                };
                if (db.ExecuteNonQuery("Update_Resource_Status", CommandType.StoredProcedure, parms) > 0)
                {
                    length++;
                }
            }
            if (length == resources.Count)
            {
                return true;
            }

            return false;

        }

        //private enum ResourceStatus
        //{
        //    Available = 1,
        //    OnLoan,
        //    NotAvailable
        //} 
        #endregion
    }
}
