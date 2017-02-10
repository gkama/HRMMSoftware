using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    class MatchJobs
    {
        //Variables
        List<Job> MatchedJobs = new List<Job>();

        //Constructor
        public MatchJobs() { }
        //Search users based on key words
        //Get key words for a job application and search users
        public MatchJobs(Jobs jobs, List<string> KeyWords, int DesiredMatchedWords)
        {
            //Loop
            foreach (Job job in jobs.GetJobs())
            {
                int MatchesCount = 0;
                List<string> _parsedJob = job.ParseJob().ConvertAll(p => p.ToLower());
                foreach (string keyWord in KeyWords)
                {
                    if (_parsedJob.Contains(keyWord))
                        MatchesCount++;
                }
                if (MatchesCount >= DesiredMatchedWords)
                    MatchedJobs.Add(job);
            }
        }

        //Get matched jobs' descriptions
        public List<string> GetMatchedJobsGeneralDescription()
        {
            List<string> toReturn = new List<string>();
            foreach (Job job in MatchedJobs)
                toReturn.Add(job.GeneralDescription);
            return toReturn;
        }
    }
}
