using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMMSoftware
{
    class MatchUsers
    {
        //Variables
        List<User> MatchedUsers = new List<User>();

        //Constructor
        public MatchUsers() { }
        //Search users based on key words
        //Get key words for a job application and search users
        public MatchUsers(Users users, List<string> KeyWords, int DesiredMatchedWords)
        {
            //Loop
            foreach (User user in users.GetUsers())
            {
                int MatchesCount = 0;
                foreach (string keyWord in KeyWords)
                {
                    if (user.Resume.ToLower().Contains(keyWord.ToLower().Trim()))
                        MatchesCount++;
                }
                if (MatchesCount >= DesiredMatchedWords)
                    MatchedUsers.Add(user);
            }
        }

        //Get names of matched users
        public List<string> GetMatchedUsersNames()
        {
            List<string> toReturn = new List<string>();
            foreach (User user in MatchedUsers)
                toReturn.Add(user.LastName + ", " + user.FirstName);
            return toReturn;
        }
        //Get names of matched users plus their age
        public List<string> GetMatchedUsersNamesAge()
        {
            List<string> toReturn = new List<string>();
            foreach (User user in MatchedUsers)
                toReturn.Add(user.LastName + ", " + user.FirstName + " - " + user.Age + " years old");
            return toReturn;
        }
        //Get names of matched users plus their education level
        public List<string> GetMatchedUsersNamesEducationLevel()
        {
            List<string> toReturn = new List<string>();
            foreach (User user in MatchedUsers)
                toReturn.Add(user.LastName + ", " + user.FirstName + " - " + user.EducationLevel);
            return toReturn;
        }
    }
}
