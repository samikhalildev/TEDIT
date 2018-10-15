using System;
using System.Drawing;
using System.Windows.Forms;

namespace TEDIT {

    public partial class EditorWindow : Form {

        User user;
        string filename;

        Object[] fontSizes = new Object[15];
        private static int defaultFontIndex = 3;

        public EditorWindow() {
            InitializeComponent();
        }

        public EditorWindow(User user) {
            InitializeComponent();
            this.user = user;

            CheckUserType();

            // Show the username of the user to the label in the tool bar
            usernameToolStripLabel.Text += user.username;
            usernameToolStripLabel.ToolTipText = user.username;
            GenerateFontSizes();

        }

        /* Disable and enable text reading mode depending on the user type */
        private void CheckUserType() {
            if (user.userType.Equals("View")) {
                richTextBox1.ReadOnly = true;

            } else {
                richTextBox1.ReadOnly = false;
            }
        }

        private void GenerateFontSizes() {

            int size = 8;

            for (int i = 0; i < fontSizes.Length; i++) {
                fontSizes[i] = size;
                size++;
            }

            toolStripComboBox1.Items.AddRange(fontSizes);
            toolStripComboBox1.SelectedIndex = defaultFontIndex;
        }


        /* Menu bar */
        private void newToolStripMenuItem1_Click(object sender, EventArgs e) {
            NewFile();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e) {
            OpenFile();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {
            SaveFile();
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e) {
            SaveAsFile();
        }


        /* Tool bar */
        private void newToolStripButton_Click(object sender, EventArgs e) {
            NewFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e) {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {
            SaveFile();
        }

        private void saveAsToolStripButton_Click(object sender, EventArgs e) {
            SaveAsFile();
        }



        /* This function will clear out the text in the richtextbox, 
         * empty the filename variable and set the default font size
         */
        private void NewFile() {
            richTextBox1.Clear();
            filename = "";
            toolStripComboBox1.SelectedIndex = defaultFontIndex;
        }

        private void OpenFile() {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the properties and file type
            openFileDialog.Title = "Open a Text File";
            openFileDialog.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";

            // Call the ShowDialog method to show the dialog box
            DialogResult fileResult = openFileDialog.ShowDialog();

            // Check user response
            if (fileResult == DialogResult.OK) {

                // Get the file path
                string filename = openFileDialog.FileName;
                Console.WriteLine(filename);

                // load the content of the file
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        /* If there is a file already saved, just override that file
         * otherwise call SaveAsFile()
         */
        private void SaveFile() {

            if (filename != null) {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);

            } else {
                SaveAsFile();
            }
        }

        private void SaveAsFile() {
            // Create an instance of SaveFileDialog
            SaveFileDialog saveFile = new SaveFileDialog();

            // Set the properties and file type
            saveFile.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";

            // Call the ShowDialog method to show the dialog box
            DialogResult saveResult = saveFile.ShowDialog();

            // Check user response
            if (saveResult == DialogResult.OK) {

                // Get the file path
                filename = saveFile.FileName;
                MessageBox.Show(filename);

                // save the file as a RTF file format
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }


        private void boldToolStripButton_Click(object sender, EventArgs e) {
            ToggleBold();
        }

        private void italicToolStripButton_Click(object sender, EventArgs e) {
            ToggleItalic();
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e) {
            ToggleUnderline();
        }


        private void ToggleBold() {

            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;

            if (boldToolStripButton.Checked) {

                if (!richTextBox1.SelectionFont.Bold)
                    newFontStyle = FontStyle.Bold;
                else
                    newFontStyle = FontStyle.Regular;
            }

            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle
            );
        }


        private void ToggleItalic() {

            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;

            if (boldToolStripButton.Checked) {

                if (!richTextBox1.SelectionFont.Italic)
                    newFontStyle = FontStyle.Italic;
                else
                    newFontStyle = FontStyle.Regular;
            }

            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle
            );
        }


        private void ToggleUnderline() {

            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;

            if (boldToolStripButton.Checked) {

                if (!richTextBox1.SelectionFont.Underline)
                    newFontStyle = FontStyle.Underline;
                else
                    newFontStyle = FontStyle.Regular;
            }

            richTextBox1.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle
            );
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

        private void FontSizeChanged(object sender, EventArgs e) {
            int fontSize = (int)toolStripComboBox1.SelectedItem;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, fontSize);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

            if (richTextBox1.Text.Length > 0) {
                undoToolStripMenuItem.Enabled = true;
            } else {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
            }
        }

        private void richTextBox1_Click(object sender, EventArgs e) {

            // get the size of the selected text
            //int size = (int)richTextBox1.SelectionFont.Size;

            toolStripComboBox1.SelectedIndex = defaultFontIndex;
        }

        private int FindFontSizeIndex(object size) {
            for (int i = 0; i < fontSizes.Length; i++) {
                if (fontSizes[i] == size) {
                    return i;
                }
            }

            return -1;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox1.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

    }
}
