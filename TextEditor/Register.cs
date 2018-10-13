using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor;

namespace TEDIT
{
    public partial class Register : Form {

        string[] userData = new string[6];
        bool isTaken;

        string _username;
        string _password;
        string _repassword;
        string _usertype;
        string _firstname;
        string _lastname;
        string _dob;

        public Register() {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e) {

        }

        private void HandleRegister(object sender, EventArgs e) {
            _username = username.Text;
            _password = password.Text;
            _repassword = repasword.Text;
            _usertype = usertype.Text;
            _firstname = firstname.Text;
            _lastname = lastname.Text;
            _dob = dob.Value.ToString("dd-MM-yyyy");

            isTaken = UserManager.isUsernameTaken(_username);

            if (Validate()) {
                userData[0] = _username;
                userData[1] = _password;
                userData[2] = _usertype;
                userData[3] = _firstname;
                userData[4] = _lastname;
                userData[5] = _dob;
                Console.WriteLine("\n\n");
                UserManager.AddNewUser(userData);
                UserManager.DisplayUsers();

                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private new bool Validate() {

            // First name is empty or contains white spaces or numbers
            if (string.IsNullOrWhiteSpace(_firstname) || (_firstname.Any(char.IsDigit))) {
                MessageBox.Show("Firstname cannot be empty or contain numbers", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Last name is empty or contains white spaces or numbers
            if (string.IsNullOrWhiteSpace(_lastname) || (_lastname.Any(char.IsDigit))) {
                MessageBox.Show("Lastname cannot be empty or contain numbers", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Username is empty or contains white spaces
            if (string.IsNullOrWhiteSpace(_username)) {
                MessageBox.Show("Username cannot be empty", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Username is taken
            if (isTaken) {
                MessageBox.Show("This username has already been used.", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Password is empty or contains white spaces or is less than 4 characters
            if ((string.IsNullOrWhiteSpace(_password)) || (_password.Length < 4)) {
                MessageBox.Show("Password must be atleast 4 characters", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Re-password is not the same as pasword
            if (!_repassword.Equals(_password)) {
                MessageBox.Show("Re-password is not the same as password", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Usertype is empty
            if (string.IsNullOrEmpty(_usertype) || (!_usertype.Equals("View")) && (!_usertype.Equals("Edit"))) {
                MessageBox.Show("Please select a user type from the dropdown list", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox(object sender, EventArgs e)
        {

        }

        private void RePasswordTextBox(object sender, EventArgs e)
        {

        }
    }
}
