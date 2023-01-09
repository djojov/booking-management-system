using System.Collections.Generic;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IAccommodationBusiness
    {
        List<Accommodation> GetAllAccommodations();
        string UpdateAccommodation(Accommodation accommodation);
        string InsertAccommodation(Accommodation accommodation);
        string DeleteAccommodation(int id);
    }
}