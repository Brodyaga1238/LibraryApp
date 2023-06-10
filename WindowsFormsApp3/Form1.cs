using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryDesktopApp
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true; // Флаг доступности книги

        public override string ToString()
        {
            return $"ID: {Id}, Название: {Title}, Автор: {Author}";
        }
    }

// Класс читателя
public class Reader
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public override string ToString()
    {
        return $"ID: {Id}, Имя: {Name}";
    }
}

// Класс выданных книг
public class IssuedBook
{
    public int Id { get; set; }
    public Book Book { get; set; }
    public Reader Reader { get; set; }
    public DateTime IssueDate { get; set; } = DateTime.Now; // Дата выдачи книги
    public DateTime ReturnDate { get; set; } // Дата возврата книги (если еще не вернули)

    public override string ToString()
    {
        return $"ID: {Id}, Книга: {Book.Title}, Читатель: {Reader.Name}, Дата выдачи: {IssueDate.ToShortDateString()}, Дата возврата: {(ReturnDate == default(DateTime) ? "еще не вернули" : ReturnDate.ToShortDateString())}";
    }
}

// Класс возвращенных книг
public class ReturnedBook
{
    public int Id { get; set; }
    public IssuedBook IssuedBook { get; set; }
    public DateTime ReturnDate { get; set; } = DateTime.Now; // Дата возврата книги

    public override string ToString()
    {
        return $"ID: {Id}, Книга: {IssuedBook.Book.Title}, Читатель: {IssuedBook.Reader.Name}, Дата возврата: {ReturnDate.ToShortDateString()}";
    }
}

// Класс библиотеки
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Reader> readers = new List<Reader>();
        private List<IssuedBook> issuedBooks = new List<IssuedBook>();
        private List<ReturnedBook> returnedBooks = new List<ReturnedBook>();

        // Добавление книги
        public void AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);
        }

        // Добавление читателя
        public void AddReader(Reader reader)
        {
            reader.Id = readers.Count + 1;
            readers.Add(reader);
        }

        // Выдача книги
        public void IssueBook(Book book, Reader reader)
        {
            if (!book.IsAvailable)
            {
                Console.WriteLine("Книга уже выдана");
                return;
            }

            book.IsAvailable = false;

            var issuedBook = new IssuedBook
            {
                Id = issuedBooks.Count + 1,
                Book = book,
                Reader = reader
            };

            issuedBooks.Add(issuedBook);

            Console.WriteLine($"Книга \"{book.Title}\" выдана читателю {reader.Name}");
        }

        // Возврат книги
        public void ReturnBook(IssuedBook issuedBook)
        {
            if (issuedBook.Book.IsAvailable)
            {
                Console.WriteLine("Книга уже в библиотеке");
                return;
            }

            issuedBook.Book.IsAvailable = true;

            var returnedBook = new ReturnedBook
            {
                Id = returnedBooks.Count + 1,
                IssuedBook = issuedBook
            };

            returnedBooks.Add(returnedBook);

            Console.WriteLine($"Книга \"{issuedBook.Book.Title}\" возвращена в библиотеку");
        }

        // Получение списка всех книг
        public List<Book> GetAllBooks()
        {
            return books;
        }

        // Получение списка всех читателей
        public List<Reader> GetAllReaders()
        {
            return readers;
        }

        // Получение списка выданных книг
        public List<IssuedBook> GetIssuedBooks()
        {
            return issuedBooks;
        }

        // Получение списка возвращенных книг
        public List<ReturnedBook> GetReturnedBooks()
        {
            return returnedBooks;
        }
        public string GetReaderNameByBook(Book book)
        {
            IssuedBook issuedBook = issuedBooks.FirstOrDefault(ib => ib.Book == book);
            if (issuedBook != null)
            {
                return issuedBook.Reader.Name;
            }
            return "Нет данных";
        }
    }

    public partial class Form1 : Form
{
    private Library library = new Library();

    public Form1()
    {
        InitializeComponent();
        library = new Library();
    }

