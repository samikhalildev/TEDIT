using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Model;

namespace TextEditor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameLabel(object sender, EventArgs e)
        {

        }

        private void LoginLabel(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HandleLogin(object sender, EventArgs e)
        {
            UserList userTemp = new UserList();
            User user = new User();

            // Get user data from the login form
            string _Username = username.Text;
            string _Password = password.Text;

            user = userTemp.LookUpUser(_Username, _Password);
            Console.WriteLine(_Username);
            Console.WriteLine(_Password);

            if (user != null) {
                Console.WriteLine(user);
                this.Hide();

            } else {
                MessageBox.Show("Incorrect username or password.", "Login failed");
            }



            
        }

        private void HandleExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void OpenRegisterWindow(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
