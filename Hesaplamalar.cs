using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        public static double cevap = 0;
        static void Main()
        {

            Console.WriteLine("Şekil seçin: \n" +
            "********************************");
            Console.WriteLine("(1) Daire");
            Console.WriteLine("(2) Üçgen");
            Console.WriteLine("(3) Kare");
            Console.WriteLine("(4) Dikdötgen");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    DaireHesapla();
                    break;
                case 2:
                    UcgenHesapla();
                    break;
                case 3:
                    KareHesapla();
                    break;
                case 4:
                    DikdortgenHesapla();
                    break;
            }
        }

        static void DaireHesapla()
        {
            Console.WriteLine("Dairenin yarı çapını giriniz: ");
            double r = double.Parse(Console.ReadLine());
            HesapTuru();
            if (int.Parse(Console.ReadLine()) == 1)
            {
                cevap = 2 * Math.PI * r;
            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                cevap = Math.PI * Math.Pow(r, 2);
            }
            HesapCevabi(cevap);
            AnaSayfa();
        }

        static void UcgenHesapla()
        {
            Console.WriteLine("Üçgenin taban uzunluğu 1.kenar:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin 2. kenar uzunluğu:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin 3. kenar uzunluğu:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin yüksekliği:");
            double h = double.Parse(Console.ReadLine());
            HesapTuru();
            if (int.Parse(Console.ReadLine()) == 1)
            {
                cevap = a + b + c;
            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                cevap = (a * h) / 2;
            }
            HesapCevabi(cevap);
            AnaSayfa();
        }

        static void KareHesapla()
        {
            Console.WriteLine("Karenin kenar uzunluğu: ");
            double a = double.Parse(Console.ReadLine());
            HesapTuru();
            if (int.Parse(Console.ReadLine()) == 1)
            {
                cevap = a * 4;
            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                cevap = Math.Pow(a, 2);
            }
            HesapCevabi(cevap);
            AnaSayfa();
        }

        static void DikdortgenHesapla()
        {
            Console.WriteLine("Dikdötgen uzun kenar uzunluğu: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Dikdötgen kısa kenar uzunluğu: ");
            double b = double.Parse(Console.ReadLine());
            HesapTuru();
            if (int.Parse(Console.ReadLine()) == 1)
            {
                cevap = 2 * (a + b);
            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                cevap = a * b;
            }
            HesapCevabi(cevap);
            AnaSayfa();
        }

        static void HesapTuru()
        {
            Console.WriteLine("Hesaplamak istediğiniz türü seçiniz: ");
            Console.WriteLine("(1) Çevre");
            Console.WriteLine("(2) Alan");
        }

        static void HesapCevabi(double cevap)
        {
            Console.WriteLine("Cevap: {0}", cevap);
        }
        static void AnaSayfa()
        {
            Console.WriteLine("(0) Ana sayfaya dön: ");
            if (int.Parse(Console.ReadLine()) == 0)
            {
                Main();
            }
        }
    }
}
