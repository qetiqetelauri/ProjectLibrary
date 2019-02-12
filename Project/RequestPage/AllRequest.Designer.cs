namespace Project
{
    partial class AllRequest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxRequestSearch = new System.Windows.Forms.TextBox();
            this.Afterbutton = new System.Windows.Forms.Button();
            this.Prebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.dgvRequestList = new System.Windows.Forms.DataGridView();
            this.UserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "S e a r c h";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(146, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 4);
            this.label8.TabIndex = 70;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtboxRequestSearch
            // 
            this.txtboxRequestSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRequestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRequestSearch.Location = new System.Drawing.Point(146, 18);
            this.txtboxRequestSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxRequestSearch.Name = "txtboxRequestSearch";
            this.txtboxRequestSearch.Size = new System.Drawing.Size(198, 23);
            this.txtboxRequestSearch.TabIndex = 69;
            this.txtboxRequestSearch.TextChanged += new System.EventHandler(this.txtboxRequestSearch_TextChanged);
            // 
            // Afterbutton
            // 
            this.Afterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Afterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afterbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afterbutton.ForeColor = System.Drawing.Color.White;
            this.Afterbutton.Location = new System.Drawing.Point(360, 448);
            this.Afterbutton.Name = "Afterbutton";
            this.Afterbutton.Size = new System.Drawing.Size(54, 32);
            this.Afterbutton.TabIndex = 68;
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
            this.Prebutton.Location = new System.Drawing.Point(263, 449);
            this.Prebutton.Name = "Prebutton";
            this.Prebutton.Size = new System.Drawing.Size(54, 32);
            this.Prebutton.TabIndex = 67;
            this.Prebutton.Text = "<";
            this.Prebutton.UseVisualStyleBackColor = false;
            this.Prebutton.Click += new System.EventHandler(this.Prebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(651, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(15, 74);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(125, 38);
            this.Deletebutton.TabIndex = 65;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // dgvRequestList
            // 
            this.dgvRequestList.AllowUserToAddRows = false;
            this.dgvRequestList.AllowUserToDeleteRows = false;
            this.dgvRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserFullName,
            this.ID,
            this.BookTitle,
            this.AuthorBirthDate,
            this.RequestStatus});
            this.dgvRequestList.Location = new System.Drawing.Point(2, 133);
            this.dgvRequestList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.ReadOnly = true;
            this.dgvRequestList.Size = new System.Drawing.Size(679, 309);
            this.dgvRequestList.TabIndex = 72;
            this.dgvRequestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestList_CellContentClick_1);
            this.dgvRequestList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequestList_RowHeaderMouseClick_1);
            // 
            // UserFullName
            // 
            this.UserFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserFullName.DataPropertyName = "UserFullName";
            this.UserFullName.HeaderText = "UserName";
            this.UserFullName.Name = "UserFullName";
            this.UserFullName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RequestID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "BookTitle";
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // AuthorBirthDate
            // 
            this.AuthorBirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorBirthDate.DataPropertyName = "RequestDate";
            this.AuthorBirthDate.HeaderText = "Date";
            this.AuthorBirthDate.Name = "AuthorBirthDate";
            this.AuthorBirthDate.ReadOnly = true;
            // 
            // RequestStatus
            // 
            this.RequestStatus.DataPropertyName = "RequestStatus";
            this.RequestStatus.HeaderText = "Request Status";
            this.RequestStatus.Name = "RequestStatus";
            this.RequestStatus.ReadOnly = true;
            // 
            // AllRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.Controls.Add(this.dgvRequestList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxRequestSearch);
            this.Controls.Add(this.Afterbutton);
            this.Controls.Add(this.Prebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllRequest";
            this.Text = "AllRequest";
            this.Load += new System.EventHandler(this.AllRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxRequestSearch;
        private System.Windows.Forms.Button Afterbutton;
        private System.Windows.Forms.Button Prebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.DataGridView dgvRequestList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestStatus;
    }
}