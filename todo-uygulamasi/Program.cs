using System;
using System.Collections.Generic;

namespace todo_uygulamasi
{
    static class Program
    {
        static void Main(string[] args)
        {
            VarsayilanKaydet();
            AnaMenu();
        }

        public static void AnaMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                "*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    BoardListele.boardListele();
                    break;
                case 2:
                    BoardKartEkle.KartEkle();
                    break;
                case 3:
                    BoardKartSil.KartSil();
                    break;
                case 4:
                    BoardKartTasi.KartTasi();
                    break;
            }
        }
        public static void VarsayilanKaydet()
        {
            Kisiler.VarsayilanKisiler();
            VarsayilanKayitlar.VarsayilanTodo("TODO Baslik-1", "TODO Icerik-1", Kisiler.takimUyeleri[1], 0);
            VarsayilanKayitlar.VarsayilanTodo("TODO Baslik-2", "TODO Icerik-2", Kisiler.takimUyeleri[4], 4);
            VarsayilanKayitlar.VarsayilanInProgress("INPROGRESS Baslik-1", "INPROGRESS Icerik-1", Kisiler.takimUyeleri[3], 2);
        }
    }

    public static class Menu
    {
        public static void AnaMenuDon()
        {
            Console.WriteLine("(0) Ana menüye dön: ");
            if (int.Parse(Console.ReadLine()) == 0)
            {
                Program.AnaMenu();
            }
        }

        public static void VeriBulunamadı(string islemAdi)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("(1) {0} işlemini sonlandır", islemAdi);
            Console.WriteLine("(2) Yeniden dene");
        }
    }
}