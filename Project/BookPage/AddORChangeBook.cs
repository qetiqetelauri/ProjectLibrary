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
    public partial class AddORChangeBook : Form
    {
        Book bookmodel ;
        DataGridView grid;
        int page;
        int pageCount;
        Button prebutton;
        Button afterbutton;
        int BookID;
        DBClass DBClass = new DBClass();
        public AddORChangeBook(DataGridView grid,int BookID, int page)
        {
            InitializeComponent();
            this.grid = grid;
            this.page = page;
            this.BookID = BookID;
            this.pageCount=pageCount;
            this.prebutton = prebutton;
            this.afterbutton = afterbutton;

        }

        private void AddORChangeBook_Load(object sender, EventArgs e)
        {
            try
            {

                    DBClass.AddORChangeBookLoad(AuthorcomboBox);
                if (BookID != 0)
                {
                    
                    bookmodel = DBClass.GetBook(BookID);
                    txtboxBookTitle.Text = bookmodel.BookName;
                    dateTimePickerReleaseDate.Text = bookmodel.BookReleaseDate.ToString();

                    txtBoxPublishHouse.Text = bookmodel.BookPublishHouse;
                    AddButton.Text = "Update";
                }
                else
                {
                    bookmodel = new Book();
                }
            }
            catch (Exception)
            {

                throw;
            }
               
                
            
        }

        private void AuthorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtboxBookTitle_TextChanged(object sender, EventArgs e)
        {

        }
        public void PopulateDataGridView()
        {
            try
            {
                grid.AutoGenerateColumns = false;
                DBClass.GetBooksGrid(2, page, grid);
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }
       

        private void AddButton_Click(object sender, EventArgs e)
            {
            try
            {
                if(txtboxBookTitle.Text.Equals("")|| txtBoxPublishHouse.Text.Equals(""))
                {
                    MessageBox.Show("You should enter all information");
                }
                else
                {
                    bookmodel.BookName = txtboxBookTitle.Text;
                    bookmodel.BookReleaseDate = Convert.ToDateTime(dateTimePickerReleaseDate.Text);
                    bookmodel.BookAuthorID = Convert.ToInt32(AuthorcomboBox.SelectedValue.ToString());
                    bookmodel.BookPublishHouse = txtBoxPublishHouse.Text;
                    DBClass.AddORChangeBook(bookmodel);
                    PopulateDataGridView();
                    this.Hide();
                }
               
            }
            catch (Exception)
            {

                throw;
            }
               

        }

        private void AddAuthor1_Click(object sender, EventArgs e)
        {
            AddORChangeAuthors AddORChange = new AddORChangeAuthors(null, 0, page,AuthorcomboBox);
            AddORChange.Show();
        }
    }
}
