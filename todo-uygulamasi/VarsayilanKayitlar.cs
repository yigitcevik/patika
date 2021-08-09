using System;
using System.Collections.Generic;

namespace todo_uygulamasi
{
    static class VarsayilanKayitlar
    {
        public static List<BoardLines> TodoLine = new List<BoardLines>();
        public static List<BoardLines> InProgressLine = new List<BoardLines>();
        public static List<BoardLines> DoneLine = new List<BoardLines>();

        public static void VarsayilanTodo(string baslik, string icerik, string atananKisi, int buyukluk)
        {
            TodoLine.Add(new BoardLines()
            {
                Baslik = baslik,
                Icerik = icerik,
                AtananKisi = atananKisi,
                Buyukluk = buyukluk
            });
        }

        public static void VarsayilanInProgress(string baslik, string icerik, string atananKisi, int buyukluk)
        {
            InProgressLine.Add(new BoardLines()
            {
                Baslik = baslik,
                Icerik = icerik,
                AtananKisi = atananKisi,
                Buyukluk = buyukluk
            });
        }

        public static void VarsayilanDone(string baslik, string icerik, string atananKisi, int buyukluk)
        {
            DoneLine.Add(new BoardLines()
            {
                Baslik = baslik,
                Icerik = icerik,
                AtananKisi = atananKisi,
                Buyukluk = buyukluk
            });
        }
    }

    public class BoardLines
    {
        private string baslik;
        private string icerik;
        private string atananKisi;
        private int buyukluk;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }
        public int Buyukluk { get => buyukluk; set => buyukluk = value; }
    }
}