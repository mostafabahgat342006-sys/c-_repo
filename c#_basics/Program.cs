using System.Text;

namespace c__basics;

internal class Program
{

    class Book
    {
        public string title;
        public int pages;

        public Book(string t, int p)
        {
            title = t;
            pages = p;
        }
        public override string ToString()
        {
            return title + " " + pages;
        }
    }
    static void Main(string[] args)
    {
        Book book = new Book("c#" , 100);
        object obj = book;

        Console.WriteLine(obj);
        Console.WriteLine("----------------------------");


        Console.WriteLine(book.ToString());

            Console.WriteLine(book.Equals(book));

            Console.WriteLine(book.GetHashCode());

            Console.WriteLine(book.GetType());

        Console.WriteLine("----------------------------");







    }
}
