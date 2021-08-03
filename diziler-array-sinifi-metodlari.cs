using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** Sırasız *************");
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            foreach (var sayi in sayiDizisi) Console.WriteLine(sayi);

            Console.WriteLine("************** Sıralı *************");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi) Console.WriteLine(sayi);

            Console.WriteLine("************** Clear *************");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi) Console.WriteLine(sayi);

            Console.WriteLine("************** Reverse *************");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi) Console.WriteLine(sayi);

            Console.WriteLine("************** IndexOf *************");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            Console.WriteLine("************** Resize *************");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi) Console.WriteLine(sayi);
        }
    }
}
