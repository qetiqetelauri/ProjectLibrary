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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitSignInLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var user = db.Users.Where(x => x.UserMail.Equals(EmailTextboxSignIn.Text) && x.UserPassword.Equals(PasswordTextboxSignIn.Text)).FirstOrDefault();
                //Console.WriteLine(user);
               
                if (db.Users.Any(x => x.UserMail.Equals(EmailTextboxSignIn.Text) && x.UserPassword.Equals(PasswordTextboxSignIn.Text)))
                {
                    MessageBox.Show("Sign In Succesfully");
                    Console.WriteLine("userid in signup"+user.UserID);
                    LibraryForm Library = new LibraryForm(user.UserID);
                    Library.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("password or Email is incorrect");
                }
            }
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}
