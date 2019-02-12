using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AllRequest : Form
    {
        LibraryEntities db;
        Request requestmodel = new Request();
        DBClass DBClass = new DBClass();
        int page = 0;
        int pageCount;
        int userid;
        public AllRequest()
        {
            InitializeComponent();
        }
        public void PopulateDataGridView()
        {

            dgvRequestList.AutoGenerateColumns = false;
            DBClass.GetAllRequestGrid(2, page, dgvRequestList);
            int count = DBClass.GetRequestCount();
            this.pageCount = count / 2;
            if (count % 2 > 0)
            {
                this.pageCount = this.pageCount + 1;
            }
            check();

        }
    
            private void Prebutton_Click(object sender, EventArgs e)
        {
            this.page = this.page - 1;
            PopulateDataGridView();
            check();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtboxRequestSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtboxRequestSearch.Text;
            dgvRequestList.AutoGenerateColumns = false;
            using (LibraryEntities db = new LibraryEntities())
            {
                var list = from Request in db.Requests
                           join User in db.Users on Request.UserID equals User.UserID
                           join book in db.Books on Request.BookID equals book.BookID
                           where (book.BookName.Contains(keyword) || User.UserFirstName.Contains(keyword) || User.UserLastName.Contains(keyword))
                           select new
                           {
                               Request.RequestID,
                               Request.RequestDate,
                               UserFullName = User.UserFirstName.ToString() + " " + User.UserLastName.ToString(),
                               BookTitle = book.BookName,
                               RequestStatus = Request.RequestStatus.ToString()
                           };

                dgvRequestList.DataSource = list.OrderBy(x => x.RequestID).Skip(2 * page).Take(2).ToList();
                page = 0;
                check();
            }
        }

        private void Afterbutton_Click(object sender, EventArgs e)
        {
            this.page = this.page + 1;
            PopulateDataGridView();
            check();
        }

        private void dgvRequestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Are You Sure to Delete  Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (LibraryEntities db = new LibraryEntities())
                    {
                        var entry = db.Entry(requestmodel);
                        if (entry.State == EntityState.Detached)
                            db.Requests.Attach(requestmodel);

                        db.Requests.Remove(requestmodel);
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Deleted Successfully");
                        }
                        catch
                        {
                            MessageBox.Show("you can not delet this record");

                        }

                        if (!this.page.Equals(0))
                        {
                            this.page = page - 1;
                        }


                        PopulateDataGridView();
                    }
                }
            }

        private void dgvRequestList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
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

        private void AllRequest_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            Deletebutton.Enabled = false;
            check();
        }

        private void dgvRequestList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRequestList_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRequestList.CurrentRow.Index != -1)
            {
                requestmodel.RequestID = Convert.ToInt32(dgvRequestList.CurrentRow.Cells["ID"].Value);
                using (LibraryEntities db = new LibraryEntities())
                {
                    this.requestmodel = db.Requests.Where(x => x.RequestID == requestmodel.RequestID).FirstOrDefault();

                }
                Deletebutton.Enabled = true;
            }
        }
    }
}
