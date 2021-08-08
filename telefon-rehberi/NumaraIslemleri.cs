using System;
using System.Collections;
using System.Collections.Generic;

namespace telefon_rehberi
{
    public static class NumaraIslemleri
    {
        public static string isim, soyisim;
        public static long numara;
        public static List<Kisiler> kisiler = new List<Kisiler>();
        public static void YeniNumaraBilgisiGir()
        {
            Console.WriteLine("Lütfen isim giriniz             : ");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          : ");
            soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            numara = long.Parse(Console.ReadLine());
            YeniNumarayıEkle(isim, soyisim, numara);
        }

        public static void YeniNumarayıEkle(string isim, string soyisim, long numara)
        {
            kisiler.Add(new Kisiler()
            {
                Isim = isim,
                Soyisim = soyisim,
                Numara = numara
            });

            Console.WriteLine("Yeni kişi eklendi.");
            RehberiListele();
            AnaMenu();
        }

        public static void RehberiListele()
        {
            Console.WriteLine("Telefon Rehberi\n" +
                    "**********************************************");
            if (kisiler.Count > 0)
            {
                for (int i = 0; i < kisiler.Count; i++)
                {
                    Console.WriteLine("isim: {0}\nsoyisim: {1}\nnumara: {2}\n"
                    , kisiler[i].Isim, kisiler[i].Soyisim, kisiler[i].Numara);
                }
            }
            else Console.WriteLine("Gösterilecek kişi yok.");
            AnaMenu();

        }

        public static void KisiSil()
        {
        SilmeTekrar:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string silinecekKisi = Console.ReadLine();
            Console.WriteLine("Kişi sayısı: " + kisiler.Count);
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Isim.Contains(silinecekKisi) || kisiler[i].Soyisim.Contains(silinecekKisi))
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",
                        kisiler[i].Isim, kisiler[i].Soyisim);
                    string onay = Console.ReadLine();
                    if (onay == "y")
                    {
                        kisiler.Remove(kisiler[i]);
                        RehberiListele();
                        AnaMenu();
                    }
                    else AnaMenu();
                }
            }
            VeriBulunamadı("Silme");
            int onayNo = int.Parse(Console.ReadLine());
            if (onayNo == 1) AnaSayfa.Secenekler();
            else if (onayNo == 2) goto SilmeTekrar;
            else AnaMenu();
        }

        public static void NumaraGuncelle()
        {
        GuncellemeTekrar:
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string guncellenecekKisi = Console.ReadLine();
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Isim.Contains(guncellenecekKisi) || kisiler[i].Soyisim.Contains(guncellenecekKisi))
                {
                    Console.WriteLine("{0} {1} kişini yeni bilgilerini giriniz: ",
                        kisiler[i].Isim, kisiler[i].Soyisim);
                    Console.WriteLine("Kişinin yeni ismi: ");
                    kisiler[i].Isim = Console.ReadLine();
                    Console.WriteLine("Kişinin yeni soyismi: ");
                    kisiler[i].Soyisim = Console.ReadLine();
                    Console.WriteLine("Kişinin yeni numarası: ");
                    kisiler[i].Numara = long.Parse(Console.ReadLine());
                    RehberiListele();
                    Console.WriteLine("Güncelleme Başarılı");
                    AnaMenu();
                }
            }
            VeriBulunamadı("Güncelleme");
            int onayNo = int.Parse(Console.ReadLine());
            if (onayNo == 1) AnaSayfa.Secenekler();
            else if (onayNo == 2) goto GuncellemeTekrar;
            else AnaMenu();

        }

        public static void RehberdeAra()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n" +
                    "**********************************************");
            Console.WriteLine("(1) İsim veya soyisime göre arama yap");
            Console.WriteLine("(2) Telefon numarasına göre arama yap");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("Lütfen adı ya da soyadı giriniz: ");
                string bulunacakKisi = Console.ReadLine();
                for (int i = 0; i < kisiler.Count; i++)
                {
                    if (kisiler[i].Isim.Contains(bulunacakKisi) || kisiler[i].Soyisim.Contains(bulunacakKisi))
                    {
                        Console.WriteLine("isim: {0}\nsoyisim: {1}\nnumara: {2}\n"
                        , kisiler[i].Isim, kisiler[i].Soyisim, kisiler[i].Numara);
                    }
                }

            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                Console.WriteLine("Lütfen telefon numarası giriniz: ");
                string bulunacakNumara = Console.ReadLine();
                for (int i = 0; i < kisiler.Count; i++)
                {
                    if (kisiler[i].Numara.ToString().Contains(bulunacakNumara))
                    {
                        Console.WriteLine("isim: {0}\nsoyisim: {1}\nnumara: {2}\n"
                        , kisiler[i].Isim, kisiler[i].Soyisim, kisiler[i].Numara);
                    }
                }
            }
            else AnaMenu();
            AnaMenu();
        }

        public static void AnaMenu()
        {
            Console.WriteLine("(0) Ana menüye dön ");
            if (int.Parse(Console.ReadLine()) == 0)
            {
                AnaSayfa.Secenekler();
            }
        }

        public static void VeriBulunamadı(string islemAdi)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("(1) {0} işlemini sonlandır", islemAdi);
            Console.WriteLine("(2) Yeniden dene");
        }


    }
    public class Kisiler
    {
        private string isim;
        private string soyisim;
        private long numara;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public long Numara { get => numara; set => numara = value; }

        public void varsayilanKayitlar()
        {
            NumaraIslemleri.kisiler.Add(new Kisiler() { Isim = "Ali", Soyisim = "Güney", Numara = 05675555547 });
            NumaraIslemleri.kisiler.Add(new Kisiler() { Isim = "Ayşe", Soyisim = "Korkmaz", Numara = 05979011422 });
            NumaraIslemleri.kisiler.Add(new Kisiler() { Isim = "Burak", Soyisim = "Kara", Numara = 05897772454 });
            NumaraIslemleri.kisiler.Add(new Kisiler() { Isim = "Barış", Soyisim = "Yılmaz", Numara = 05578884140 });
            NumaraIslemleri.kisiler.Add(new Kisiler() { Isim = "Dilara", Soyisim = "Işık", Numara = 05986122542 });
        }
    }
}