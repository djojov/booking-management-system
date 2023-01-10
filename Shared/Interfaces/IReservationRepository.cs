using System.Collections.Generic;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        int UpdateReservation(Reservation reservation);
        int InsertReservation(Reservation reservation);
        int DeleteReservation(int id);
    }
}