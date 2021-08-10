using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Virgülle ayırarak istediğiniz kadar sayı giriniz: ");
            string[] a = Console.ReadLine().Split(",");
            List<int> yuksek = new List<int>();
            List<int> dusuk = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (Convert.ToInt32(a[i]) < 67)
                {
                    dusuk.Add(Convert.ToInt32(a[i]));
                }
                else
                {
                    yuksek.Add(Convert.ToInt32(a[i]));
                }
            }
            Console.WriteLine("Fark Toplamı: {0}", FarkToplami(dusuk));
            Console.WriteLine("Mutlak Karesi: {0}", MutlakKaresi(yuksek));

        }

        public static int FarkToplami(List<int> dusuk)
        {
            int farkToplam = 0;
            for (int i = 0; i < dusuk.Count; i++)
            {
                farkToplam += (67 - dusuk[i]);
            }

            return farkToplam;
        }

        public static double MutlakKaresi(List<int> yuksek)
        {
            double MutlakToplam = 0;
            for (int i = 0; i < yuksek.Count; i++)
            {
                MutlakToplam += Math.Pow(Math.Abs(67 - yuksek[i]), 2);
            }
            return MutlakToplam;
        }
    }
}
