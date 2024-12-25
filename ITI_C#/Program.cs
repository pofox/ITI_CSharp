namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            string[] Authours1 = { "Elisabeth Vincentelli", "Insight Editions" };
            string[] Authours2 = { "Ramin Zahed", "Brian Michael Bendis" };
            string[] Authours3 = { "Alex Hirsch" };
            books.Add(new Book("9798886633368", "The Art and Making of Arcane", Authours1, new DateTime(2024, 12, 3), 18.99m));
            books.Add(new Book("9781785659461", "Spider-Man: Into the Spider-Verse -The Art of the Movie", Authours2, new DateTime(2018, 12, 18), 27.49m));
            books.Add(new Book("9781368104807", "The Book of Bill (Gravity Falls)", Authours3, new DateTime(2024, 7, 23), 18.88m));
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            LibraryEngine.ProcessBooks(books, delegate(Book B){ return B.ISBN; });
            LibraryEngine.ProcessBooks(books, B=>B.PublicationDate.ToString());
        }
    }
}
