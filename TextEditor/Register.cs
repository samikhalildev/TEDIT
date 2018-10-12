using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void HandleRegister(object sender, EventArgs e)
        {
            this.Hide();
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
