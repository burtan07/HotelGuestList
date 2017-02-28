using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataAccessObjects;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserDataAccess
    {
        string _connection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        string _FileLocation = @"C:/Users/Admin2/Desktop/ErrorLog.txt";

        public void CreateUser(DataUser daUser)
        {
            SqlConnection lConnection = new SqlConnection(_connection);
            //SQLCommand cmd = new SQLCommand("", lConnection);

            try
            {
                //cmd.CommandType = CommandType.StoredProcedure;
                //lConnection.Open();

            }
            catch ()
            {

            }
        }

    }
}
