


    public class Book
    {
        private string _author;
        private string _title;

        public Book(string title, string author)
        {
            _author = author;
            _title = title;
        }

        public string Details(Book book) => $"Title: {_title} \nAuthor: {_author}";

    }

    public class Library
    {
        private List<Book> _libraryList = new List<Book>();

        public void AddBook(Book book)
        {
            _libraryList.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _libraryList.Remove(book);
        }

        public void Display()
        {
            foreach (Book book in _libraryList)
            {
                var details = book.Details(book);
                Console.WriteLine(details);
            }
        }
    }
