using System.Collections.Generic;
using Shared.Interfaces;
using Shared.Models;

namespace BusinessLayer
{
    public class AccommodationBusiness: IAccommodationBusiness
    {
        private readonly IAccommodationRepository accommodationRepository;
        
        public AccommodationBusiness(IAccommodationRepository _accommodationRepository)
        {
            accommodationRepository = _accommodationRepository;
        }
        
        public List<Accommodation> GetAllAccommodations()
        {
            return this.accommodationRepository.GetAllAccommodations();
        }

        public string UpdateAccommodation(Accommodation accommodation)
        {
            int rowsAffected = this.accommodationRepository.UpdateAccommodation(accommodation);

            if (rowsAffected > 0)
            {
                return "Accommodation successfully updated!";
            }
            else
            {
                return "Failed to update accommodation!";
            }
        }

        public string InsertAccommodation(Accommodation accommodation)
        {
            int rowsAffected = this.accommodationRepository.InsertAccommodation(accommodation);

            if (rowsAffected > 0)
            {
                return "Accommodation successfully added!";
            }
            else
            {
                return "Failed to insert accommodation!";
            }
        }

        public string DeleteAccommodation(int id)
        {
            int rowsAffected = this.accommodationRepository.DeleteAccommodation(id);

            if (rowsAffected > 0)
            {
                return "Accommodation successfully deleted!";
            }
            else
            {
                return "Failed to delete accommodation!";
            }
        }
    }
}