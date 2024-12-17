using HotelBokingService.CustomValidator;
using System.ComponentModel.DataAnnotations;

namespace HotelBokingService.DTOs.HotelSearchDTOs
{
    public class PriceRangeHotelSearchRequestDTO
    {

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Minimum price must be greater than or equal to 0.")]
        public decimal MinPrice { get; set; }
        [Required]
        [PriceRangeValidation("MinPrice", "MaxPrice")]
        public decimal MaxPrice { get; set; }
    }
}
