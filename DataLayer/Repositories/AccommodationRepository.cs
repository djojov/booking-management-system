using System.Collections.Generic;
using System.Data.SqlClient;
using Shared.Interfaces;
using Shared.Models;

namespace DataLayer.Repositories
{
    public class AccommodationRepository: IAccommodationRepository
    {
        string connectionString = Constants.ConnectionString;

        public List<Accommodation> GetAllAccommodations()
        {
            List<Accommodation> ListOfAccommodations = new List<Accommodation>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                {
                    string query = "SELECT * FROM ACCOMMODATIONS";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Accommodation accommodation = new Accommodation();
                        accommodation.Id = reader.GetInt32(0);
                        accommodation.Name = reader.GetString(1);
                        accommodation.Status = reader.GetString(2);
                        accommodation.Category = reader.GetString(3);
                        accommodation.PricePerDay = reader.GetInt32(4);
                        ListOfAccommodations.Add(accommodation);
                    }

                    reader.Close();
                    connection.Close();

                    return ListOfAccommodations;
                }
            }
        }

        public int UpdateAccommodation(Accommodation accommodation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ACCOMMODATIONS SET name=@name,status=@status, category=@category, price_per_day=@pricePerDay WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", accommodation.Name);
                command.Parameters.AddWithValue("@status", accommodation.Status);
                command.Parameters.AddWithValue("@category", accommodation.Category);
                command.Parameters.AddWithValue("@pricePerDay", accommodation.PricePerDay);
                command.Parameters.AddWithValue("@id", accommodation.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int InsertAccommodation(Accommodation accommodation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ACCOMMODATIONS (name,status, category, price_per_day) VALUES(@name,@category,@status,@pricePerDay)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", accommodation.Name);
                command.Parameters.AddWithValue("@status", accommodation.Status);
                command.Parameters.AddWithValue("@category", accommodation.Category);
                command.Parameters.AddWithValue("@pricePerDay", accommodation.PricePerDay);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int DeleteAccommodation(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ACCOMMODATIONS WHERE id=@id";
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