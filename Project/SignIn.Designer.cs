namespace Project
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panelLeftSignIn = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxSignIn = new System.Windows.Forms.PictureBox();
            this.panelRightSignIn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextboxSignIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailTextboxSignIn = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.ExitSignInLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PasswordLabelSignIn = new System.Windows.Forms.Label();
            this.usernamelabelSingIn = new System.Windows.Forms.Label();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.panelLeftSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignIn)).BeginInit();
            this.panelRightSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSignIn
            // 
            this.panelLeftSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelLeftSignIn.Controls.Add(this.label10);
            this.panelLeftSignIn.Controls.Add(this.pictureBoxSignIn);
            this.panelLeftSignIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSignIn.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeftSignIn.Name = "panelLeftSignIn";
            this.panelLeftSignIn.Size = new System.Drawing.Size(194, 339);
            this.panelLeftSignIn.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Your Contacts";
            // 
            // pictureBoxSignIn
            // 
            this.pictureBoxSignIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSignIn.Image")));
            this.pictureBoxSignIn.Location = new System.Drawing.Point(48, 84);
            this.pictureBoxSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxSignIn.Name = "pictureBoxSignIn";
            this.pictureBoxSignIn.Size = new System.Drawing.Size(94, 89);
            this.pictureBoxSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSignIn.TabIndex = 0;
            this.pictureBoxSignIn.TabStop = false;
            // 
            // panelRightSignIn
            // 
            this.panelRightSignIn.BackColor = System.Drawing.Color.White;
            this.panelRightSignIn.Controls.Add(this.label1);
            this.panelRightSignIn.Controls.Add(this.PasswordTextboxSignIn);
            this.panelRightSignIn.Controls.Add(this.label8);
            this.panelRightSignIn.Controls.Add(this.EmailTextboxSignIn);
            this.panelRightSignIn.Controls.Add(this.signUpLabel);
            this.panelRightSignIn.Controls.Add(this.ExitSignInLabel);
            this.panelRightSignIn.Controls.Add(this.SignInButton);
            this.panelRightSignIn.Controls.Add(this.PasswordLabelSignIn);
            this.panelRightSignIn.Controls.Add(this.usernamelabelSingIn);
            this.panelRightSignIn.Controls.Add(this.SignInLabel);
            this.panelRightSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSignIn.Location = new System.Drawing.Point(194, 0);
            this.panelRightSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRightSignIn.Name = "panelRightSignIn";
            this.panelRightSignIn.Size = new System.Drawing.Size(228, 339);
            this.panelRightSignIn.TabIndex = 2;
            this.panelRightSignIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(34, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 3);
            this.label1.TabIndex = 29;
            // 
            // PasswordTextboxSignIn
            // 
            this.PasswordTextboxSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextboxSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextboxSignIn.Location = new System.Drawing.Point(34, 177);
            this.PasswordTextboxSignIn.Name = "PasswordTextboxSignIn";
            this.PasswordTextboxSignIn.PasswordChar = '*';
            this.PasswordTextboxSignIn.Size = new System.Drawing.Size(160, 19);
            this.PasswordTextboxSignIn.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(34, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 3);
            this.label8.TabIndex = 27;
            // 
            // EmailTextboxSignIn
            // 
            this.EmailTextboxSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextboxSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextboxSignIn.Location = new System.Drawing.Point(34, 122);
            this.EmailTextboxSignIn.Name = "EmailTextboxSignIn";
            this.EmailTextboxSignIn.Size = new System.Drawing.Size(160, 19);
            this.EmailTextboxSignIn.TabIndex = 26;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.signUpLabel.Location = new System.Drawing.Point(35, 301);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(177, 15);
            this.signUpLabel.TabIndex = 15;
            this.signUpLabel.Text = "do you want sign up? click here";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // ExitSignInLabel
            // 
            this.ExitSignInLabel.AutoSize = true;
            this.ExitSignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitSignInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ExitSignInLabel.Location = new System.Drawing.Point(196, 7);
            this.ExitSignInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitSignInLabel.Name = "ExitSignInLabel";
            this.ExitSignInLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitSignInLabel.TabIndex = 12;
            this.ExitSignInLabel.Text = "X";
            this.ExitSignInLabel.Click += new System.EventHandler(this.ExitSignInLabel_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(28, 237);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(173, 31);
            this.SignInButton.TabIndex = 11;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PasswordLabelSignIn
            // 
            this.PasswordLabelSignIn.AutoSize = true;
            this.PasswordLabelSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabelSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.PasswordLabelSignIn.Location = new System.Drawing.Point(26, 155);
            this.PasswordLabelSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabelSignIn.Name = "PasswordLabelSignIn";
            this.PasswordLabelSignIn.Size = new System.Drawing.Size(64, 15);
            this.PasswordLabelSignIn.TabIndex = 4;
            this.PasswordLabelSignIn.Text = "Password:";
            // 
            // usernamelabelSingIn
            // 
            this.usernamelabelSingIn.AutoSize = true;
            this.usernamelabelSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabelSingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.usernamelabelSingIn.Location = new System.Drawing.Point(26, 104);
            this.usernamelabelSingIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelabelSingIn.Name = "usernamelabelSingIn";
            this.usernamelabelSingIn.Size = new System.Drawing.Size(42, 15);
            this.usernamelabelSingIn.TabIndex = 1;
            this.usernamelabelSingIn.Text = "Email:";
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.SignInLabel.Location = new System.Drawing.Point(25, 28);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(68, 24);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Sign In";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 339);
            this.Controls.Add(this.panelRightSignIn);
            this.Controls.Add(this.panelLeftSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.panelLeftSignIn.ResumeLayout(false);
            this.panelLeftSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignIn)).EndInit();
            this.panelRightSignIn.ResumeLayout(false);
            this.panelRightSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSignIn;
        private System.Windows.Forms.PictureBox pictureBoxSignIn;
        private System.Windows.Forms.Panel panelRightSignIn;
        private System.Windows.Forms.Label ExitSignInLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label PasswordLabelSignIn;
        private System.Windows.Forms.Label usernamelabelSingIn;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextboxSignIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailTextboxSignIn;
        private System.Windows.Forms.Label label10;
    }
}