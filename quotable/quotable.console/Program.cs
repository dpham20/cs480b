using System;
using quotable.core;

namespace quotable.console
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRandomQuoteProvider test = new SimpleRandomQuoteProvider();
            var amount = new int();
            if(int.TryParse(Console.ReadLine(), out amount)){
                Console.WriteLine("This is getting called");
                test.returnQ(amount);
            }
            else
            {
                Console.WriteLine("Please enter a valid number/integer");
            }
            Console.ReadKey();
        }
    }
}
