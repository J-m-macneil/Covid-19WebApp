using MyFirstProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Services
{
    public class UsersDAO
    {

        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    public bool FindUserByNameAndPassword(User user)
        {
            bool success = false;

            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username AND @password = @password";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    }
                }
            return success;
        }
    
    }
}
