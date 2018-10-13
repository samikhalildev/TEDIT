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
    public partial class Login : Form
    {
        User user;

        public Login() {
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

            // Get user data from the login form
            string _Username = username.Text;
            string _Password = password.Text;

            if (string.IsNullOrWhiteSpace(_Username) || string.IsNullOrWhiteSpace(_Password)) {
                MessageBox.Show("Username and password cannot be empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            user = UserManager.FindUser(_Username, _Password);

            if (user != null) {
                Console.WriteLine("User found: " + user);

                EditorWindow editorWindow = new EditorWindow(user);
                this.Close();

            } else {
                MessageBox.Show("Incorrect username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
