namespace M1_Practice
{
    public class LibraryUtility
    {
        public int Id { get; set; }

        public static List<Book> books = new List<Book>();
        public void AddBook(string title, string author, string genre, int year)
        {
            // Adds book with auto-incremented ID

            books.Add(new Book{
                Title = title,
                Author = author,
                Genre = genre,
                PublicationYear = year
            }
            );
        }


        public SortedDictionary<string, List<Book>> GroupBooksByGenre()
        {
            // Groups books by genre alphabetically
            SortedDictionary<string, List<Book>> sortedDictionary = new SortedDictionary<string, List<Book>>();

            foreach(var book in books){
                if (string.IsNullOrEmpty(book.Genre))
                {
                    continue;
                }

                if (sortedDictionary.ContainsKey(book.Genre))
                {
                    List<Book> bb=sortedDictionary[book.Genre];
                    bb.Add(book);
                }
                else
                {
                    List<Book> newBook = new List<Book>();
                    newBook.Add(book);
                    sortedDictionary.Add(book.Genre, newBook);
                }

            }
            
            return sortedDictionary;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            var ans = new List<Book>();
            // Returns all books by specific author
            foreach (var book in books)
            {
                if (book.Author==author)
                {
                    ans.Add(book);
                }
                
            }
            return ans;
        }

        public int GetTotalBooksCount()
        {
            // Returns total number of books
            int cnt =0;
            foreach(var book in books)
            {
                cnt++;
            }
            return cnt;
        }

        public static void Main()
        {
            LibraryUtility libraryUtility = new LibraryUtility();
            libraryUtility.AddBook("Maze Runner", "Aurther", "Sci-Fic", 2012);
            libraryUtility.AddBook("Maze Runner 2", "Aurther", "Sci-Fic", 2014);
            libraryUtility.AddBook("Maze Runner 3", "Aurther", "Sci-Fic", 2016);
            libraryUtility.AddBook("Aot", "Zurtho", "Action, Adventure", 2019);
            List<Book> books=libraryUtility.GetBooksByAuthor("Aurther");
            foreach(var book in books)
            {
                Console.WriteLine(book.Title+" "+book.Author);
            }

            SortedDictionary<string, List<Book>> result = libraryUtility.GroupBooksByGenre();

            foreach(var d in result)
            {
                
            }

            int totalBooks = libraryUtility.GetTotalBooksCount();
            Console.WriteLine("Total Books: "+totalBooks);
        }

    }
}