    private void btnAddBook_Click(object sender, EventArgs e)
    {
        string title = tbBookTitle.Text;
        string author = tbBookAuthor.Text;

        if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
        {
            Book book = new Book { Title = title, Author = author };
            library.AddBook(book);
            MessageBox.Show("Книга добавлена");

            // Обновление списка книг
            UpdateBookList();
        }
        else
        {
            MessageBox.Show("Пожалуйста, заполните поля названия и автора книги");
        }
    }

    private void btnAddReader_Click(object sender, EventArgs e)
    {
        string name = tbReaderName.Text;

        if (!string.IsNullOrEmpty(name))
        {
            Reader reader = new Reader { Name = name };
            library.AddReader(reader);
            MessageBox.Show("Читатель добавлен");

            // Обновление списка читателей
            UpdateReaderList();
        }
        else
        {
            MessageBox.Show("Пожалуйста, введите имя читателя");
        }
    }

    private void btnIssueBook_Click(object sender, EventArgs e)
    {
        if (lbBooks.SelectedItem != null && lbReaders.SelectedItem != null)
        {
            Book book = (Book)lbBooks.SelectedItem;
            Reader reader = (Reader)lbReaders.SelectedItem;

            if (!book.IsAvailable)
            {
                MessageBox.Show($"Книга \"{book.Title}\" уже взята читателем {library.GetReaderNameByBook(book)}");
            }
            else
            {
                library.IssueBook(book, reader);
                book.IsAvailable = false;
                MessageBox.Show($"Книга \"{book.Title}\" выдана читателю {reader.Name}");

                // Обновление списка выданных книг
                UpdateIssuedBookList();
            }
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите книгу и читателя для выдачи");
        }
    }

    private void btnReturnBook_Click(object sender, EventArgs e)
    {
        if (lbIssuedBooks.SelectedItem != null)
        {
            IssuedBook issuedBook = (IssuedBook)lbIssuedBooks.SelectedItem;
            library.ReturnBook(issuedBook);
            MessageBox.Show($"Книга \"{issuedBook.Book.Title}\" возвращена в библиотеку");

            // Обновление списка возвращенных книг
            UpdateReturnedBookList();
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите выданную книгу для возврата");
        }
    }

    private void btnGetAllBooks_Click(object sender, EventArgs e)
    {
        // Обновление списка книг
        lbBooks.DataSource = null; // Очистка источника данных
        UpdateBookList();
    }

    private void btnGetAllReaders_Click(object sender, EventArgs e)
    {
        // Обновление списка читателей
        lbReaders.DataSource = null; // Очистка источника данных
        UpdateReaderList();
    }

    private void btnGetIssuedBooks_Click(object sender, EventArgs e)
    {
        // Обновление списка выданных книг
        lbIssuedBooks.DataSource = null; // Очистка источника данных
        UpdateIssuedBookList();
    }

    private void btnGetReturnedBooks_Click(object sender, EventArgs e)
    {
        // Обновление списка возвращенных книг
        lbReturnedBooks.DataSource = null; // Очистка источника данных
        UpdateReturnedBookList();
    }

    private void UpdateBookList()
    {
        List<Book> books = library.GetAllBooks();
        lbBooks.DataSource = books;
    }

    private void UpdateReaderList()
    {
        List<Reader> readers = library.GetAllReaders();
        lbReaders.DataSource = readers;
    }

    private void UpdateIssuedBookList()
    {
        List<IssuedBook> issuedBooks = library.GetIssuedBooks();

        if (issuedBooks.Count == 0)
        {
            lbIssuedBooks.DataSource = null;
            MessageBox.Show("Нет выданных книг");
        }
        else
        {
            lbIssuedBooks.DataSource = issuedBooks;
        }
    }

    private void UpdateReturnedBookList()
    {
        List<ReturnedBook> returnedBooks = library.GetReturnedBooks();
        lbReturnedBooks.DataSource = returnedBooks;
    }
    
}

}