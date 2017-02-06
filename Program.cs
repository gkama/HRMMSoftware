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
        static void Main(string[] args)
        {
            Users users = new Users();
            users.AddUser("George", "T", "Best", 24, "Bachelor", "9999999999", "gk@yahoo.com", "1234 Street Dr, KY", 
                "Associate", new DateTime(2014, 8, 18), new DateTime(2017, 2, 6), "Convergys", "Cincinnati, OH", "Work as a programmer doing programmer stuff");

            Console.WriteLine("hello");
        }
    }
}
