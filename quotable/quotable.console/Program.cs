using System;
using quotable.core;

namespace quotable.console
{
    /// <summary>
    /// Runs the SimpleRandomQuoteProvider object in the console application.
    /// Takes in a user input, checks to see if it can be parsed as an integer,
    /// and if so calls returnQ which returns an array of strings.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Testing the SimpleRandomQuoteProvider in a console app.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            RandomQuoteProvider simpleRandomQuoteObject = new SimpleRandomQuoteProvider();
            var userInput = new int(); //holds user input as an int

            if(int.TryParse(Console.ReadLine(), out userInput)){
                simpleRandomQuoteObject.returnQ(userInput);
            }
            else
            {
                Console.Error.WriteLine("Please enter a valid number/integer");
            }
            Console.ReadKey();
        }
    }
}
