using System;

namespace Shared.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int AccommodationId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
    }
}