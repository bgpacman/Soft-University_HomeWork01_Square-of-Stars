﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string(' ', n - 2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
