using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    public class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

    }

    public class LibraryBookService
    {
        private List<LibraryBook> books = new List<LibraryBook>();
        public void AddBook(LibraryBook book)
        {
            // Logic to add a book to the library
            books.Add(book);
            Console.WriteLine("Book added to the library: " + book.Title);
        }
        public void RemoveBook(int isbn)
        {
            // Logic to remove a book from the library
            LibraryBook removeBook = books.Find(b => b.ISBN == isbn);
            if (removeBook != null)
            {
                books.Remove(removeBook);
                Console.WriteLine("Book removed from the library: " + removeBook.Title);
            }
            else
            {
                Console.WriteLine("Book not found with ISBN: " + isbn);
            }
        }
    }
    public class LibraryBookDisplay
    {
        public void DisplayBookDetails(LibraryBook book)
        {
            // Logic to display book details
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("ISBN: " + book.ISBN);
        }
    }
    public class LibraryLogger
    {
        public void Log(string message)
        {
            // Logic to log messages related to library operations
            Console.WriteLine($"Log: {message}");
        }
    }



    internal class SRP_Example
    {
        public static void Main(string[] args)
        {
            LibraryBook book = new LibraryBook
            {
                Title = "The Great Gatsby",
                Author = "Boktiar",
                ISBN = 1234
            };

            LibraryLogger logger = new LibraryLogger();

            // Display book details
            LibraryBookDisplay display = new LibraryBookDisplay();
            display.DisplayBookDetails(book);

            // Add book to the library
            LibraryBookService bookService = new LibraryBookService();
            bookService.AddBook(book);
            logger.Log($"Added book: {book.Title} by {book.Author}");

            // Remove book from the library
            bookService.RemoveBook(book.ISBN);
            logger.Log($"Removed book: {book.Title} by {book.Author}");
            Console.ReadKey();

        }
    }
}
// book management from the logging responsibility