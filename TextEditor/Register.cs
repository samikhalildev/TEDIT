using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEDIT
{
    public partial class Register : Form
    {
        UserManager userManager;
        string[] userData = new string[7];

        string _username;
        string _password;
        string _repassword;
        string _usertype;
        string _firstname;
        string _lastname;
        string _dob;

        public Register()
        {
            InitializeComponent();
        }

        public Register(UserManager userManager) {
            InitializeComponent();
            this.userManager = userManager;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void HandleRegister(object sender, EventArgs e)
        {
            _username = username.Text;
            _password = password.Text;
            _repassword = repasword.Text;
            _usertype = usertype.Text;
            _firstname = firstname.Text;
            _lastname = lastname.Text;
            _dob = "";

            bool isTaken;

            isTaken = userManager.isUsernameTaken(_username);

            if (!isTaken && validate()) {

                userData[0] = _username;
                userData[1] = _password;
                userData[2] = _usertype;
                userData[3] = _firstname;
                userData[4] = _lastname;
                userData[5] = _dob;

                userManager.AddNewUser(userData);
                this.Hide();

            } else {
                MessageBox.Show("This username has already been used.", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private bool validate() {

            // Username is empty or contains white spaces
            if (string.IsNullOrWhiteSpace(_username)) {
                MessageBox.Show("Username cannot be empty", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // First name is empty of contains white spaces
            if (string.IsNullOrWhiteSpace(_firstname)) {
                MessageBox.Show("Firstname cannot be empty", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Last name is empty of contains white spaces
            if (string.IsNullOrWhiteSpace(_lastname)) {
                MessageBox.Show("Lastname cannot be empty", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void HandleCancel(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
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
