using System;

namespace todo_uygulamasi
{
    static class BoardListele
    {
        public static void boardListele()
        {
            Console.WriteLine("TODO Line\n" +
                "*******************************************");
            if (VarsayilanKayitlar.TodoLine.Count > 0)
            {
                for (int i = 0; i < VarsayilanKayitlar.TodoLine.Count; i++)
                {
                    listeYazisi(
                        VarsayilanKayitlar.TodoLine[i].Baslik,
                        VarsayilanKayitlar.TodoLine[i].Icerik,
                        VarsayilanKayitlar.TodoLine[i].AtananKisi,
                        VarsayilanKayitlar.TodoLine[i].Buyukluk
                    );
                }
            }
            else Console.WriteLine("~ BOŞ ~");


            Console.WriteLine("\nIN PROGRESS Line\n" +
                "*******************************************");
            if (VarsayilanKayitlar.InProgressLine.Count > 0)
            {
                for (int i = 0; i < VarsayilanKayitlar.InProgressLine.Count; i++)
                {
                    listeYazisi(
                        VarsayilanKayitlar.InProgressLine[i].Baslik,
                        VarsayilanKayitlar.InProgressLine[i].Icerik,
                        VarsayilanKayitlar.InProgressLine[i].AtananKisi,
                        VarsayilanKayitlar.InProgressLine[i].Buyukluk
                    );
                }
            }
            else Console.WriteLine("~ BOŞ ~");

            Console.WriteLine("\nDONE Line\n" +
                "*******************************************");
            if (VarsayilanKayitlar.DoneLine.Count > 0)
            {
                for (int i = 0; i < VarsayilanKayitlar.DoneLine.Count; i++)
                {
                    listeYazisi(
                        VarsayilanKayitlar.DoneLine[i].Baslik,
                        VarsayilanKayitlar.DoneLine[i].Icerik,
                        VarsayilanKayitlar.DoneLine[i].AtananKisi,
                        VarsayilanKayitlar.DoneLine[i].Buyukluk
                    );
                }
            }
            else Console.WriteLine("~ BOŞ ~");
            Menu.AnaMenuDon();
        }

        public static void listeYazisi(string Baslik, string Icerik, string AtananKisi, int Buyukluk)
        {
            Console.WriteLine("Başlık      : {0}", Baslik);
            Console.WriteLine("İçerik      : {0}", Icerik);
            Console.WriteLine("Atanan Kişi : {0}", AtananKisi);
            Console.WriteLine("Büyüklük    : {0}\n", (KartBuyukluk) Buyukluk);            
        }
    }
}