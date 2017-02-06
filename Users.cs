using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    public class Users
    {
        //Variables
        List<User> UsersList = new List<User>();

        //Constructor
        public Users() { }

        //Add user
        public void AddUser(string FirstName,
            string MiddleInitial,
            string LastName,
            int Age,
            string EducationLevel,
            string PhoneNumber,
            string EmailAddress,
            string Address,
            string Title,
            DateTime StartDate,
            DateTime EndDate,
            string Employer,
            string Location,
            string Description)
        {
            User.Contact _Contact = new User.Contact(PhoneNumber, EmailAddress, Address);
            User.Experience _Experience = new User.Experience(Title, StartDate, EndDate, Employer, Location, Description);
            User user = new User(FirstName, MiddleInitial, LastName, Age, EducationLevel, _Contact, _Experience);

            //Add user
            UsersList.Add(user);
        }

        //Find user
        public User GetUser(string FirstName, string MiddleInitial, string LastName)
        {
            foreach (User u in UsersList)
            {
                if (u.FirstName == FirstName && u.MiddleInitial == MiddleInitial && u.LastName == u.LastName)
                    return u;
            }
            return new User();
        }
    }
}
