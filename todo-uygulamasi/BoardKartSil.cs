using System;

namespace todo_uygulamasi
{
    static class BoardKartSil
    {
        public static void KartSil()
        {
        SilmeTekrar:
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string kartBaslik = Console.ReadLine();
            int kayitSayisi = VarsayilanKayitlar.TodoLine.Count + VarsayilanKayitlar.InProgressLine.Count + VarsayilanKayitlar.DoneLine.Count;
            for (int i = 0; i < VarsayilanKayitlar.TodoLine.Count; i++)
            {
                if (VarsayilanKayitlar.TodoLine[i].Baslik.Contains(kartBaslik))
                {
                    VarsayilanKayitlar.TodoLine.RemoveAt(i);
                }
            }
            for (int i = 0; i < VarsayilanKayitlar.InProgressLine.Count; i++)
            {
                if (VarsayilanKayitlar.InProgressLine[i].Baslik.Contains(kartBaslik))
                {
                    VarsayilanKayitlar.InProgressLine.RemoveAt(i);
                }
            }
            for (int i = 0; i < VarsayilanKayitlar.DoneLine.Count; i++)
            {
                if (VarsayilanKayitlar.DoneLine[i].Baslik.Contains(kartBaslik))
                {
                    VarsayilanKayitlar.DoneLine.RemoveAt(i);
                }
            }
            if (kayitSayisi > VarsayilanKayitlar.TodoLine.Count + VarsayilanKayitlar.InProgressLine.Count + VarsayilanKayitlar.DoneLine.Count)
            {
                Console.WriteLine("Kayıtlar silindi.");
                Menu.AnaMenuDon();
            }
            else
            {
                Menu.VeriBulunamadı("Silme");
                int onayNo = int.Parse(Console.ReadLine());
                if (onayNo == 1) Program.AnaMenu();
                else if (onayNo == 2) goto SilmeTekrar;
                else Menu.AnaMenuDon();
            }
        }
    }
}