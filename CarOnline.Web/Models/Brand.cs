using System.ComponentModel.DataAnnotations;

namespace CarOnline.Web.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [MaxLength(40, ErrorMessage = "El campo {0} debe contener al menos un caracter")]
        [Required] 
        public string Name { get; set; }
    }
}
