using System;
using System.Drawing;
using System.Windows.Forms;

namespace TEDIT {

    public partial class EditorWindow : Form {

        User user;

        public EditorWindow() {
            InitializeComponent();
        }

        public EditorWindow(User user) {
            InitializeComponent();
            this.user = user;

            // Show the username of the user to the label in the tool bar
            usernameToolStripLabel.Text += user.username;
            usernameToolStripLabel.ToolTipText = user.username;
            GenerateFontSizes();
        }

        private void GenerateFontSizes() {

            Object[] fontSizes = new Object[15];
            int size = 8;

            for (int i = 0; i < fontSizes.Length; i++) {
                fontSizes[i] = size;
                size++;
            }

            toolStripComboBox1.Items.AddRange(fontSizes);
            toolStripComboBox1.SelectedIndex = 2;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            int fontSize = (int)toolStripComboBox1.SelectedItem;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, fontSize);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {
            
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e) {

            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the properties and file type
            openFileDialog.Title = "Open a Text File";
            openFileDialog.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";

            // Call the ShowDialog method to show the dialog box
            DialogResult fileResult = openFileDialog.ShowDialog();

            // Check user response
            if (fileResult == DialogResult.OK) {
                string filename = openFileDialog.FileName;
                Console.WriteLine(filename);

                // load the content of the file
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e) {

            // Create an instance of SaveFileDialog
            SaveFileDialog saveFile = new SaveFileDialog();

            // Set the properties and file type
            saveFile.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";

            // Call the ShowDialog method to show the dialog box
            DialogResult saveResult = saveFile.ShowDialog();

            // Check user response
            if (saveResult == DialogResult.OK) {
                string filename = saveFile.FileName;
                MessageBox.Show(filename);

                // save the file as a RTF file format
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }


        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {

            // Create an instance of SaveFileDialog
            SaveFileDialog saveFile = new SaveFileDialog();

            // Set the properties and file type
            saveFile.Filter = "All Files (*.*)";

            // Call the ShowDialog method to show the dialog box
            DialogResult saveResult = saveFile.ShowDialog();

            // Check user response
            if (saveResult == DialogResult.OK) {


            }
        }

        private void boldToolStripButton_Click(object sender, EventArgs e) {
            ToggleTextStyle("Bold");
        }

        private void italicToolStripButton_Click(object sender, EventArgs e) {
            ToggleTextStyle("Italic");
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e) {
            ToggleTextStyle("Underline");
        }


        private void ToggleTextStyle(string style) {

            if (style.Equals("Bold")) {

                if (boldToolStripButton.Checked) {
                    if (!richTextBox1.SelectionFont.Bold) {
                        richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Bold);
                    }

                } else {
                    if (richTextBox1.SelectionFont.Bold) {
                        richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Regular);
                    }
                }

            }
            else if (style.Equals("Italic")) {

                if (boldToolStripButton.Checked)
                    richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Italic);
                else
                    richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Regular);

            }
            else if (style.Equals("Underline")) {

                if (boldToolStripButton.Checked)
                    richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Underline);
                else
                    richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Regular);
            }

        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();

            this.Hide();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e) {
            CutText();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e) {
            CopyText();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e) {
            PasteText();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e) {
            CutText();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e) {
            CopyText();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e) {
            PasteText();
        }

        private void CopyText() {
            richTextBox1.Copy();
        }

        private void CutText() {
            richTextBox1.Cut();
        }

        private void PasteText() {
            richTextBox1.Paste();
        }
    }
}
