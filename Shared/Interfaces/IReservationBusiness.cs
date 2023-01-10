using System.Collections.Generic;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IReservationBusiness
    {
        List<Reservation> GetAllReservations();
        string UpdateReservation(Reservation reservation);
        string InsertReservation(Reservation reservation);
        string DeleteReservation(int id);
    }
}