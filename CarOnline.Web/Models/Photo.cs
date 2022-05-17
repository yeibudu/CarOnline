using System.ComponentModel.DataAnnotations;

namespace CarOnline.Web.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
