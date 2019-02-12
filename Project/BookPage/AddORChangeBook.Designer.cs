namespace Project
{
    partial class AddORChangeBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxBookTitle = new System.Windows.Forms.TextBox();
            this.txtBoxPublishHouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorcomboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.AddAuthor1 = new System.Windows.Forms.Button();
            this.bindingSourceBooks = new System.Windows.Forms.BindingSource(this.components);
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(133, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 3);
            this.label12.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(133, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 3);
            this.label10.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(133, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 3);
            this.label9.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(133, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 3);
            this.label8.TabIndex = 40;
            // 
            // txtboxBookTitle
            // 
            this.txtboxBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBookTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceBooks, "BookName", true));
            this.txtboxBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBookTitle.Location = new System.Drawing.Point(133, 18);
            this.txtboxBookTitle.Name = "txtboxBookTitle";
            this.txtboxBookTitle.Size = new System.Drawing.Size(160, 19);
            this.txtboxBookTitle.TabIndex = 37;
            this.txtboxBookTitle.TextChanged += new System.EventHandler(this.txtboxBookTitle_TextChanged);
            // 
            // txtBoxPublishHouse
            // 
            this.txtBoxPublishHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPublishHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceBooks, "BookPublishHouse", true));
            this.txtBoxPublishHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPublishHouse.Location = new System.Drawing.Point(133, 162);
            this.txtBoxPublishHouse.Name = "txtBoxPublishHouse";
            this.txtBoxPublishHouse.Size = new System.Drawing.Size(160, 19);
            this.txtBoxPublishHouse.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(43, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Author :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "publish House :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(43, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Release Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Book Title:";
            // 
            // AuthorcomboBox
            // 
            this.AuthorcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceBooks, "BookAuthorID", true));
            this.AuthorcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorcomboBox.FormattingEnabled = true;
            this.AuthorcomboBox.Location = new System.Drawing.Point(133, 118);
            this.AuthorcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthorcomboBox.Name = "AuthorcomboBox";
            this.AuthorcomboBox.Size = new System.Drawing.Size(161, 21);
            this.AuthorcomboBox.TabIndex = 45;
            this.AuthorcomboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorcomboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(120, 235);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 31);
            this.AddButton.TabIndex = 46;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ExitLabel.Location = new System.Drawing.Point(358, 9);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 24);
            this.ExitLabel.TabIndex = 47;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.CustomFormat = "YYYY-MM-DD";
            this.dateTimePickerReleaseDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceBooks, "BookReleaseDate", true));
            this.dateTimePickerReleaseDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceBooks, "BookReleaseDate", true));
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(133, 74);
            this.dateTimePickerReleaseDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerReleaseDate.TabIndex = 48;
            // 
            // AddAuthor1
            // 
            this.AddAuthor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.AddAuthor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAuthor1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthor1.ForeColor = System.Drawing.Color.White;
            this.AddAuthor1.Location = new System.Drawing.Point(311, 119);
            this.AddAuthor1.Margin = new System.Windows.Forms.Padding(2);
            this.AddAuthor1.Name = "AddAuthor1";
            this.AddAuthor1.Size = new System.Drawing.Size(37, 27);
            this.AddAuthor1.TabIndex = 49;
            this.AddAuthor1.Text = "+";
            this.AddAuthor1.UseVisualStyleBackColor = false;
            this.AddAuthor1.Click += new System.EventHandler(this.AddAuthor1_Click);
            // 
            // bindingSourceBooks
            // 
            this.bindingSourceBooks.DataSource = typeof(Project.Book);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(Project.Author);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Project.Book);
            // 
            // AddORChangeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 286);
            this.Controls.Add(this.AddAuthor1);
            this.Controls.Add(this.dateTimePickerReleaseDate);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AuthorcomboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxBookTitle);
            this.Controls.Add(this.txtBoxPublishHouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddORChangeBook";
            this.Text = "AddORChangeBook";
            this.Load += new System.EventHandler(this.AddORChangeBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxBookTitle;
        private System.Windows.Forms.TextBox txtBoxPublishHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AuthorcomboBox;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.BindingSource bindingSourceBooks;
        private System.Windows.Forms.Button AddAuthor1;
    }
}