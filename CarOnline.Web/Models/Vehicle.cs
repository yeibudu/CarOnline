using System.ComponentModel.DataAnnotations;

namespace CarOnline.Web.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Plate { get; set; }

        public string Model { get; set; }

        public string Doors { get; set; }
    }
}
