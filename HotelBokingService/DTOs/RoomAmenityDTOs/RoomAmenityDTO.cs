using System.ComponentModel.DataAnnotations;

namespace HotelBokingService.DTOs.RoomAmenityDTOs
{
    public class RoomAmenityDTO
    {
        [Required]
        public int RoomTypeID { get; set; }
        [Required]
        public int AmenityID { get; set; }
    }
}
