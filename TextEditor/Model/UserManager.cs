using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEDIT {

    public static class UserManager {

        private static List<User> users = new List<User>();

        public static User FindUser(string username, string password) {
        
            foreach(User user in users) {
                if(user.username.Equals(username) && user.password.Equals(password)) {
                    return user;
                }
            }

            return null;
        }

        public static bool isUsernameTaken(string username) {
            foreach(User user in users) {
                if(user.username.Equals(username)) {
                    return true;
                }
            }
            return false;
        }


        /* 1. Trys to open a file, otherwise throughs file not found exception
         * 2. While there is a line to read in the file..
         * 3. Create a new User instance and call the LoadUser method with the line as a parameter
         * 4. After the user has been created and all properties has been assigned, the instance then gets added to the list
         */
        public static void LoadUsers() {

            try {

                using (StreamReader reader = new StreamReader("login.txt")) {

                    string line;
                    User userTemp;

                    // While there is something to read in the file..
                    while((line = reader.ReadLine()) != null) {

                        userTemp = new User();
                        userTemp.LoadUser(line);

                        users.Add(userTemp);
                    }

                    reader.Close();
                }

            } catch(FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            } 
        }

        public static void DisplayUsers() {
            foreach(User user in users) {
                Console.WriteLine(user);
            }
        }

        /* 1. This function takes user data as an array
         * 2. It iterates over each data and adds a comma seperator
         * 3. Once all data has been added to the "userLine" string, it gets passed to another function
         */
        public static void AddNewUser(string[] userData) {

            int len = userData.Length;
            string userLine = "\r\n";

            for(int i = 0; i < len; i++) {

                // Don't add a comma seperator on the last field.
                if(i == len-1) {
                    userLine += userData[i];
                    break;
                }

                userLine += userData[i] + ",";
            }

            //Console.WriteLine(userLine);
            SaveUserToFile(userLine);
        }


        /* 1. This function will try to open a file, otherwise through file not found exception
         * 2. Adds new user at the end of file
         * 3. Close stream
         */
        public static void SaveUserToFile(string userLine) {

            try {
                User userTemp;

                using (StreamWriter writer = File.AppendText("login.txt")) {

                    userTemp = new User();

                    // Remove line breaks before adding data to the user object and to the data structure
                    string userData = userLine.Substring(2);

                    userTemp.LoadUser(userData);
                    users.Add(userTemp);

                    writer.Close();
                }

            } catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
