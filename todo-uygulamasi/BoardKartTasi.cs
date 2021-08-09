using System;

namespace todo_uygulamasi
{
    static class BoardKartTasi
    {
        public static void KartTasi()
        {
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string kartBaslik = Console.ReadLine();
            int kayitSayisi = VarsayilanKayitlar.TodoLine.Count + VarsayilanKayitlar.InProgressLine.Count + VarsayilanKayitlar.DoneLine.Count;
            for (int i = 0; i < VarsayilanKayitlar.TodoLine.Count; i++)
            {
                if (VarsayilanKayitlar.TodoLine[i].Baslik.Contains(kartBaslik))
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n" +
                                "**************************************");
                    BoardListele.listeYazisi(
                        VarsayilanKayitlar.TodoLine[i].Baslik,
                        VarsayilanKayitlar.TodoLine[i].Icerik,
                        VarsayilanKayitlar.TodoLine[i].AtananKisi,
                        VarsayilanKayitlar.TodoLine[i].Buyukluk
                    );
                    Console.WriteLine("Line        : TODO");
                    TasimaSecim(i, 1);
                }
            }
            for (int i = 0; i < VarsayilanKayitlar.InProgressLine.Count; i++)
            {
                if (VarsayilanKayitlar.InProgressLine[i].Baslik.Contains(kartBaslik))
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n" +
                                "**************************************");
                    BoardListele.listeYazisi(
                        VarsayilanKayitlar.InProgressLine[i].Baslik,
                        VarsayilanKayitlar.InProgressLine[i].Icerik,
                        VarsayilanKayitlar.InProgressLine[i].AtananKisi,
                        VarsayilanKayitlar.InProgressLine[i].Buyukluk
                    );
                    Console.WriteLine("Line        : IN PROGRESS");
                    TasimaSecim(i, 2);
                }
            }
            for (int i = 0; i < VarsayilanKayitlar.DoneLine.Count; i++)
            {
                if (VarsayilanKayitlar.DoneLine[i].Baslik.Contains(kartBaslik))
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n" +
                                "**************************************");
                    BoardListele.listeYazisi(
                        VarsayilanKayitlar.DoneLine[i].Baslik,
                        VarsayilanKayitlar.DoneLine[i].Icerik,
                        VarsayilanKayitlar.DoneLine[i].AtananKisi,
                        VarsayilanKayitlar.DoneLine[i].Buyukluk
                    );
                    Console.WriteLine("Line        : DONE");
                    TasimaSecim(i, 3);
                }
            }
        }

        public static void TasimaSecim(int listeSirasi, int line)
        {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
            int secim = int.Parse(Console.ReadLine());

            switch (secim, line)
            {
                case (1, 2):
                    VarsayilanKayitlar.VarsayilanTodo(
                        VarsayilanKayitlar.InProgressLine[listeSirasi].Baslik,
                        VarsayilanKayitlar.InProgressLine[listeSirasi].Icerik,
                        VarsayilanKayitlar.InProgressLine[listeSirasi].AtananKisi,
                        VarsayilanKayitlar.InProgressLine[listeSirasi].Buyukluk
                    );
                    VarsayilanKayitlar.InProgressLine.RemoveAt(listeSirasi);
                    break;
                case (1, 3):
                    VarsayilanKayitlar.VarsayilanTodo(
                        VarsayilanKayitlar.DoneLine[listeSirasi].Baslik,
                        VarsayilanKayitlar.DoneLine[listeSirasi].Icerik,
                        VarsayilanKayitlar.DoneLine[listeSirasi].AtananKisi,
                        VarsayilanKayitlar.DoneLine[listeSirasi].Buyukluk
                    );
                    VarsayilanKayitlar.DoneLine.RemoveAt(listeSirasi);
                    break;
                case (2, 1):
                    VarsayilanKayitlar.VarsayilanInProgress(
                        VarsayilanKayitlar.TodoLine[listeSirasi].Baslik,
                        VarsayilanKayitlar.TodoLine[listeSirasi].Icerik,
                        VarsayilanKayitlar.TodoLine[listeSirasi].AtananKisi,
                        VarsayilanKayitlar.TodoLine[listeSirasi].Buyukluk
                    );
                    VarsayilanKayitlar.TodoLine.RemoveAt(listeSirasi);
                    break;
                case (2, 3):
                    VarsayilanKayitlar.VarsayilanInProgress(
                         VarsayilanKayitlar.DoneLine[listeSirasi].Baslik,
                         VarsayilanKayitlar.DoneLine[listeSirasi].Icerik,
                         VarsayilanKayitlar.DoneLine[listeSirasi].AtananKisi,
                         VarsayilanKayitlar.DoneLine[listeSirasi].Buyukluk
                     );
                    VarsayilanKayitlar.DoneLine.RemoveAt(listeSirasi);
                    break;
                case (3, 1):
                    VarsayilanKayitlar.VarsayilanDone(
                        VarsayilanKayitlar.TodoLine[listeSirasi].Baslik,
                        VarsayilanKayitlar.TodoLine[listeSirasi].Icerik,
                        VarsayilanKayitlar.TodoLine[listeSirasi].AtananKisi,
                        VarsayilanKayitlar.TodoLine[listeSirasi].Buyukluk
                    );
                    VarsayilanKayitlar.TodoLine.RemoveAt(listeSirasi);
                    break;
                case (3, 2):
                    VarsayilanKayitlar.VarsayilanDone(
                        VarsayilanKayitlar.InProgressLine[listeSirasi].Baslik,
                        VarsayilanKayitlar.InProgressLine[listeSirasi].Icerik,
                        VarsayilanKayitlar.InProgressLine[listeSirasi].AtananKisi,
                        VarsayilanKayitlar.InProgressLine[listeSirasi].Buyukluk
                    );
                    VarsayilanKayitlar.InProgressLine.RemoveAt(listeSirasi);
                    break;
                default:
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                    Menu.AnaMenuDon();
                    break;
            }

            Console.WriteLine("Taşıma başarılı.");
            Menu.AnaMenuDon();
        }
    }
}