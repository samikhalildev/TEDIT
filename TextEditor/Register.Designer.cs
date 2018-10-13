namespace TEDIT
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repasword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.usertype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(357, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleCancel);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.password.Location = new System.Drawing.Point(230, 203);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(224, 24);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            this.password.Click += new System.EventHandler(this.PasswordTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(146, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(122, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "TEXT EDITOR - REGISTER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(209, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleRegister);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(230, 171);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(224, 24);
            this.username.TabIndex = 3;
            this.username.Click += new System.EventHandler(this.UsernameTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(146, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // repasword
            // 
            this.repasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.repasword.Location = new System.Drawing.Point(230, 235);
            this.repasword.Name = "repasword";
            this.repasword.PasswordChar = '*';
            this.repasword.Size = new System.Drawing.Size(224, 24);
            this.repasword.TabIndex = 5;
            this.repasword.UseSystemPasswordChar = true;
            this.repasword.Click += new System.EventHandler(this.RePasswordTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(87, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Re Enter Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.firstname.Location = new System.Drawing.Point(209, 121);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(111, 24);
            this.firstname.TabIndex = 1;
            this.firstname.Click += new System.EventHandler(this.FirstNameTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(125, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "First Name";
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lastname.Location = new System.Drawing.Point(407, 121);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(111, 24);
            this.lastname.TabIndex = 2;
            this.lastname.Click += new System.EventHandler(this.LastNameTextBox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(328, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(135, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date of Birth";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(230, 285);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(192, 20);
            this.dob.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(150, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "User Type";
            // 
            // usertype
            // 
            this.usertype.DropDownHeight = 250;
            this.usertype.DropDownWidth = 120;
            this.usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype.FormattingEnabled = true;
            this.usertype.IntegralHeight = false;
            this.usertype.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.usertype.Location = new System.Drawing.Point(230, 311);
            this.usertype.Name = "usertype";
            this.usertype.Size = new System.Drawing.Size(121, 26);
            this.usertype.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(618, 444);
            this.Controls.Add(this.usertype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.repasword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repasword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox usertype;
    }
}