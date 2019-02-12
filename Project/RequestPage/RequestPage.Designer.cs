namespace Project
{
    partial class RequestPage
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
            this.txtboxRequestSearch = new System.Windows.Forms.TextBox();
            this.Afterbutton = new System.Windows.Forms.Button();
            this.Prebutton = new System.Windows.Forms.Button();
            this.Closelabel = new System.Windows.Forms.Label();
            this.Rejectbutton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Historybutton = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "S e a r c h";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(139, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 4);
            this.label8.TabIndex = 62;
            // 
            // txtboxRequestSearch
            // 
            this.txtboxRequestSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRequestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRequestSearch.Location = new System.Drawing.Point(139, 10);
            this.txtboxRequestSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxRequestSearch.Name = "txtboxRequestSearch";
            this.txtboxRequestSearch.Size = new System.Drawing.Size(198, 23);
            this.txtboxRequestSearch.TabIndex = 61;
            this.txtboxRequestSearch.TextChanged += new System.EventHandler(this.txtboxAuthorSearch_TextChanged);
            // 
            // Afterbutton
            // 
            this.Afterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Afterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afterbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afterbutton.ForeColor = System.Drawing.Color.White;
            this.Afterbutton.Location = new System.Drawing.Point(353, 440);
            this.Afterbutton.Name = "Afterbutton";
            this.Afterbutton.Size = new System.Drawing.Size(54, 32);
            this.Afterbutton.TabIndex = 60;
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
            this.Prebutton.Location = new System.Drawing.Point(256, 441);
            this.Prebutton.Name = "Prebutton";
            this.Prebutton.Size = new System.Drawing.Size(54, 32);
            this.Prebutton.TabIndex = 59;
            this.Prebutton.Text = "<";
            this.Prebutton.UseVisualStyleBackColor = false;
            this.Prebutton.Click += new System.EventHandler(this.Prebutton_Click);
            // 
            // Closelabel
            // 
            this.Closelabel.AutoSize = true;
            this.Closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.Closelabel.Location = new System.Drawing.Point(644, 1);
            this.Closelabel.Name = "Closelabel";
            this.Closelabel.Size = new System.Drawing.Size(30, 29);
            this.Closelabel.TabIndex = 58;
            this.Closelabel.Text = "X";
            this.Closelabel.Click += new System.EventHandler(this.Closelabel_Click);
            // 
            // Rejectbutton
            // 
            this.Rejectbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Rejectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rejectbutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejectbutton.ForeColor = System.Drawing.Color.White;
            this.Rejectbutton.Location = new System.Drawing.Point(276, 63);
            this.Rejectbutton.Name = "Rejectbutton";
            this.Rejectbutton.Size = new System.Drawing.Size(125, 38);
            this.Rejectbutton.TabIndex = 55;
            this.Rejectbutton.Text = "Reject";
            this.Rejectbutton.UseVisualStyleBackColor = false;
            this.Rejectbutton.Click += new System.EventHandler(this.Rejectbutton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(73, 63);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(125, 38);
            this.AcceptButton.TabIndex = 54;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Historybutton
            // 
            this.Historybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.Historybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Historybutton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historybutton.ForeColor = System.Drawing.Color.White;
            this.Historybutton.Location = new System.Drawing.Point(447, 63);
            this.Historybutton.Name = "Historybutton";
            this.Historybutton.Size = new System.Drawing.Size(125, 38);
            this.Historybutton.TabIndex = 65;
            this.Historybutton.Text = "All Request";
            this.Historybutton.UseVisualStyleBackColor = false;
            this.Historybutton.Click += new System.EventHandler(this.Historybutton_Click);
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
            this.dgvRequestList.Location = new System.Drawing.Point(4, 124);
            this.dgvRequestList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRequestList.Name = "dgvRequestList";
            this.dgvRequestList.ReadOnly = true;
            this.dgvRequestList.Size = new System.Drawing.Size(679, 309);
            this.dgvRequestList.TabIndex = 66;
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
            this.RequestStatus.HeaderText = "Request Status";
            this.RequestStatus.Name = "RequestStatus";
            this.RequestStatus.ReadOnly = true;
            this.RequestStatus.Visible = false;
            // 
            // RequestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvRequestList);
            this.Controls.Add(this.Historybutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxRequestSearch);
            this.Controls.Add(this.Afterbutton);
            this.Controls.Add(this.Prebutton);
            this.Controls.Add(this.Closelabel);
            this.Controls.Add(this.Rejectbutton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "RequestPage";
            this.Size = new System.Drawing.Size(683, 481);
            this.Load += new System.EventHandler(this.Reject_Load);
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
        private System.Windows.Forms.Label Closelabel;
        private System.Windows.Forms.Button Rejectbutton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button Historybutton;
        private System.Windows.Forms.DataGridView dgvRequestList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestStatus;
    }
}
