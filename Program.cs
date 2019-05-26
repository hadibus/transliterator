using System;

namespace transliterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var line = "";
            while ((line = Console.ReadLine()) != null && line != "") {
                Console.WriteLine(line);
            }
            Console.WriteLine("Goodbye World!");              
        }
    }
}
