using System.Collections.Generic;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IAccommodationRepository
    {
        List<Accommodation> GetAllAccommodations();
        int UpdateAccommodation(Accommodation accommodation);
        int InsertAccommodation(Accommodation accommodation);
        int DeleteAccommodation(int id);
    }
}