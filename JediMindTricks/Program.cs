using System;
using System.Collections.Generic;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Dictionary = new Dictionary<string, int>()
            {
                {"Han", 25}
            };
            Dictionary.Add("Daniel", 17);
            Dictionary["Peter"] = 21;

            foreach( KeyValuePair<string, int> pair in Dictionary)
            {
                Console.WriteLine($"{pair.Key} er {pair.Value} år gammel.");

            }

            Dictionary.Remove("Han");

            Console.WriteLine();
            foreach (var pair in Dictionary)
            {
                Console.WriteLine($"{pair.Key} er {pair.Value} år gammel.");

            }
        }
    }
}
