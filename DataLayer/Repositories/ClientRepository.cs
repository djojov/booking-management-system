using System.Collections.Generic;
using System.Data.SqlClient;
using Shared.Interfaces;
using Shared.Models;

namespace DataLayer.Repositories
{
    public class ClientRepository: IClientRepository
    {
        string connectionString = Constants.ConnectionString;
        
        public List<Client> GetAllClients()
        {
            List<Client> ListOfClients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CLIENTS";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client client = new Client();
                    client.Id = reader.GetInt32(0);
                    client.FirstName = reader.GetString(1);
                    client.LastName = reader.GetString(2);
                    client.Email = reader.GetString(3);
                    client.PhoneNumber = reader.GetString(4);
                    ListOfClients.Add(client);
                }
                reader.Close();
                connection.Close();

                return ListOfClients;
            }
        }

        public int UpdateClient(Client client)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE CLIENTS SET first_name=@firstName,last_name=@lastName,phone_number=@phoneNumber,email=@email WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", client.FirstName);
                command.Parameters.AddWithValue("@lastName", client.LastName);
                command.Parameters.AddWithValue("@phoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@email", client.Email);
                command.Parameters.AddWithValue("@id", client.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;

            }
        }

        public int InsertClient(Client client)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CLIENTS (first_name,last_name,phone_number,email) VALUES(@firstName,@lastName,@phoneNumber,@email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", client.FirstName);
                command.Parameters.AddWithValue("@lastName", client.LastName);
                command.Parameters.AddWithValue("@phoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@email", client.Email);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int DeleteClient(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CLIENTS WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }
    }
}