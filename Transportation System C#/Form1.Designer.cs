namespace Transportation_System_C_
{
    partial class Form1
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.con_google = new System.Windows.Forms.Button();
            this.con_apple = new System.Windows.Forms.Button();
            this.con_email = new System.Windows.Forms.Button();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(332, 78);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 0;
            this.username.Text = "UserName";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(332, 149);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(612, 207);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(82, 27);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // con_google
            // 
            this.con_google.Location = new System.Drawing.Point(335, 294);
            this.con_google.Name = "con_google";
            this.con_google.Size = new System.Drawing.Size(131, 53);
            this.con_google.TabIndex = 3;
            this.con_google.Text = "Continue With Google";
            this.con_google.UseVisualStyleBackColor = true;
            this.con_google.Click += new System.EventHandler(this.con_google_Click);
            // 
            // con_apple
            // 
            this.con_apple.Location = new System.Drawing.Point(592, 294);
            this.con_apple.Name = "con_apple";
            this.con_apple.Size = new System.Drawing.Size(117, 53);
            this.con_apple.TabIndex = 4;
            this.con_apple.Text = "Continue With Apple";
            this.con_apple.UseVisualStyleBackColor = true;
            this.con_apple.Click += new System.EventHandler(this.con_apple_Click);
            // 
            // con_email
            // 
            this.con_email.Location = new System.Drawing.Point(814, 294);
            this.con_email.Name = "con_email";
            this.con_email.Size = new System.Drawing.Size(126, 53);
            this.con_email.TabIndex = 5;
            this.con_email.Text = "Continue With Email";
            this.con_email.UseVisualStyleBackColor = true;
            this.con_email.Click += new System.EventHandler(this.con_email_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(609, 78);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(100, 22);
            this.username_textBox.TabIndex = 6;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(609, 143);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 22);
            this.password_textBox.TabIndex = 7;
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(609, 455);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(80, 31);
            this.signup.TabIndex = 8;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 647);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.con_email);
            this.Controls.Add(this.con_apple);
            this.Controls.Add(this.con_google);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button con_google;
        private System.Windows.Forms.Button con_apple;
        private System.Windows.Forms.Button con_email;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button signup;
    }
}

