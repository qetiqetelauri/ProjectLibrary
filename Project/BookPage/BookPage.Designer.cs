namespace Project
{
    partial class BookPage
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
            this.SendRequestbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxBookSearch = new System.Windows.Forms.TextBox();
            this.Afterbutton = new System.Windows.Forms.Button();
            this.Prebutton = new System.Windows.Forms.Button();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookrelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublishhouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookuserid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // SendRequestbutton
            // 
            this.SendRequestbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.SendRequestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendRequestbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequestbutton.ForeColor = System.Drawing.Color.White;
            this.SendRequestbutton.Location = new System.Drawing.Point(60, 41);
            this.SendRequestbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendRequestbutton.Name = "SendRequestbutton";
            this.SendRequestbutton.Size = new System.Drawing.Size(137, 31);
            this.SendRequestbutton.TabIndex = 53;
            this.SendRequestbutton.Text = "Send Request";
            this.SendRequestbutton.UseVisualStyleBackColor = false;
            this.SendRequestbutton.Click += new System.EventHandler(this.SendRequestbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(7, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "S e a r c h";
            // 
            // txtboxBookSearch
            // 
            this.txtboxBookSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBookSearch.Location = new System.Drawing.Point(108, 6);
            this.txtboxBookSearch.Name = "txtboxBookSearch";
            this.txtboxBookSearch.Size = new System.Drawing.Size(148, 19);
            this.txtboxBookSearch.TabIndex = 51;
            this.txtboxBookSearch.TextChanged += new System.EventHandler(this.txtboxBookSearch_TextChanged);
            // 
            // Afterbutton
            // 
            this.Afterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Afterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afterbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afterbutton.ForeColor = System.Drawing.Color.White;
            this.Afterbutton.Location = new System.Drawing.Point(270, 348);
            this.Afterbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Afterbutton.Name = "Afterbutton";
            this.Afterbutton.Size = new System.Drawing.Size(40, 26);
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
            this.Prebutton.Location = new System.Drawing.Point(197, 349);
            this.Prebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prebutton.Name = "Prebutton";
            this.Prebutton.Size = new System.Drawing.Size(40, 26);
            this.Prebutton.TabIndex = 49;
            this.Prebutton.Text = "<";
            this.Prebutton.UseVisualStyleBackColor = false;
            this.Prebutton.Click += new System.EventHandler(this.Prebutton_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookTitle,
            this.ID,
            this.bookrelease,
            this.AuthorFirstName,
            this.bookpublishhouse,
            this.bookuserid});
            this.dgvBookList.Location = new System.Drawing.Point(5, 80);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.Size = new System.Drawing.Size(509, 251);
            this.dgvBookList.TabIndex = 48;
            this.dgvBookList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBookList_RowHeaderMouseClick);
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "BookName";
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "BookID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // bookrelease
            // 
            this.bookrelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookrelease.DataPropertyName = "BookReleaseDate";
            this.bookrelease.HeaderText = "Release Date";
            this.bookrelease.Name = "bookrelease";
            this.bookrelease.ReadOnly = true;
            // 
            // AuthorFirstName
            // 
            this.AuthorFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorFirstName.DataPropertyName = "AuthorFirstName";
            this.AuthorFirstName.HeaderText = "AuthorFirstName";
            this.AuthorFirstName.Name = "AuthorFirstName";
            this.AuthorFirstName.ReadOnly = true;
            // 
            // bookpublishhouse
            // 
            this.bookpublishhouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookpublishhouse.DataPropertyName = "BookPublishHouse";
            this.bookpublishhouse.HeaderText = "Publish House";
            this.bookpublishhouse.Name = "bookpublishhouse";
            this.bookpublishhouse.ReadOnly = true;
            // 
            // bookuserid
            // 
            this.bookuserid.DataPropertyName = "BookUserID";
            this.bookuserid.HeaderText = "bookuserid";
            this.bookuserid.Name = "bookuserid";
            this.bookuserid.ReadOnly = true;
            this.bookuserid.Visible = false;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(360, 41);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(94, 31);
            this.Updatebutton.TabIndex = 47;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(212, 41);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 31);
            this.Deletebutton.TabIndex = 46;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ExitLabel.Location = new System.Drawing.Point(482, 2);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 45;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(85, 41);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 31);
            this.AddButton.TabIndex = 54;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(108, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 3);
            this.label8.TabIndex = 55;
            // 
            // BookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SendRequestbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxBookSearch);
            this.Controls.Add(this.Afterbutton);
            this.Controls.Add(this.Prebutton);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.ExitLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookPage";
            this.Size = new System.Drawing.Size(516, 380);
            this.Load += new System.EventHandler(this.BookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendRequestbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxBookSearch;
        private System.Windows.Forms.Button Afterbutton;
        private System.Windows.Forms.Button Prebutton;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookrelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublishhouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookuserid;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label8;
    }
}
