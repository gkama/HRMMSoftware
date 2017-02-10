using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    public class Job
    {
        //Variables
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
        //Job with just a general description
        public Job(string GeneralDescription)
        {
            this.GeneralDescription = GeneralDescription;
        }

        //Parse and store the whole job description
        public List<string> ParseJob()
        {
            List<string> toReturn = new List<string>();
            //Parsing
            foreach (string s in GeneralDescription.Split(' ').ToList<string>())
                toReturn.Add(s.Trim());
            toReturn.Add(YearsExperience.ToString());
            foreach (string d in Duties)
                toReturn.Add(d.Trim());
            foreach (string k in Knowledge)
                toReturn.Add(k.Trim());
            foreach (string ss in Skills)
                toReturn.Add(ss.Trim());
            foreach (string a in Abilities)
                toReturn.Add(a.Trim());
            foreach (string er in ExperienceRequirements)
                toReturn.Add(er.Trim());
            foreach (string e in Education.Split(' ').ToList<string>())
                toReturn.Add(e.Trim());
            toReturn.Add(StartingSalaryRangeStart.ToString());
            toReturn.Add(StartingSalaryRangeEnd.ToString());

            return toReturn;
        }
    }
}
