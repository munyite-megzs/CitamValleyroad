using CitamChoir.Models;
using System.Collections.Generic;

namespace CitamChoir.ViewModel
{
    public class MembersFormViewModel
    {
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public int Occupation { get; set; }
        public IEnumerable<Occupation> Occupations { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string InductionDate { get; set; }
        public bool BGV { get; set; }
        public bool WorshipLeader { get; set; }
        public bool Leader { get; set; }
    }
}