using System;
using System.ComponentModel.DataAnnotations;

namespace CitamChoir.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public ApplicationUser VoiceLeader { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string OtherNames { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(250)]
        public Occupation Occupation { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public Voice Voice { get; set; }
        public DateTime InductionDate { get; set; }

        public bool BGV { get; set; } = false; 
        public bool WorshipLeader { get; set; } = false;
        public bool Leader { get; set; } = false;

    }
}