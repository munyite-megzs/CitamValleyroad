using CitamChoir.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitamChoir.ViewModel
{

    public class SummaryViewModel
    {
        public ICollection<Member> Members { get; set; } = new List<Member>();


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
        public int OccupationId { get; set; }
        public Occupation Occupation { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        public byte VoiceId { get; set; }
        public Voice Voice { get; set; }



        public bool BGV { get; set; } = false;
        public bool WorshipLeader { get; set; } = false;

        [Required]
        public byte LeaderId { get; set; }
        public Leader Leader { get; set; }


        public int AllMembers { get; set; }
        public int AllSopranos { get; set; }
        public int AllAltors { get; set; }
        public int AllTenors { get; set; }
        public int AllBass { get; set; }
        public int AllBand { get; set; }






    }
}