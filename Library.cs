using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("BookId\tTitle\t\tAuthor\t\tGenre\t\tIsAvailable");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.BookId}\t{book.Title}\t{book.Author}\t{book.Genre}\t{book.IsAvailable}");
            }
        }

        public Book SearchBookById(int id)
        {
            return Books.Find(book => book.BookId == id);
        }

        public Book SearchBookByTitle(string title)
        {
            return Books.Find(book => book.Title.ToLower() == title.ToLower());
        }
    }
}
