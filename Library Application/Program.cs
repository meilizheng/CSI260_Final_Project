namespace Library_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new library
            Library library = new Library();

            // Add some books to the library
            library.AddBook(new Book(978006112, "To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new Book(978045152, "1984", "George Orwell"));
            library.AddBook(new Book(978074327, "The Great Gatsby", "F. Scott Fitzgerald"));
            library.AddBook(new Book(978014143, "Pride and Prejudice", "Jane Austen"));
            library.AddBook(new Book(978031676, "The Catcher in the Rye", "J.D. Salinger"));
            library.AddBook(new Book(978054792, "The Hobbit", "J.R.R. Tolkien"));
            library.AddBook(new Book(978006085, "Brave New World", "Aldous Huxley"));
            library.AddBook(new Book(978061864, "The Lord of the Rings", "J.R.R. Tolkien"));
            library.AddBook(new Book(978045152, "Animal Farm", "George Orwell"));
            library.AddBook(new Book(978074753, "Harry Potter and the Philosopher's Stone", "J.K. Rowling"));



            // Search for a book by ISBN
            int isbnToSearch = 978014143;
            Book foundBook = library.SearchByISBN(isbnToSearch);
            if (foundBook != null)
            {
                Console.WriteLine($"Book found with ISBN {isbnToSearch}: {foundBook.Title} by {foundBook.Author}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbnToSearch} not found.");
            }
        }
    }
}