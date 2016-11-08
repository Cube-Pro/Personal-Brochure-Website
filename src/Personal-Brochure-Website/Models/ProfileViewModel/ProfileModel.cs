using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_Brochure_Website.Models.ProfileModelView
{
    public class ProfileModel
    {
        public int ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string BioDetails { get; set; }
        public string BioImagePath { get; set; }
        public string[] SkillsList { get; set; }
        public string SiteName { get; set; }
        public string Copywrite { get; set; }
        public string[,] Menu { get; set; }


    }
}
