using System;

namespace telefon_rehberi
{
    class Program
    {
        public static void Main(string[] args)
        {
            AnaSayfa.Secenekler();
        }
    }

    class AnaSayfa
    {
        public static void Secenekler()
        {
            if (NumaraIslemleri.kisiler.Count == 0)
            {
                Kisiler kisiler = new Kisiler();
                kisiler.varsayilanKayitlar();
            }
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                    "**********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    NumaraIslemleri.YeniNumaraBilgisiGir();
                    break;
                case 2:
                    NumaraIslemleri.KisiSil();
                    break;
                case 3:
                    NumaraIslemleri.NumaraGuncelle();
                    break;
                case 4:
                    NumaraIslemleri.RehberiListele();
                    break;
                case 5:
                    NumaraIslemleri.RehberdeAra();
                    break;
            }
        }
    }
}
