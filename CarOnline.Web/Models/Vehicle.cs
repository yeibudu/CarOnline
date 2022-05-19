using System.Collections.Generic;
using System.ComponentModel;
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

        public string Type { get; set; }

        public ICollection<Brand> Brands { get; set; }
        [DisplayName("Brands Number")]
        public int BrandsNumber => Brands == null ? 0 : Brands.Count;


    }
}
