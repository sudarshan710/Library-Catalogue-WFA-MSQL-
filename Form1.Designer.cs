namespace Library_Catalogue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bookTxt = new TextBox();
            authorTxt = new TextBox();
            genreTxt = new TextBox();
            dateTxt = new TextBox();
            Insert = new Button();
            Update = new Button();
            Delete = new Button();
            Reset = new Button();
            bookList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bookList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
            label1.TabIndex = 0;
            label1.Text = "Book : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(410, 23);
            label2.Name = "label2";
            label2.Size = new Size(122, 35);
            label2.TabIndex = 0;
            label2.Text = "Author : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 58);
            label3.Name = "label3";
            label3.Size = new Size(110, 35);
            label3.TabIndex = 0;
            label3.Text = "Genre : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(410, 67);
            label4.Name = "label4";
            label4.Size = new Size(222, 35);
            label4.TabIndex = 0;
            label4.Text = "Published Date :";
            // 
            // bookTxt
            // 
            bookTxt.BackColor = SystemColors.AppWorkspace;
            bookTxt.Location = new Point(118, 23);
            bookTxt.Multiline = true;
            bookTxt.Name = "bookTxt";
            bookTxt.Size = new Size(280, 32);
            bookTxt.TabIndex = 1;
            // 
            // authorTxt
            // 
            authorTxt.BackColor = SystemColors.AppWorkspace;
            authorTxt.Location = new Point(638, 32);
            authorTxt.Multiline = true;
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(280, 32);
            authorTxt.TabIndex = 1;
            // 
            // genreTxt
            // 
            genreTxt.BackColor = SystemColors.AppWorkspace;
            genreTxt.Location = new Point(118, 67);
            genreTxt.Multiline = true;
            genreTxt.Name = "genreTxt";
            genreTxt.Size = new Size(280, 32);
            genreTxt.TabIndex = 1;
            // 
            // dateTxt
            // 
            dateTxt.BackColor = SystemColors.AppWorkspace;
            dateTxt.Location = new Point(638, 70);
            dateTxt.Multiline = true;
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(280, 32);
            dateTxt.TabIndex = 1;
            // 
            // Insert
            // 
            Insert.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Insert.Location = new Point(52, 123);
            Insert.Name = "Insert";
            Insert.Size = new Size(134, 53);
            Insert.TabIndex = 2;
            Insert.Text = "Insert";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Update.Location = new Point(293, 123);
            Update.Name = "Update";
            Update.Size = new Size(134, 53);
            Update.TabIndex = 2;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Delete.Location = new Point(524, 123);
            Delete.Name = "Delete";
            Delete.Size = new Size(134, 53);
            Delete.TabIndex = 2;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Reset
            // 
            Reset.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.Location = new Point(760, 123);
            Reset.Name = "Reset";
            Reset.Size = new Size(134, 53);
            Reset.TabIndex = 2;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // bookList
            // 
            bookList.AllowUserToAddRows = false;
            bookList.AllowUserToDeleteRows = false;
            bookList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookList.ColumnHeadersHeight = 29;
            bookList.EditMode = DataGridViewEditMode.EditProgrammatically;
            bookList.Location = new Point(12, 198);
            bookList.Name = "bookList";
            bookList.RowHeadersWidth = 51;
            bookList.RowTemplate.Height = 29;
            bookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookList.ShowEditingIcon = false;
            bookList.Size = new Size(916, 330);
            bookList.TabIndex = 3;
            bookList.CellClick += bookList_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(956, 558);
            Controls.Add(bookList);
            Controls.Add(Reset);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Insert);
            Controls.Add(dateTxt);
            Controls.Add(genreTxt);
            Controls.Add(authorTxt);
            Controls.Add(bookTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(974, 605);
            MinimumSize = new Size(974, 605);
            Name = "Form1";
            Text = "Library Catalogue";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox bookTxt;
        private TextBox authorTxt;
        private TextBox genreTxt;
        private TextBox dateTxt;
        private Button Insert;
        private Button Update;
        private Button Delete;
        private Button Reset;
        private DataGridView bookList;
    }
}