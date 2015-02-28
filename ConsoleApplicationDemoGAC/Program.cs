using System;
using ClassLibraryDemoStromgName;

namespace ConsoleApplicationDemoGAC
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Book book = new Book("Title1", "Author1");
            Console.WriteLine(book.ToString());
            Console.ReadLine();
        }
    }
}
