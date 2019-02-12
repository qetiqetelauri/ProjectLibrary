namespace Project
{
    partial class AuthorsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxAuthorSearch = new System.Windows.Forms.TextBox();
            this.Afterbutton = new System.Windows.Forms.Button();
            this.Prebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAuthorList = new System.Windows.Forms.DataGridView();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "S e a r c h";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(140, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 4);
            this.label8.TabIndex = 52;
            // 
            // txtboxAuthorSearch
            // 
            this.txtboxAuthorSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxAuthorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAuthorSearch.Location = new System.Drawing.Point(140, 9);
            this.txtboxAuthorSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxAuthorSearch.Name = "txtboxAuthorSearch";
            this.txtboxAuthorSearch.Size = new System.Drawing.Size(197, 23);
            this.txtboxAuthorSearch.TabIndex = 51;
            // 
            // Afterbutton
            // 
            this.Afterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Afterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afterbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afterbutton.ForeColor = System.Drawing.Color.White;
            this.Afterbutton.Location = new System.Drawing.Point(355, 439);
            this.Afterbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Afterbutton.Name = "Afterbutton";
            this.Afterbutton.Size = new System.Drawing.Size(53, 32);
            this.Afterbutton.TabIndex = 50;
            this.Afterbutton.Text = ">";
            this.Afterbutton.UseVisualStyleBackColor = false;
            this.Afterbutton.Click += new System.EventHandler(this.Afterbutton_Click);
            // 
            // Prebutton
            // 
            this.Prebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Prebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prebutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prebutton.ForeColor = System.Drawing.Color.White;
            this.Prebutton.Location = new System.Drawing.Point(257, 441);
            this.Prebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prebutton.Name = "Prebutton";
            this.Prebutton.Size = new System.Drawing.Size(53, 32);
            this.Prebutton.TabIndex = 49;
            this.Prebutton.Text = "<";
            this.Prebutton.UseVisualStyleBackColor = false;
            this.Prebutton.Click += new System.EventHandler(this.Prebutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(645, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvAuthorList
            // 
            this.dgvAuthorList.AllowUserToAddRows = false;
            this.dgvAuthorList.AllowUserToDeleteRows = false;
            this.dgvAuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookTitle,
            this.ID,
            this.AuthorLastName,
            this.AuthorBirthDate});
            this.dgvAuthorList.Location = new System.Drawing.Point(1, 110);
            this.dgvAuthorList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAuthorList.Name = "dgvAuthorList";
            this.dgvAuthorList.ReadOnly = true;
            this.dgvAuthorList.Size = new System.Drawing.Size(679, 309);
            this.dgvAuthorList.TabIndex = 47;
            this.dgvAuthorList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAuthorList_RowHeaderMouseClick);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(475, 62);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(125, 38);
            this.Updatebutton.TabIndex = 46;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click_1);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(277, 62);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(125, 38);
            this.Deletebutton.TabIndex = 45;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(75, 62);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 38);
            this.AddButton.TabIndex = 44;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "AuthorFirstName";
            this.BookTitle.HeaderText = "Author FirstName";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "AuthorID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // AuthorLastName
            // 
            this.AuthorLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorLastName.DataPropertyName = "AuthorLastName";
            this.AuthorLastName.HeaderText = "Author LastName";
            this.AuthorLastName.Name = "AuthorLastName";
            this.AuthorLastName.ReadOnly = true;
            // 
            // AuthorBirthDate
            // 
            this.AuthorBirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorBirthDate.DataPropertyName = "AuthorBirthDate";
            this.AuthorBirthDate.HeaderText = "BirthDate";
            this.AuthorBirthDate.Name = "AuthorBirthDate";
            this.AuthorBirthDate.ReadOnly = true;
            // 
            // AuthorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxAuthorSearch);
            this.Controls.Add(this.Afterbutton);
            this.Controls.Add(this.Prebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAuthorList);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthorsPage";
            this.Size = new System.Drawing.Size(683, 473);
            this.Load += new System.EventHandler(this.AuthorsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxAuthorSearch;
        private System.Windows.Forms.Button Afterbutton;
        private System.Windows.Forms.Button Prebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAuthorList;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBirthDate;
    }
}
