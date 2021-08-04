using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc) Console.WriteLine("Başarılı {0}", outSayi);
            else Console.WriteLine("Başarısız");

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int result);
            Console.WriteLine(result);

            //metot overloading
            int ifade = 999;
            instance.EkranaYazdir(ifade);
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine("str " + veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine("int " + veri);
        }
    }
}
