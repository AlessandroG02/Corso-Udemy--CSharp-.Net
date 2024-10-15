using System;
using System.Collections.Generic;

namespace Corso_04
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Second);
            int[] sequence = new int[]
            {
                rnd.Next(1024),
                rnd.Next(1024),
                rnd.Next(1024),
                45,
                rnd.Next(1024),
                345
            };
            int[] sequence 2 = new int[6];
            Console.WriteLine($"Terzo  item: {sequence[2]}");
        }
    }
}
