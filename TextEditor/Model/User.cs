using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEDIT
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string DOB { get; set; }

        public User()
        {

        }

        /* 1. This method takes a line from a file and gets called from the UserList class
         * 2. Splits the line using the seperator ','
         * 3. Assigns each field respectfully
         */
        public void LoadUser(string line)
        {
            string[] fields = line.Split(',');

            username = fields[0];
            password = fields[1];
            userType = fields[2];
            firstName = fields[3];
            lastName = fields[4];
            DOB = fields[5];
        }

        public override string ToString()
        {
            return "Username: " + username + " Password: " + password;
         }
    }
}
