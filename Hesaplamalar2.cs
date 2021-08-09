using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static string[] a;
        static void Main()
        {
            Console.WriteLine("(a,b) şeklinde 2 sayı giriniz: ");
            a = Console.ReadLine().Split(",");
            if (Convert.ToInt32(a[0]) == Convert.ToInt32(a[1]))
            {
                Console.WriteLine("Toplam Karesi: " + Math.Pow(Topla(),2));
            }
            else
            {
                Console.WriteLine("Toplam: " + Topla());
            }
            
        }

        public static int Topla()
        {
            int t = Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]);
            return t;
        }
    }
}
