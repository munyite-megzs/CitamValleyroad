using CitamChoir.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CitamChoir.ViewModel
{
    public class MembersFormViewModel
    {

        [Required]
        public string FirstName { get; set; }
        [Required] 


        public string OtherNames { get; set; }
        [Required] 


        public string Gender { get; set; }
        [Required] 


        public int Occupation { get; set; }
        


        public IEnumerable<Occupation> Occupations { get; set; }


        [Required]
        public byte Voice { get; set; }
        public IEnumerable<Voice> Voices { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string InductionDate { get; set; }

        
        public bool BGV { get; set; }
         
        public bool WorshipLeader { get; set; }

        [Required]
        public byte Leader { get; set; }
        public IEnumerable<Leader> Leaders { get; set; }


        public DateTime GetDateTime()
        {
           
                return DateTime.Parse(InductionDate);
            
        }

        public string FialGender
        {
            get
            {
                return Gender == "0" ? "Female" : "Male";       
            }
        }
    }
}