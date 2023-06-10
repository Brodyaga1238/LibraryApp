namespace LibraryDesktopApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.tbReaderName = new System.Windows.Forms.TextBox();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.lbReaders = new System.Windows.Forms.ListBox();
            this.lblReaders = new System.Windows.Forms.Label();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.lbIssuedBooks = new System.Windows.Forms.ListBox();
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lbReturnedBooks = new System.Windows.Forms.ListBox();
            this.lblReturnedBooks = new System.Windows.Forms.Label();
            this.btnGetAllBooks = new System.Windows.Forms.Button();
            this.btnGetAllReaders = new System.Windows.Forms.Button();
            this.btnGetIssuedBooks = new System.Windows.Forms.Button();
            this.btnGetReturnedBooks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Beige;
            this.btnAddBook.Location = new System.Drawing.Point(12, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 23);
            this.btnAddBook.TabIndex = 21;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(138, 14);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(150, 20);
            this.tbBookTitle.TabIndex = 20;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(138, 40);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(150, 20);
            this.tbBookAuthor.TabIndex = 19;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(294, 17);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(57, 13);
            this.lblBookTitle.TabIndex = 18;
            this.lblBookTitle.Text = "Название";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(294, 43);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(37, 13);
            this.lblBookAuthor.TabIndex = 17;
            this.lblBookAuthor.Text = "Автор";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(12, 87);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(400, 95);
            this.lbBooks.TabIndex = 16;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(12, 71);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(37, 13);
            this.lblBooks.TabIndex = 15;
            this.lblBooks.Text = "Книги";
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = System.Drawing.Color.Beige;
            this.btnAddReader.Location = new System.Drawing.Point(413, 11);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(150, 23);
            this.btnAddReader.TabIndex = 14;
            this.btnAddReader.Text = "Добавить читателя";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // tbReaderName
            // 
            this.tbReaderName.Location = new System.Drawing.Point(569, 15);
            this.tbReaderName.Name = "tbReaderName";
            this.tbReaderName.Size = new System.Drawing.Size(150, 20);
            this.tbReaderName.TabIndex = 13;
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Location = new System.Drawing.Point(734, 22);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(29, 13);
            this.lblReaderName.TabIndex = 12;
            this.lblReaderName.Text = "Имя";
            // 
            // lbReaders
            // 
            this.lbReaders.FormattingEnabled = true;
            this.lbReaders.Location = new System.Drawing.Point(418, 87);
            this.lbReaders.Name = "lbReaders";
            this.lbReaders.Size = new System.Drawing.Size(400, 95);
            this.lbReaders.TabIndex = 11;
            // 
            // lblReaders
            // 
            this.lblReaders.AutoSize = true;
            this.lblReaders.Location = new System.Drawing.Point(418, 71);
            this.lblReaders.Name = "lblReaders";
            this.lblReaders.Size = new System.Drawing.Size(55, 13);
            this.lblReaders.TabIndex = 10;
            this.lblReaders.Text = "Читатели";
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.Beige;
            this.btnIssueBook.Location = new System.Drawing.Point(12, 188);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(150, 23);
            this.btnIssueBook.TabIndex = 9;
            this.btnIssueBook.Text = "Выдать книгу";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // lbIssuedBooks
            // 
            this.lbIssuedBooks.FormattingEnabled = true;
            this.lbIssuedBooks.Location = new System.Drawing.Point(12, 241);
            this.lbIssuedBooks.Name = "lbIssuedBooks";
            this.lbIssuedBooks.Size = new System.Drawing.Size(400, 95);
            this.lbIssuedBooks.TabIndex = 8;
            // 
            // lblIssuedBooks
            // 
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Location = new System.Drawing.Point(12, 225);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(92, 13);
            this.lblIssuedBooks.TabIndex = 7;
            this.lblIssuedBooks.Text = "Выданные книги";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.Beige;
            this.btnReturnBook.Location = new System.Drawing.Point(418, 188);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(150, 23);
            this.btnReturnBook.TabIndex = 6;
            this.btnReturnBook.Text = "Вернуть книгу";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lbReturnedBooks
            // 
            this.lbReturnedBooks.FormattingEnabled = true;
            this.lbReturnedBooks.Location = new System.Drawing.Point(418, 241);
            this.lbReturnedBooks.Name = "lbReturnedBooks";
            this.lbReturnedBooks.Size = new System.Drawing.Size(400, 95);
            this.lbReturnedBooks.TabIndex = 5;
            // 
            // lblReturnedBooks
            // 
            this.lblReturnedBooks.AutoSize = true;
            this.lblReturnedBooks.Location = new System.Drawing.Point(418, 225);
            this.lblReturnedBooks.Name = "lblReturnedBooks";
            this.lblReturnedBooks.Size = new System.Drawing.Size(117, 13);
            this.lblReturnedBooks.TabIndex = 4;
            this.lblReturnedBooks.Text = "Возвращенные книги";
            // 
            // btnGetAllBooks
            // 
            this.btnGetAllBooks.BackColor = System.Drawing.Color.Beige;
            this.btnGetAllBooks.Location = new System.Drawing.Point(12, 342);
            this.btnGetAllBooks.Name = "btnGetAllBooks";
            this.btnGetAllBooks.Size = new System.Drawing.Size(306, 23);
            this.btnGetAllBooks.TabIndex = 3;
            this.btnGetAllBooks.Text = "Получить список всех книг";
            this.btnGetAllBooks.UseVisualStyleBackColor = false;
            this.btnGetAllBooks.Click += new System.EventHandler(this.btnGetAllBooks_Click);
            // 
            // btnGetAllReaders
            // 
            this.btnGetAllReaders.BackColor = System.Drawing.Color.Beige;
            this.btnGetAllReaders.Location = new System.Drawing.Point(12, 371);
            this.btnGetAllReaders.Name = "btnGetAllReaders";
            this.btnGetAllReaders.Size = new System.Drawing.Size(306, 23);
            this.btnGetAllReaders.TabIndex = 2;
            this.btnGetAllReaders.Text = "Получить список всех читателей\r\n";
            this.btnGetAllReaders.UseVisualStyleBackColor = false;
            this.btnGetAllReaders.Click += new System.EventHandler(this.btnGetAllReaders_Click);
            // 
            // btnGetIssuedBooks
            // 
            this.btnGetIssuedBooks.BackColor = System.Drawing.Color.Beige;
            this.btnGetIssuedBooks.Location = new System.Drawing.Point(418, 342);
            this.btnGetIssuedBooks.Name = "btnGetIssuedBooks";
            this.btnGetIssuedBooks.Size = new System.Drawing.Size(306, 23);
            this.btnGetIssuedBooks.TabIndex = 1;
            this.btnGetIssuedBooks.Text = "Получить список выданных книг";
            this.btnGetIssuedBooks.UseVisualStyleBackColor = false;
            this.btnGetIssuedBooks.Click += new System.EventHandler(this.btnGetIssuedBooks_Click);
            // 
            // btnGetReturnedBooks
            // 
            this.btnGetReturnedBooks.BackColor = System.Drawing.Color.Beige;
            this.btnGetReturnedBooks.Location = new System.Drawing.Point(418, 371);
            this.btnGetReturnedBooks.Name = "btnGetReturnedBooks";
            this.btnGetReturnedBooks.Size = new System.Drawing.Size(306, 23);
            this.btnGetReturnedBooks.TabIndex = 0;
            this.btnGetReturnedBooks.Text = "Получить список возвращённых книг\r\n";
            this.btnGetReturnedBooks.UseVisualStyleBackColor = false;
            this.btnGetReturnedBooks.Click += new System.EventHandler(this.btnGetReturnedBooks_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(734, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 52);
            this.button1.TabIndex = 22;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EndProgramClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetReturnedBooks);
            this.Controls.Add(this.btnGetIssuedBooks);
            this.Controls.Add(this.btnGetAllReaders);
            this.Controls.Add(this.btnGetAllBooks);
            this.Controls.Add(this.lblReturnedBooks);
            this.Controls.Add(this.lbReturnedBooks);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lblIssuedBooks);
            this.Controls.Add(this.lbIssuedBooks);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.lblReaders);
            this.Controls.Add(this.lbReaders);
            this.Controls.Add(this.lblReaderName);
            this.Controls.Add(this.tbReaderName);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.tbBookTitle);
            this.Controls.Add(this.btnAddBook);
            this.Name = "Form1";
            this.Text = "Library Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.TextBox tbReaderName;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.ListBox lbReaders;
        private System.Windows.Forms.Label lblReaders;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.ListBox lbIssuedBooks;
        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.ListBox lbReturnedBooks;
        private System.Windows.Forms.Label lblReturnedBooks;
        private System.Windows.Forms.Button btnGetAllBooks;
        private System.Windows.Forms.Button btnGetAllReaders;
        private System.Windows.Forms.Button btnGetIssuedBooks;
        private System.Windows.Forms.Button btnGetReturnedBooks;
    }
}