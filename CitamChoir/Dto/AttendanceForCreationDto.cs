using System.ComponentModel.DataAnnotations;

namespace CitamChoir.Dto
{
    public class AttendanceForCreationDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string OtherName { get; set; }

        [Required]
        public string DateTime { get; set; }

        [Required]
        [StringLength(250)]
        public string Remarks { get; set; }

        [Required]

        public bool Attended { get; set; } = false;

        [Required]
       
     
        public byte LeaderId { get; set; }

        [Required]
      
    
        public byte VoiceId { get; set; }
        [Required (ErrorMessage = "Phone number should be 10 digits")]
        public string PhoneNumber { get; set; }
    }
}