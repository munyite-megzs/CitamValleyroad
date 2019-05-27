using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitamChoir.Models
{
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string OtherName { get; set; }

        [Required]
        public DateTime DateTime { get; set; } 

        [Required]
        [StringLength(250)]
        public string Remarks { get; set; }

        [Required]

        public bool Attended { get; set; } = false;

        [Required]
        public byte LeaderId { get; set; }

        [Required]
        public byte VoiceId { get; set; }

        public string PhoneNumber { get; set; }
    }
}