using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEDIT {

    public class UserManager { 

        private List<User> users;

        public UserManager() {
            users = new List<User>();
        }

        public User FindUser(string username, string password) {
        
            foreach(User user in users) {
                if(user.username.Equals(username) && user.password.Equals(password)) {
                    return user;
                }
            }

            return null;
        }

        public bool isUsernameTaken(string username) {
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
        public void LoadUsers() {

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

                    //reader.Close();
                }

            } catch(FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            } 
        }

        public void DisplayUsers() {
            foreach(User user in users) {
                Console.WriteLine(user);
            }
        }

        /* 1. This function takes user data as an array
         * 2. It iterates over each data and adds a comma seperator
         * 3. Once all data has been added to the "userLine" string, it gets passed to another function to save the data
         */
        public void AddNewUser(string[] userData) {
            string userLine = "\r\n";

            foreach(string field in userData) {
                userLine += field + ",";
            }

            Console.WriteLine(userLine);
            SaveUserToFile(userLine);
        }


        /* 1. Trys to open a file, otherwise throughs file not found exception
         * 2. Adds new user at the end of file
         * 3. Close stream
         */
        public void SaveUserToFile(string userLine) {

            try {
                User userTemp;

                using (StreamWriter writer = File.AppendText("login.txt")) {
                    writer.Write(userLine);

                    userTemp = new User();
                    userTemp.LoadUser(userLine);

                    writer.Close();
                }

            } catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
