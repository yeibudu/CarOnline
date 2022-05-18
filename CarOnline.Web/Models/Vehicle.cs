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

        public ICollection<Brand> Brands { get; set; }
        [DisplayName("Brands Number")]
        public int BrandsNumber => Brands == null ? 0 : Brands.Count;

        public ICollection<Type> Types { get; set; }
        [DisplayName("Types Number")]
        public int TypesNumber => Types == null ? 0 : Types.Count;

        public ICollection<Photo> Photos { get; set; }
        [DisplayName("Photos Number")]
        public int PhotosNumber => Photos == null ? 0 : Photos.Count;


    }
}
