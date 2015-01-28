using int2roman.lib;
using System;

namespace int2roman.testclient
{
    public class EntryPoint
    {
        /// <summary>
        /// Output some simple examples of the .ToRoman extension method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            for (int i = 1; i < 25; i++)
            {
                Console.WriteLine("{0} -> {1}", i, i.ToRoman());
            }
            Console.WriteLine("{0} -> {1}", 1954, int.Parse("1954").ToRoman());
            Console.WriteLine("{0} -> {1}", 1990, int.Parse("1990").ToRoman());
            Console.WriteLine("{0} -> {1}", 2014, int.Parse("2014").ToRoman());
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}