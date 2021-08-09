using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci sayısı için derinlik girin: ");
            int len = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0, d = 1;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                d += c;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.WriteLine("\nOrtalama: {0}", d/len);
        }
    }
}
