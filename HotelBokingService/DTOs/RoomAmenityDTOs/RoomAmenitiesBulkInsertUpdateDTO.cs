using System.ComponentModel.DataAnnotations;

namespace HotelBokingService.DTOs.RoomAmenityDTOs
{
    public class RoomAmenitiesBulkInsertUpdateDTO
    {
        [Required]
        public int RoomTypeID { get; set; }
        [Required]
        public List<int> AmenityIDs { get; set; }
    }
}
