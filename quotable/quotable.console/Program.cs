using System;
using quotable.core;

namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimpleRandomQuoteProvider test = new SimpleRandomQuoteProvider();
            test.returnQ(10);
            Console.ReadKey();
        }
    }
}
