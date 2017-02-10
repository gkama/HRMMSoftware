using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    //HR Match Making Software
    /// <summary>
    /// In this app, we’ll create a version of Match.com, but for job seekers and employers. The key requirements are:
    ///Register a new user as an employer, or a job seeker.
    ///
    ///Create a new profile for the user. For the employee, this should include, but isn’t limited to, age, contact data, 
    ///education level, grades, prior work experience, etc. Employers, on the other hand, should include their location, 
    ///industry, current employee strength, vacancies, etc.
    ///
    ///Give employers the ability to post new job requirements.
    ///Match job seekers with new jobs that fit their requirements.
    /// </summary>
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {
            //Variables
            Users users = new Users();
            Jobs jobs = new Jobs();


            users.AddUser("George", "T", "Best", 24, "Bachelor", "Resume", "9999999999", "gk@yahoo.com", "1234 Street Dr, KY", 
                "Associate", new DateTime(2014, 8, 18), new DateTime(2017, 2, 6), "Company", "Town, ST", "Work as a programmer doing programmer stuff");

            jobs.AddJob("this is a computer scienece job", 2, new List<string>() { "program", "code", "develop" },
                new List<string>() { "c#", ".net", "asp.net" },
                new List<string>() { "program", "code", "develop" },
                new List<string>() { "work in team environment", "nice", "develop" },
                new List<string>() { "c#", "program", "code" },
                "Bachelor", 45000, 50000);

            MatchUsers mu = new MatchUsers(users, new List<string>() { "resume" }, 1);
            MatchJobs mj = new MatchJobs(jobs, new List<string>() { "c#" }, 1);

            Console.WriteLine("hello");
        }
    }
}
