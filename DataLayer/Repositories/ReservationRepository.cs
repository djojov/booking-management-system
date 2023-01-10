using System.Collections.Generic;
using System.Data.SqlClient;
using Shared.Interfaces;
using Shared.Models;

namespace DataLayer.Repositories
{
    public class ReservationRepository: IReservationRepository
    {
        string connectionString = Constants.ConnectionString;
        
        public List<Reservation> GetAllReservations()
        {
            List<Reservation> ListOfReservations = new List<Reservation>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                {
                    string query = "SELECT * FROM RESERVATIONS";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Reservation reservation = new Reservation();
                        reservation.Id = reader.GetInt32(0);
                        reservation.AccommodationId = reader.GetInt32(1);
                        reservation.ClientId = reader.GetInt32(2);
                        reservation.DateIn = reader.GetDateTime(3);
                        reservation.DateOut = reader.GetDateTime(4);
                        ListOfReservations.Add(reservation);
                    }

                    reader.Close();
                    connection.Close();

                    return ListOfReservations;
                }
            }
        }

        public int UpdateReservation(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE RESERVATIONS SET accommodation_id=@accommodationId,client_id=@clientId, date_in=@dateIn, date_out=@dateOut WHERE id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@accommodationId", reservation.AccommodationId);
                command.Parameters.AddWithValue("@clientId", reservation.ClientId);
                command.Parameters.AddWithValue("@dateIn", reservation.DateIn);
                command.Parameters.AddWithValue("@dateOut", reservation.DateOut);
                command.Parameters.AddWithValue("@id", reservation.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int InsertReservation(Reservation reservation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO RESERVATIONS (accommodation_id,client_id,date_in,date_out) VALUES(@accommodationId,@clientId, @dateIn, @dateOut)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@accommodationId", reservation.AccommodationId);
                command.Parameters.AddWithValue("@clientId", reservation.ClientId);
                command.Parameters.AddWithValue("@dateIn", reservation.DateIn);
                command.Parameters.AddWithValue("@dateOut", reservation.DateOut);
                command.Parameters.AddWithValue("@id", reservation.Id);

                connection.Open();
                int rowsUpdated;
                rowsUpdated = command.ExecuteNonQuery();
                connection.Close();
                return rowsUpdated;
            }
        }

        public int DeleteReservation(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM RESERVATIONS WHERE id=@id";
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