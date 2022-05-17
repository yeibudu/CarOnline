using System.ComponentModel.DataAnnotations;

namespace CarOnline.Web.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Document { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(60)]
        public string LastName { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }
    }
}
