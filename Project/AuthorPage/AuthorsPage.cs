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
    public partial class AuthorsPage : UserControl
    {
        LibraryEntities db;
        Author authormodel = new Author();
        int page = 0;
        int pageCount;
        DBClass DBClass = new DBClass();
        public AuthorsPage()
        {
            InitializeComponent();
        }

        private void AuthorsPage_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            Deletebutton.Enabled = false;
            Updatebutton.Enabled = false;
            check();

        }
        public void PopulateDataGridView()
        {

            dgvAuthorList.AutoGenerateColumns = false;
            DBClass.GetAuthorsGrid(2, page, dgvAuthorList);
            int count = DBClass.GetAuthorsCount();
            this.pageCount = count / 2;
                if (count % 2 > 0)
                {
                    this.pageCount = this.pageCount + 1;
                }
                Console.WriteLine(pageCount);
                check();


           
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
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete " + authormodel.AuthorFullName + " Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBClass.DeleteAuthor(authormodel);
                    this.page = page - 1;
                    MessageBox.Show("Deleted Successfully");
                    PopulateDataGridView();
                
            }
        }

        private void dgvAuthorList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAuthorList.CurrentRow.Index != -1)
            {
                int AuthorID = Convert.ToInt32(dgvAuthorList.CurrentRow.Cells["ID"].Value);
                authormodel = DBClass.GetAuthorRow(AuthorID);
                Updatebutton.Enabled = true;
                Deletebutton.Enabled = true;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Prebutton_Click(object sender, EventArgs e)
        {
           
        }

        private void txtboxAuthorSearch_TextChanged(object sender, EventArgs e)
        {
            String keyword = txtboxAuthorSearch.Text;
            dgvAuthorList.AutoGenerateColumns = false;
            DBClass.SearchAuthor(keyword, page, 2, dgvAuthorList);
                page = 0;
            
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddORChangeAuthors AddORChange = new AddORChangeAuthors(dgvAuthorList, 0, page,null);
            AddORChange.Show();
        }

        private void Updatebutton_Click_1(object sender, EventArgs e)
        {
            AddORChangeAuthors AddORChange = new AddORChangeAuthors(dgvAuthorList, authormodel.AuthorID, page,null);
            AddORChange.Show();
        }

        private void Afterbutton_Click(object sender, EventArgs e)
        {
            this.page = this.page + 1;
            PopulateDataGridView();
            check();
        }

        private void Prebutton_Click_1(object sender, EventArgs e)
        {
            this.page = this.page - 1;
            PopulateDataGridView();
            check();
        }
    }
}
