using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kelime giriniz: ");
            char[] s = Console.ReadLine().ToCharArray();
            char f = s[0];
            s[0] = s[s.Length-1];
            s[s.Length-1] = f;
            Console.WriteLine(s);
        }        
    }
}
