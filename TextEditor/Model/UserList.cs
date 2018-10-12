using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model {

    class UserList { 

        private List<User> users;

        public UserList() {
            users = new List<User>();
        }

        public User LookUpUser(string username, string password) {
        
            foreach(User user in users) {
                if(user.username.Equals(username) && user.password.Equals(password)) {
                    return user;
                }
            }

            return null;
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
                        Console.WriteLine(line);

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


        public void SaveNewUser(Enum userEnum) {

            //string userLine = userEnum.username + "," + userEnum.password + "," +
            AddToFile("userLine");
        }

        /* 1. Trys to open a file, otherwise throughs file not found exception
         * 2. Adds new user at the end of file
         * 3. Close stream
         */
        public void AddToFile(string userLine) {

            try {
                using (StreamWriter writer = File.AppendText("login.txt")) {
                    writer.Write(userLine);
                    writer.Close();
                }

            } catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
