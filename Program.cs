using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {

        // See https://aka.ms/new-console-template for more information

        // Initialize our list
        List<string> mylist = new List<string>(new string[] { "biology-1", "biology-2", "biology-3" });


        Random R = new Random();
        Console.WriteLine("Press Enter key to continue | Escape key to quit");

        ConsoleKeyInfo k = Console.ReadKey();

        while (k.Key != ConsoleKey.Escape)
        {
            // get random number from 0 to 2. 
            int someRandomNumber = R.Next(0, mylist.Count);

            Console.WriteLine("Hello {0}", mylist.ElementAt(someRandomNumber));

            k = Console.ReadKey();

        }

    }
}
