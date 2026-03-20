using static System.Reflection.Metadata.BlobBuilder;

namespace Collection_Assignment1_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create List
            List<Books> bookList = new List<Books>();

            // Add 10 Books
            bookList.Add(new Books(1, "C# Basics", 500, "Programming"));
            bookList.Add(new Books(2, "ASP.NET Core", 1200, "Programming"));
            bookList.Add(new Books(3, "Java Fundamentals", 900, "Programming"));
            bookList.Add(new Books(4, "Python Guide", 1500, "Programming"));
            bookList.Add(new Books(5, "Data Science", 2000, "AI"));
            bookList.Add(new Books(6, "Machine Learning", 2500, "AI"));
            bookList.Add(new Books(7, "SQL Mastery", 800, "Database"));
            bookList.Add(new Books(8, "Cloud Computing", 1800, "Cloud"));
            bookList.Add(new Books(9, "Networking Basics", 700, "Networking"));
            bookList.Add(new Books(10, "Cyber Security", 2200, "Security"));

            // Display all books
            Console.WriteLine("All Books:");
            DisplayBooks(bookList);

            // Find Books with price > 1000
            Console.WriteLine("\nBooks with Price > 1000:");
            var expensiveBooks = bookList.Where(b => b.Price > 1000);
            DisplayBooks(expensiveBooks.ToList());

            // Sort Books by price (Ascending)
            Console.WriteLine("\nSorted by Price (Ascending):");
            var asc = bookList.OrderBy(b => b.Price);
            DisplayBooks(asc.ToList());

            // Sort Books by price (Descending)
            Console.WriteLine("\nSorted by Price (Descending):");
            var desc = bookList.OrderByDescending(b => b.Price);
            DisplayBooks(desc.ToList());

            // Remove Book by Id
            Console.WriteLine("\nRemoving Book with Id = 3...");
            var bookToRemove = bookList.FirstOrDefault(b => b.Id == 3);
            if (bookToRemove != null)
            {
                bookList.Remove(bookToRemove);
            }
            Console.WriteLine("\nAfter Removal:");
            DisplayBooks(bookList);

            // BONUS: Filter by Category
            Console.WriteLine("\nBooks in 'AI' Category:");
            var aiBooks = bookList.Where(b => b.Category == "AI");
            DisplayBooks(aiBooks.ToList());
        }

        // Method to Display Books
        static void DisplayBooks(List<Books> books)
        {
            foreach (var b in books)
            {
                Console.WriteLine($"Id: {b.Id}, Name: {b.Name}, Price: {b.Price}, Category: {b.Category}");
            }
        }
    
    }
}
