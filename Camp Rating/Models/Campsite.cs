using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Camp_Rating.Models
{
    [Table("Campsite")]
    public class Campsite
    {
        [Required]
        [MaxLength(200)]
        public string? BookName
        {
            get; set;
        }

    }
}
