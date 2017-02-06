using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    public class Jobs
    {
        //Variables
        List<Job> JobsList = new List<Job>();

        //Constructor
        public Jobs() { }

        //Add a job
        public void AddJob(string GeneralDescription,
            int YearsExperience,
            List<string> Duties,
            List<string> Knowledge,
            List<string> Skills,
            List<string> Abilities,
            List<string> ExperienceRequirements,
            string Education,
            int StartingSalaryRangeStart,
            int StartingSalaryRangeEnd)
        {
            Job job = new Job(GeneralDescription, YearsExperience, Duties, Knowledge, Skills, Abilities, 
                ExperienceRequirements, Education, StartingSalaryRangeStart, StartingSalaryRangeEnd);
            JobsList.Add(job);
        }
    }
}
