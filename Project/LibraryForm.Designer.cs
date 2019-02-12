namespace Project
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.Authors_MyBooks_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.Requests_button = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Bookbutton = new System.Windows.Forms.Button();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.authorsPage1 = new Project.AuthorsPage();
            this.requestPage1 = new Project.RequestPage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authors_MyBooks_button
            // 
            this.Authors_MyBooks_button.FlatAppearance.BorderSize = 0;
            this.Authors_MyBooks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authors_MyBooks_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authors_MyBooks_button.ForeColor = System.Drawing.Color.White;
            this.Authors_MyBooks_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Authors_MyBooks_button.Location = new System.Drawing.Point(40, 132);
            this.Authors_MyBooks_button.Margin = new System.Windows.Forms.Padding(4);
            this.Authors_MyBooks_button.Name = "Authors_MyBooks_button";
            this.Authors_MyBooks_button.Size = new System.Drawing.Size(140, 66);
            this.Authors_MyBooks_button.TabIndex = 4;
            this.Authors_MyBooks_button.Text = "MyBooks";
            this.Authors_MyBooks_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Authors_MyBooks_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Authors_MyBooks_button.UseVisualStyleBackColor = true;
            this.Authors_MyBooks_button.Click += new System.EventHandler(this.Authors_MyBooks_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.Requests_button);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.Authors_MyBooks_button);
            this.panel1.Controls.Add(this.Bookbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 493);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 75);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(16, 471);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(263, 66);
            this.button7.TabIndex = 4;
            this.button7.Text = "       Customers";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Requests_button
            // 
            this.Requests_button.FlatAppearance.BorderSize = 0;
            this.Requests_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Requests_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requests_button.ForeColor = System.Drawing.Color.White;
            this.Requests_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Requests_button.Location = new System.Drawing.Point(40, 206);
            this.Requests_button.Margin = new System.Windows.Forms.Padding(4);
            this.Requests_button.Name = "Requests_button";
            this.Requests_button.Size = new System.Drawing.Size(140, 66);
            this.Requests_button.TabIndex = 4;
            this.Requests_button.Text = "Requests";
            this.Requests_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Requests_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Requests_button.UseVisualStyleBackColor = true;
            this.Requests_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(4, 672);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 42);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // Bookbutton
            // 
            this.Bookbutton.FlatAppearance.BorderSize = 0;
            this.Bookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bookbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookbutton.ForeColor = System.Drawing.Color.White;
            this.Bookbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bookbutton.Location = new System.Drawing.Point(40, 75);
            this.Bookbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Bookbutton.Name = "Bookbutton";
            this.Bookbutton.Size = new System.Drawing.Size(140, 66);
            this.Bookbutton.TabIndex = 4;
            this.Bookbutton.Text = "Books";
            this.Bookbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bookbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bookbutton.UseVisualStyleBackColor = true;
            this.Bookbutton.Click += new System.EventHandler(this.Bookbutton_Click_2);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.White;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ExitLabel.Location = new System.Drawing.Point(821, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(30, 29);
            this.ExitLabel.TabIndex = 13;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // myBookList1
            // 
        
            // authorsPage1
            // 
            this.authorsPage1.BackColor = System.Drawing.Color.White;
            this.authorsPage1.Location = new System.Drawing.Point(187, 3);
            this.authorsPage1.Name = "authorsPage1";
            this.authorsPage1.Size = new System.Drawing.Size(693, 490);
            this.authorsPage1.TabIndex = 15;
            this.authorsPage1.Load += new System.EventHandler(this.authorsPage1_Load);
            // 
            // requestPage1
            // 
            this.requestPage1.BackColor = System.Drawing.Color.White;
            this.requestPage1.Location = new System.Drawing.Point(187, -3);
            this.requestPage1.Name = "requestPage1";
            this.requestPage1.Size = new System.Drawing.Size(678, 493);
            this.requestPage1.TabIndex = 16;
            this.requestPage1.Load += new System.EventHandler(this.requestPage1_Load);
            // 
            // bookPage1
            // 
            this.bookPage1.Location = new System.Drawing.Point(187, 0);
            this.bookPage1.Name = "bookPage1";
            this.bookPage1.Size = new System.Drawing.Size(678, 493);
            this.bookPage1.TabIndex = 17;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 493);
            this.Controls.Add(this.bookPage1);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.requestPage1);
            this.Controls.Add(this.authorsPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authors_MyBooks_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Requests_button;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button Bookbutton;
        private System.Windows.Forms.Label ExitLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AuthorsPage authorsPage1;
        private RequestPage requestPage1;
        private BookPage bookPage1;
    }
}