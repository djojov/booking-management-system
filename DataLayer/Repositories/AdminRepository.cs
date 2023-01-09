using System.Data.SqlClient;
using Shared.Interfaces;
using Shared.Models;

namespace DataLayer.Repositories
{
    public class AdminRepository:IAdminRepository
    {
        string connectionString = Constants.ConnectionString;
        
        public Admin GetAdmin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ADMINS WHERE username=@username AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                Admin admin = new Admin();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    admin.Id = reader.GetInt32(0);
                    admin.Username = reader.GetString(1);
                    admin.Password = reader.GetString(2);
                }
                reader.Close();
                connection.Close();
                return admin;
            }
        }
    }
}