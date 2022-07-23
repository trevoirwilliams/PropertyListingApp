using System.ComponentModel.DataAnnotations;

namespace PropertyListingApp.Api.DTOs.City
{
    public class CreateCityDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
