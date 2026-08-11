using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books = new List<Book>();

    // ADD
    public void AddBook(Book book)
    {
        books.Add(book);

        Console.WriteLine("Book added successfully.");
    }

    // VIEW ALL
    public void ViewAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Console.WriteLine("\n----- ALL BOOKS -----");

        foreach (Book book in books)
        {
            DisplayBook(book);
        }
    }

    // UPDATE
    public void UpdateBook(int bookId, string name, string publisher, double price)
    {
        Book book = books.Find(b => b.BookId == bookId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        book.Name = name;
        book.Publisher = publisher;
        book.Price = price;

        Console.WriteLine("Book updated successfully.");
    }

    // DELETE
    public void DeleteBook(int bookId)
    {
        Book book = books.Find(b => b.BookId == bookId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        books.Remove(book);

        Console.WriteLine("Book deleted successfully.");
    }

    // SEARCH BY NAME
    public void SearchByName(string name)
    {
        bool found = false;

        Console.WriteLine("\n----- SEARCH RESULTS -----");

        foreach (Book book in books)
        {
            if (book.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(book);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching books found.");
        }
    }

    // SEARCH BY PUBLISHER
    public void SearchByPublisher(string publisher)
    {
        bool found = false;

        Console.WriteLine("\n----- SEARCH RESULTS -----");

        foreach (Book book in books)
        {
            if (book.Publisher.Contains(
                publisher,
                StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(book);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching books found.");
        }
    }

    // HIGHEST PRICE
    public void GetHighestPricedBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Book highest = books[0];

        foreach (Book book in books)
        {
            if (book.Price > highest.Price)
            {
                highest = book;
            }
        }

        Console.WriteLine("\n----- HIGHEST PRICED BOOK -----");

        DisplayBook(highest);
    }

    // LOWEST PRICE
    public void GetLowestPricedBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Book lowest = books[0];

        foreach (Book book in books)
        {
            if (book.Price < lowest.Price)
            {
                lowest = book;
            }
        }

        Console.WriteLine("\n----- LOWEST PRICED BOOK -----");

        DisplayBook(lowest);
    }

    // DISPLAY BOOK USING dynamic
    private void DisplayBook(Book book)
    {
        dynamic dynamicBook = book;

        Console.WriteLine(
            $"ID: {dynamicBook.BookId}, " +
            $"Name: {dynamicBook.Name}, " +
            $"Publisher: {dynamicBook.Publisher}, " +
            $"Price: {dynamicBook.Price}");
    }
}