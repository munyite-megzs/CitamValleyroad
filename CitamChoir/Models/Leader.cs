using System.ComponentModel.DataAnnotations;

namespace CitamChoir.Models
{
    public class Leader
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}