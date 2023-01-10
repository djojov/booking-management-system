using System.Collections.Generic;
using Shared.Interfaces;
using Shared.Models;

namespace BusinessLayer
{
    public class ReservationBusiness:IReservationBusiness
    {
        private readonly IReservationRepository reservationRepository;
        
        public ReservationBusiness(IReservationRepository _reservationRepository)
        {
            reservationRepository = _reservationRepository;
        }
        
        public List<Reservation> GetAllReservations()
        {
            return this.reservationRepository.GetAllReservations();
        }

        public string UpdateReservation(Reservation reservation)
        {
            int rowsAffected = this.reservationRepository.UpdateReservation(reservation);

            if (rowsAffected > 0)
            {
                return "Reservation successfully updated!";
            }
            else
            {
                return "Failed to update reservation!";
            }
        }

        public string InsertReservation(Reservation reservation)
        {
            int rowsAffected = this.reservationRepository.InsertReservation(reservation);

            if (rowsAffected > 0)
            {
                return "Reservation successfully added!";
            }
            else
            {
                return "Failed to insert reservation!";
            }
        }

        public string DeleteReservation(int id)
        {
            int rowsAffected = this.reservationRepository.DeleteReservation(id);

            if (rowsAffected > 0)
            {
                return "Reservation successfully deleted!";
            }
            else
            {
                return "Failed to delete reservation!";
            }
        }
    }
}