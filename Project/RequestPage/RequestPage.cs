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
    public partial class RequestPage : UserControl
    {
        
        int page = 0;
        int pageCount;
        Request requestmodel = new Request();
        DBClass DBClass = new DBClass();
        public RequestPage()
        {
            InitializeComponent();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }
        public void PopulateDataGridView()
        {

            dgvRequestList.AutoGenerateColumns = false;
            DBClass.GetRequestGrid(2, page, dgvRequestList);
            int count = DBClass.GetRequestCount();
                this.pageCount = count / 2;

                if (count % 2 > 0)
                {
                    this.pageCount = this.pageCount + 1;
                }
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
        private void Reject_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            AcceptButton.Enabled = false;
            Rejectbutton.Enabled = false;

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Accept  Request ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DBClass.AcceptRequest(requestmodel);
                    if (!this.page.Equals(0))
                    {
                        this.page = page - 1;
                    }
                    PopulateDataGridView();
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
        }

        private void Rejectbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Reject  Request ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Console.WriteLine("request123"+requestmodel);
                    DBClass.RejectRequest(requestmodel);
                    if (!this.page.Equals(0))
                    {
                        this.page = page - 1;
                    }
                    PopulateDataGridView();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        private void Historybutton_Click(object sender, EventArgs e)
        {
            AllRequest allrequest = new AllRequest();
            allrequest.Show();
        }

        private void Prebutton_Click(object sender, EventArgs e)
        {

        }

        private void Afterbutton_Click(object sender, EventArgs e)
        {

        }

        private void txtboxAuthorSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String keyword = txtboxRequestSearch.Text;
                dgvRequestList.AutoGenerateColumns = false;
         
                DBClass.SearchRequest(keyword, page, 2, dgvRequestList);
                page = 0;
                check();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void dgvRequestList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
           
        }

        private void Closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvRequestList_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvRequestList.CurrentRow.Index != -1)
                {
                    int RequestID = Convert.ToInt32(dgvRequestList.CurrentRow.Cells["ID"].Value);
                    requestmodel = DBClass.GetRequestRow(RequestID);
                    Console.WriteLine("reque" + requestmodel);
                    AcceptButton.Enabled = true;
                    Rejectbutton.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
