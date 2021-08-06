using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            Console.WriteLine("***********************************");
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Deniz";
            ogrenci1.Soyisim = "Arda";
            ogrenci1.OgrenciNo = 166;
            ogrenci1.Sinif = 1;
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string _isim;
        private string _soyisim;
        private int _ogrenciNo;
        private int _sinif;

        public string Isim 
        { 
            get { return _isim; }
            set { _isim = value; }
        }
        public string Soyisim { get => _soyisim; set => _soyisim = value; }
        public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
        public int Sinif 
        { 
            get => _sinif; 
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                }
                else _sinif = value;
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {
            
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**************** Öğrenci Bilgileri ****************");
            Console.WriteLine("Öğrenci Adı      : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyisim  : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No       : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   : {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
