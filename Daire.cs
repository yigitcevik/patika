using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int N = (2 * r + 1);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int x = i - r;
                    int y = j - r;

                    if (x * x + y * y <= r * r + 1) Console.Write("*");
                    else Console.Write(" ");

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
