using System;

namespace todo_uygulamasi
{
    static class BoardKartEkle
    {
        public static void KartEkle()
        {
            Console.WriteLine("Başlık Giriniz                                  : ");
            string baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            string icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int buyukluk = int.Parse(Console.ReadLine());
            Console.WriteLine("Kişi Seçiniz (ID)                                    : ");
            int atananKisi = int.Parse(Console.ReadLine());
            if (!Kisiler.takimUyeleri.ContainsKey(atananKisi))
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }
            else
            {
                VarsayilanKayitlar.VarsayilanTodo(baslik, icerik, Kisiler.takimUyeleri[atananKisi],buyukluk);
            }
            Menu.AnaMenuDon();
        }
    }
}