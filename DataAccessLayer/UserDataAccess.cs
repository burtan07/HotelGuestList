﻿using System;
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

        public void CreateUser(DataUser daUser) //registers a user
        {
            SqlConnection lConnection = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand("sp_RegisterUser", lConnection);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                lConnection.Open();
                cmd.Parameters.AddWithValue("@Pin", daUser.UserPin);
                cmd.Parameters.AddWithValue("@UserName", daUser.UserName);
                cmd.Parameters.AddWithValue("@Password", daUser.Password);
                cmd.Parameters.AddWithValue("@FirstName", daUser.FirstName);
                cmd.Parameters.AddWithValue("@LastName", daUser.LastName);
                cmd.Parameters.AddWithValue("@Email", daUser.EmailAddress);
                cmd.Parameters.AddWithValue("@BirthDate", daUser.BirthDate);
                cmd.Parameters.AddWithValue("@StreetAddress", daUser.StreetAddress);
                cmd.Parameters.AddWithValue("@City", daUser.City);
                cmd.Parameters.AddWithValue("@State", daUser.State);
                cmd.Parameters.AddWithValue("@ZipCode", daUser.ZipCode);
                cmd.Parameters.AddWithValue("@PhoneNumber", daUser.PhoneNumber);
                cmd.Parameters.AddWithValue("@SecurityQuestion", daUser.SecurityQuestion);
                cmd.Parameters.AddWithValue("@SecurityAnswer", daUser.SecurityAnswer);
                cmd.Parameters.AddWithValue("@UserRole", daUser.UserRole);

                cmd.ExecuteNonQuery();
                
            }
            catch (SqlException error)
            {
                using (StreamWriter lWriter = new StreamWriter(_FileLocation, true))
                {
                    lWriter.WriteLine(error.Message);
                }
            }
            finally
            {
                lConnection.Close();
            }
        }

    }
}
