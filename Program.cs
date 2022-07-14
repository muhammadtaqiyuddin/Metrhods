using System.Text;

namespace ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {

            Book book1 = new Book("Harry Potter", "JKRowling",400);
            Book book2 = new Book("Lord Angga", "Tolkeir", 700);
            book2.title = "The Habbit";

            Console.WriteLine(book1.BookMethod());
            Console.WriteLine(book2.BookMethod());
            Console.ReadLine();
        }


    }
}
