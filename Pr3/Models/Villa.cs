using System.ComponentModel.DataAnnotations;

namespace Pr3.Models
{
    public class Villa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name
        {
            get; set;
        }
    }
}
