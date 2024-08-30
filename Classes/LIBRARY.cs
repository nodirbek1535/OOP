namespace OOP.Classes
{
    public class Book
    {
        private string authorName;
        private string bookName;
        private int bookprice;
        public Book(string bookName, string authorName, int bookPrice)
        {
            this.bookName = bookName;
            this.authorName = authorName;
            PriceBook = bookPrice;
        }
        public string AuthorName
        {
            get
            {
                return authorName; 
            }
            set
            {
                AuthorName=value;
            }
        }
        public string BookName
        {
            get
            {
                return bookName;
            }
            set
            {
                BookName=value;
            }
        }
        public int PriceBook
        {
            get
            {
                return bookprice;
            }
            set
            {
                if(value>=0)
                {
                    bookprice=value;
                }
                else
                {
                    Console.WriteLine("Narx manfiy bolmaydi");
                }
            }
            
        }
        public void chiqarish()
        {
            Console.WriteLine($"Demak {authorName}ning {bookName} asari {bookprice} som ekan");
        }
        public void dokondaginarxlar()
        {
            Console.WriteLine($"asaxiybooksda {0.9*bookprice},  uzummarketda {0.7*bookprice} va aliexpresda {0.6*bookprice}");
        }
    }
}