using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SignUp : Form
    {
        User userModel = new User();
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                if (db.Users.Any(x => x.UserMail == EmailTextbox.Text)) return;
                if (PasswordTextbox1.Text.Equals(PasswordTextbox2.Text) &&  PasswordTextbox1.Text.ToString().Length > 6)
                {
                    userModel.UserFirstName = FirstNameTextbox.Text;
                    userModel.UserLastName = LastNametextBox.Text;
                    userModel.UserPassword = PasswordTextbox1.Text;
                    userModel.UserMail = EmailTextbox.Text;

                    db.Users.Add(userModel);
                    db.SaveChanges();

                    MessageBox.Show("Sign Up succesfully");
                    SignIn signIn = new SignIn();
                    signIn.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid");
                }
            }
        }

        private void SignInlabel_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
