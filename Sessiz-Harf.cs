using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static char[] sessiz = "bcçdfgğhjklmnprsştvyz".ToCharArray();
        static void Main()
        {
            Console.WriteLine("Kelime giriniz: ");
            char[] s = Console.ReadLine().ToCharArray();
            int k = 0; //merhaba
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < sessiz.Length; j++)
                {
                    if (s[i] == sessiz[j])
                    {
                        for (int z = 0; z < sessiz.Length; z++)
                        {
                            if (i+1 < s.Length)
                            {
                                if (s[i + 1] == sessiz[z])
                                {
                                    k = 1;
                                }
                            }
                        }
                    }
                }
            }
            if (k == 1) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
