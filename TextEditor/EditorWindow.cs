using System;
using System.Windows.Forms;
using TEDIT;

namespace TextEditor {

    public partial class EditorWindow : Form {

        User user;

        public EditorWindow() {
            InitializeComponent();
        }

        public EditorWindow(User user) {
            InitializeComponent();
            this.user = user;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Open, " + user.username);
        }
    }
}
