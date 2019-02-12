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
    public partial class AddORChangeAuthors : Form
    {
        Author authormodel;
        DataGridView grid;
        int page;
        DBClass DBClass = new DBClass();
        int AuthorID;
        ComboBox combox;
        public AddORChangeAuthors(DataGridView grid, int AuthorID, int page,ComboBox combox)
        {
            InitializeComponent();
            this.AuthorID = AuthorID;
            this.grid = grid;
            this.page = page;
            this.combox = combox;
        }
        private void AddORChangeAuthors_Load(object sender, EventArgs e)
        {
            if (AuthorID != 0)
            {
                authormodel = DBClass.CreatAutherModel(AuthorID);
                txtboxAuthorFirstName.Text = authormodel.AuthorFirstName;
                dateTimePickerBirthDate.Text = authormodel.AuthorBirthDate.ToString();
                txtBoxLastName.Text = authormodel.AuthorLastName;
                AddButton.Text = "Update";
            }
            else
            {
                authormodel = new Author();
            }

            
        }


        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        public void PopulateDataGridView()
        {
            try
            {
                grid.AutoGenerateColumns = false;
        

                    DBClass.GetAuthorsGrid(2, page, grid);

               
            }
            catch (Exception)
            {

                throw;
            }
            
        }



        private void AddButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txtboxAuthorFirstName.Text.Equals("")|| txtBoxLastName.Text.Equals(""))
                {
                    MessageBox.Show("You should enter all information");
                }
                else
                {
                    authormodel.AuthorFirstName = txtboxAuthorFirstName.Text;
                    authormodel.AuthorBirthDate = Convert.ToDateTime(dateTimePickerBirthDate.Text);
                    authormodel.AuthorLastName = txtBoxLastName.Text;
                    DBClass.AddORChangeRequest(authormodel);

                    MessageBox.Show("Submitted Successfully");
                    if (grid == null)
                    {
                        DBClass.AddORChangeBookLoad(combox);

                    }
                    PopulateDataGridView();
                    this.Hide();
                }
               

            }
            catch (Exception)
            {

                throw;
            }
          

        }
    }
}

