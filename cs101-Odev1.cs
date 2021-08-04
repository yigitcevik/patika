using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ödev1 - 1. cevap
            Console.Write("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] sayi = new int[n];
            int a = n;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} adet pozitif sayı giriniz:", a);
                a--;
                sayi[i] = int.Parse(Console.ReadLine());

            }
            foreach (var item in sayi)
            {
                Console.Write(item);
            }
            foreach (int item in sayi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            // Ödev1 - 2. cevap
            int a = 2;
            int n, m;
            int[] sayi = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} adet pozitif sayı giriniz:", a);
                a--;
                sayi[i] = int.Parse(Console.ReadLine());
            }
            n = sayi[0];
            m = sayi[1];
            a = n;
            int[] sayi2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} adet pozitif sayı giriniz:", a);
                a--;
                sayi2[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in sayi2)
            {
                if (item == m || item % m == 0)
                {
                    Console.WriteLine("Sonuc: " + item);
                }
            }

            // Ödev1 - 3. cevap
            Console.Write("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            string[] kelime = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} adet kelime giriniz: \n", a);
                a--;
                kelime[i] = Console.ReadLine();
            }
            int b = kelime.Length;
            Array.Reverse(kelime);
            foreach (string item in kelime)
            {
                Console.Write(item);
            }

            // Ödev1 - 4. cevap
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            int kelimeSayisi = cumle.Split(" ").Length;
            int harfSayisi = cumle.Replace(" ", string.Empty).Length;
            Console.WriteLine("Toplam kelime: {0}, Toplam harf: {1}", kelimeSayisi, harfSayisi);
        }
    }
}
