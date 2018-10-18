using System;
using System.Drawing;
using System.Windows.Forms;
using TextEditor.View;

namespace TEDIT {

    public partial class EditorWindow : Form {

        User user;
        string filename;
        bool typeOfUser;

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
            AddUserData();
        }

        /* Disable and enable text reading mode depending on the user type */
        private void CheckUserType() {
            typeOfUser = user.readOnly;
            richTextBox1.ReadOnly = typeOfUser;
        }

        /* This function gets called once when the editor is loaded
         * It sets font sizes from 8 to 22 so the user can choosen from.
         */
        private void GenerateFontSizes() {

            int size = 8;

            for (int i = 0; i < fontSizes.Length; i++) {
                fontSizes[i] = size;
                size++;
            }

            toolStripComboBox1.Items.AddRange(fontSizes);
            toolStripComboBox1.SelectedIndex = defaultFontIndex;
        }

        // Show user data in a JSON format
        void AddUserData() {
            string note = "NOTE: ";

            if (typeOfUser)
                note += "You are not able to edit/write on any document.";
            else
                note += "You are able to view and edit any document.";

            richTextBox1.Text =
                "User {\n\t" +
                    "Username: " + user.username + "\n\t" +
                    "Password: " + user.password + "\n\t" +
                    "UserType: " + user.userType + "\n\t" +
                    "FirstName: " + user.firstName + "\n\t" +
                    "LastName: " + user.lastName + "\n\t" +
                    "DOB: " + user.DOB + "\n" +
                "}" + "\n\n" + note;
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
            resetStyleButtons();
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
                filename = openFileDialog.FileName;
                Console.WriteLine(filename);

                // load the content of the file
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        /* If there is a file already saved, just override that file
         * otherwise call SaveAsFile()
         */
        private void SaveFile() {

            if (filename != null && filename != "") {
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

                // save the file as a RTF file format
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }


        private void boldToolStripButton_Click(object sender, EventArgs e) {
            if (typeOfUser)
                return;

            ToggleBold();
        }

        private void italicToolStripButton_Click(object sender, EventArgs e) {
            if (typeOfUser)
                return;

            ToggleItalic();
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e) {
            if (typeOfUser)
                return;

            ToggleUnderline();
        }


        // Set font to bold
        private void ToggleBold() {

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;

            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        // Set font to Italic
        private void ToggleItalic() {

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;

            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        // Set font to Underline
        private void ToggleUnderline() {

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;

            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }

        // When the exit button is clicked, logout the user
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

        /* This function gets called when a user selects a font size
         * The choosen font size gets applied to the selected text in the richtextbox
         */
        private void FontSizeChanged(object sender, EventArgs e) {
            if (typeOfUser)
                return;

            int fontSize = (int)toolStripComboBox1.SelectedItem;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style);
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
            resetStyleButtons();
        }

        private void resetStyleButtons() {
            boldToolStripButton.Checked = false;
            italicToolStripButton.Checked = false;
            underlineToolStripButton.Checked = false;
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

        private void helpToolStripButton_Click(object sender, EventArgs e) {
            LoadAboutForm();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
            LoadAboutForm();
        }

        private void LoadAboutForm() {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
