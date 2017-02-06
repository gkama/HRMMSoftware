using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EducationLevel { get; set; }
        public Contact ContactData { get; set; }
        public Experience ExperienceData { get; set; }

        //Constructor
        public User() { }
        public User(string FirstName, string MiddleInitial, string LastName, int Age, string EducationLevel, Contact ContactData, Experience ExperienceData)
        {
            this.FirstName = FirstName;
            this.MiddleInitial = MiddleInitial;
            this.LastName = LastName;
            this.Age = Age;
            this.EducationLevel = EducationLevel;
            this.ContactData = ContactData;
            this.ExperienceData = ExperienceData;
        }


        //Contact information
        public class Contact
        {
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }
            public string Address { get; set; }

            //Constructor
            public Contact(string PhoneNumber, string EmailAddress, string Address)
            {
                this.PhoneNumber = PhoneNumber;
                this.EmailAddress = EmailAddress;
                this.Address = Address;
            }
        }

        //Experience - most recent/relevent 
        public class Experience
        {
            public string Title { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Employer { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }

            //Constructor
            public Experience(string Title, DateTime StartDate, DateTime EndDate, string Employer, string Location, string Description)
            {
                this.Title = Title;
                this.StartDate = StartDate;
                this.EndDate = EndDate;
                this.Employer = Employer;
                this.Location = Location;
                this.Description = Description;
            }

            //Work Duration
            public string Duration()
            {
                SortedDictionary<String, int> timeUnits = new SortedDictionary<String, int>();
                timeUnits.Add("day", 1);
                timeUnits.Add("month", 30);
                timeUnits.Add("year", 365);

                //Result from conversion
                SortedDictionary<String, int> Results = new SortedDictionary<String, int>();

                //Sort the time in descending order
                string[] Names = { "year", "month", "day" };

                int daysRemaining = (EndDate - StartDate).Days;
                foreach (string unit in Names)
                {
                    int divisor = timeUnits[unit];
                    Results.Add(unit, daysRemaining / divisor);
                    daysRemaining %= divisor;
                }

                //Composing out string
                StringBuilder DurationSB = new StringBuilder();

                //Check the results for a maximal time unit to have a non-zero value
                //and remember the unit's position in the sorted "names" array
                int Position = -1;
                for (int i = 0; i < Names.Count(); i++)
                {
                    if (Results[Names[i]] != 0)
                    {
                        Position = i; break;
                    }
                }

                //Limit output to 3 consecutive values if input larger than year, 2 otherwise
                int Offset = Names[Position].Equals("year") ? 3 : 2;

                //Iterate through appropriate time units and append their respective values
                //to the output string:
                for (int i = Position; i < Position + Offset && i < Names.Count(); i++)
                {
                    int n = Results[Names[i]];
                    if (n == 0) continue;
                    if (i > Position)
                    {
                        //Add comma or "and" between the values
                        DurationSB.Append(i == Position + Offset - 1 ? " and " : ", ");
                    }
                    DurationSB.Append(n + " " + Names[i]);
                    //Plural suffix
                    if (n > 1) DurationSB.Append("s");
                }
                //Return the result
                return DurationSB.ToString().Trim();
            }
            //Work duration in days
            public int DurationInDays()
            {
                return (EndDate - StartDate).Days;
            }
        }
    }
}
