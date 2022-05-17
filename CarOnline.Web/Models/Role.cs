using System.ComponentModel.DataAnnotations;

namespace CarOnline.Web.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
