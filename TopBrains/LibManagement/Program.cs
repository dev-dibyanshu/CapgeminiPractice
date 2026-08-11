using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Some initial books
        library.AddBook(new Book
        {
            BookId = 1,
            Name = "C# Programming",
            Publisher = "Microsoft Press",
            Price = 750
        });

        library.AddBook(new Book
        {
            BookId = 2,
            Name = "Clean Code",
            Publisher = "Prentice Hall",
            Price = 900
        });

        library.AddBook(new Book
        {
            BookId = 3,
            Name = "ASP.NET Core",
            Publisher = "Packt",
            Price = 650
        });

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       BOOK LIBRARY SYSTEM");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.WriteLine("=================================");

            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AdminMenu(library);
                    break;

                case "2":
                    UserMenu(library);
                    break;

                case "3":
                    Console.WriteLine("Thank you for using the Library System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // ============================
    // ADMIN MENU
    // ============================

    static void AdminMenu(Library library)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("========== ADMIN MENU ==========");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Books");
            Console.WriteLine("5. Back");
            Console.WriteLine("===============================");

            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook(library);
                    break;

                case "2":
                    UpdateBook(library);
                    break;

                case "3":
                    DeleteBook(library);
                    break;

                case "4":
                    library.ViewAllBooks();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // ============================
    // USER MENU
    // ============================

    static void UserMenu(Library library)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=========== USER MENU ==========");
            Console.WriteLine("1. Browse All Books");
            Console.WriteLine("2. Search Book By Name");
            Console.WriteLine("3. Search Book By Publisher");
            Console.WriteLine("4. View Highest Priced Book");
            Console.WriteLine("5. View Lowest Priced Book");
            Console.WriteLine("6. Back");
            Console.WriteLine("===============================");

            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    library.ViewAllBooks();
                    break;

                case "2":
                    Console.Write("Enter book name: ");

                    string name = Console.ReadLine();

                    library.SearchByName(name);

                    break;

                case "3":
                    Console.Write("Enter publisher name: ");

                    string publisher = Console.ReadLine();

                    library.SearchByPublisher(publisher);

                    break;

                case "4":
                    library.GetHighestPricedBook();
                    break;

                case "5":
                    library.GetLowestPricedBook();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // ============================
    // ADD BOOK
    // ============================

    static void AddBook(Library library)
    {
        Console.Write("Enter Book ID: ");

        int bookId;

        while (!int.TryParse(Console.ReadLine(), out bookId))
        {
            Console.Write("Invalid ID. Enter again: ");
        }

        Console.Write("Enter Book Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Publisher: ");
        string publisher = Console.ReadLine();

        Console.Write("Enter Price: ");

        double price;

        while (!double.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.Write("Invalid price. Enter again: ");
        }

        Book book = new Book
        {
            BookId = bookId,
            Name = name,
            Publisher = publisher,
            Price = price
        };

        library.AddBook(book);
    }

    // ============================
    // UPDATE BOOK
    // ============================

    static void UpdateBook(Library library)
    {
        Console.Write("Enter Book ID to update: ");

        int bookId;

        while (!int.TryParse(Console.ReadLine(), out bookId))
        {
            Console.Write("Invalid ID. Enter again: ");
        }

        Console.Write("Enter new Book Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter new Publisher: ");
        string publisher = Console.ReadLine();

        Console.Write("Enter new Price: ");

        double price;

        while (!double.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.Write("Invalid price. Enter again: ");
        }

        library.UpdateBook(
            bookId,
            name,
            publisher,
            price);
    }

    // ============================
    // DELETE BOOK
    // ============================

    static void DeleteBook(Library library)
    {
        Console.Write("Enter Book ID to delete: ");

        int bookId;

        while (!int.TryParse(Console.ReadLine(), out bookId))
        {
            Console.Write("Invalid ID. Enter again: ");
        }

        library.DeleteBook(bookId);
    }
}