using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Project
{
    public partial class BookPage : UserControl
    {
        Book bookmodel = new Book();
        Author authormodel = new Author();
        Request requestmodel = new Request();
        User UserModel = new User();
        DBClass DBClass = new DBClass();
        int page = 0;
        int pageCount;
        int userid;
        public BookPage( int userIDe)
        {
            this.userid = userIDe;
            UserModel = DBClass.CreatUserModel(userid);
            InitializeComponent();
            if (UserModel.IsAdmin)
            {
                SendRequestbutton.Hide();
                AddButton.Show();
                Deletebutton.Show();
                Updatebutton.Show();
            }
            else
            {
                AddButton.Hide();
                Deletebutton.Hide();
                Updatebutton.Hide();
                SendRequestbutton.Show();
            }
        }

        private void BookPage_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            Deletebutton.Enabled = false;
            Updatebutton.Enabled = false;
            SendRequestbutton.Enabled = false;
            check();
        }
        public void PopulateDataGridView()
        {

            dgvBookList.AutoGenerateColumns = false;
            using (LibraryEntities db = new LibraryEntities())
            {

                DBClass.GetBooksGrid(2, page,dgvBookList);
                int count = DBClass.GetBooksCount();
                this.pageCount = count / 2;
                if (count % 2 > 0)
                {
                    this.pageCount = this.pageCount + 1;
                }
                check();


            }

        }
        public void check()
        {
            if (page == 0)
            {
                Prebutton.Enabled = false;
            }
            else
            {
                Prebutton.Enabled = true;
            }
            if (pageCount > (page + 1))
            {
                Afterbutton.Enabled = true;
            }
            else
            {
                Afterbutton.Enabled = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddORChangeBook AddORChange = new AddORChangeBook(dgvBookList, 0, page);
            AddORChange.Show();

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure to Delete " + bookmodel.BookName + " Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DBClass.DeleteBook(bookmodel);
                    if (!this.page.Equals(0))
                    {
                        this.page = page - 1;
                    }


                    PopulateDataGridView();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            AddORChangeBook AddORChange = new AddORChangeBook(dgvBookList,bookmodel.BookID,page);
            AddORChange.Show();
            PopulateDataGridView();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendRequestbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to send request for  " + bookmodel.BookName + "'s book ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                requestmodel.BookID = Convert.ToInt32(bookmodel.BookID.ToString());
                requestmodel.UserID = Convert.ToInt32(userid.ToString());
                requestmodel.RequestDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                DBClass.AddRequest(requestmodel);
                MessageBox.Show("Sent request Successfully");

            }
        
        }

        private void dgvBookList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBookList.CurrentRow.Index != -1)
            {
                int BookID = Convert.ToInt32(dgvBookList.CurrentRow.Cells["ID"].Value);
                this.bookmodel = DBClass.GetBookRow(BookID);
                Updatebutton.Enabled = true;
                Deletebutton.Enabled = true;
                SendRequestbutton.Enabled = true;
            }
        }

        private void Afterbutton_Click(object sender, EventArgs e)
        {
            this.page = this.page + 1;
            PopulateDataGridView();
            check();
        }

        private void Prebutton_Click(object sender, EventArgs e)
        {
            this.page = this.page - 1;
            PopulateDataGridView();
            check();
        }

        private void txtboxBookSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtboxBookSearch.Text;
            dgvBookList.AutoGenerateColumns = false;

            DBClass.SearchBook(keyword, page, 2, dgvBookList);
            page = 0;
            check();
        }
    }
}
