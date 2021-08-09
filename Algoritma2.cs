using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime girin:");
            string s = Console.ReadLine();
            char a = s[0];
            s = s.Remove(0,1);
            Console.Write(s+a);
        }
    }
}
