using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool isRunning = true;
            int choice;

            while (isRunning)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search Book By Id");
                Console.WriteLine("4. Search Book By Title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Book book = new Book();
                            Console.Write("Enter Book Id: ");
                            book.BookId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Book Title: ");
                            book.Title = Console.ReadLine();
                            Console.Write("Enter Book Author: ");
                            book.Author = Console.ReadLine();
                            Console.Write("Enter Book Genre: ");
                            book.Genre = Console.ReadLine();
                            Console.Write("Is the book available? (y/n): ");
                            book.IsAvailable = Console.ReadLine().ToLower() == "y";
                            library.AddBook(book);
                            break;
                        }
                    case 2:
                        {
                            library.ViewAllBooks();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter Book Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Book book = library.SearchBookById(id);
                            if (book != null)
                            {
                                Console.WriteLine($"Book Found:\n{book.BookId}\t{book.Title}\t{book.Author}\t{book.Genre}\t{book.IsAvailable}");
                            }
                            else
                            {
                                Console.WriteLine("No book found with the specified ID.");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter Book Title: ");
                            string title = Console.ReadLine();
                            Book book = library.SearchBookByTitle(title);
                            if (book != null)
                            {
                                Console.WriteLine($"Book Found:\n{book.BookId}\t{book.Title}\t{book.Author}\t{book.Genre}\t{book.IsAvailable}");
                            }
                            else
                            {
                                Console.WriteLine("No book found with the specified title.");
                            }
                            break;
                        }
                    case 5:
                        {
                            isRunning = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice. Please enter a valid choice.");
                            break;
                        }
                }
            }
        }
    }
}

