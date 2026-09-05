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

        // Compile-time error

        int pages = 464;

        Console.WriteLine("----------------------------");

        try
        {
            int x = 10;
            int y = 0;

            int result = x / y;

            Console.WriteLine(result);
        }  
        catch (Exception e)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }
        Console.WriteLine("----------------------------");






    }
}
