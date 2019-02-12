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
    public partial class LibraryForm : Form
    {
        public String FirstName;
        public String LastName;
        public int userid;
        public Boolean isAdmin;
        User UserModel = new User();
        DBClass DBClass = new DBClass();
        public LibraryForm(int userID)
        {
            
            this.userid = userID;
            this.UserModel = DBClass.CreatUserModel(userID);
            bookPage1 = new BookPage(userid);
            InitializeComponent();
            SidePanel.Height = Bookbutton.Height;
            bookPage1.BringToFront();
            Requests_button.Text="MyRequests";
            Authors_MyBooks_button.Text="MyBooks";
            Authors_MyBooks_button.Hide();
            Requests_button.Hide();
            if (UserModel.IsAdmin)
            { 
                Requests_button.Text="Requests";
                Authors_MyBooks_button.Text = "Authors";
                Requests_button.Show();
                Authors_MyBooks_button.Show();
            }


            
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            bookPage1.BringToFront();
        }

        private void bookListForm1_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Bookbutton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Bookbutton.Height;
            SidePanel.Top = Bookbutton.Top;
            BookPage bookpage = new BookPage(userid);
            bookpage.BringToFront();
        }

        private void Bookbutton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bookListForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Requests_button.Height;
            SidePanel.Top = Requests_button.Top;
            requestPage1.BringToFront();
        }

        private void myBookList1_Load(object sender, EventArgs e)
        {

        }

        private void Authors_MyBooks_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Authors_MyBooks_button.Height;
            SidePanel.Top = Authors_MyBooks_button.Top;
            if (Authors_MyBooks_button.Text.Equals("MyBooks"))
            {
                BookPage bookpage = new BookPage(userid);
                bookpage.BringToFront();
            }
            else
            {
                authorsPage1.BringToFront();
            }
        }

        private void authorsPage1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void requestPage1_Load(object sender, EventArgs e)
        {

        }

        private void Bookbutton_Click_2(object sender, EventArgs e)
        {
            SidePanel.Height = Bookbutton.Height;
            SidePanel.Top = Bookbutton.Top;

            bookPage1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
