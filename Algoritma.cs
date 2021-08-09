using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(kelime,sayı) şeklinde değer giriniz:");
            string[] s = Console.ReadLine().Split(",");
            int a = Convert.ToInt32(s[1]);
            Console.WriteLine(s[0].Remove(a,1));
        }
    }
}
