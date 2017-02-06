using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    public class Job
    {
        public string GeneralDescription { get; set; }
        public int YearsExperience { get; set; }
        public List<string> Duties = new List<string>();
        public List<string> Knowledge = new List<string>();
        public List<string> Skills = new List<string>();
        public List<string> Abilities = new List<string>();
        public List<string> ExperienceRequirements = new List<string>();
        public string Education { get; set; }
        public int StartingSalaryRangeStart { get; set; }
        public int StartingSalaryRangeEnd { get; set; }

        //Constructor
        public Job(string GeneralDescription, int YearsExperience,
            List<string> Duties, List<string> Knowledge, List<string> Skills, List<string> Abilities, List<string> ExperienceRequirements,
            string Education, int StartingSalaryRangeStart, int StartingSalaryRangeEnd)
        {
            this.GeneralDescription = GeneralDescription;
            this.YearsExperience = YearsExperience;
            this.Duties = Duties;
            this.Knowledge = Knowledge;
            this.Skills = Skills;
            this.Abilities = Abilities;
            this.ExperienceRequirements = ExperienceRequirements;
            this.Education = Education;
            this.StartingSalaryRangeStart = StartingSalaryRangeStart;
            this.StartingSalaryRangeEnd = StartingSalaryRangeEnd;
        }
    }
}
