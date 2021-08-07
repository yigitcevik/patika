using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine(Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik <= ((int)HavaSicakligi.Normal))
            {
                Console.WriteLine("Havanın ısınmasını bekle.");
            }
            else if (sicaklik >= ((int)HavaSicakligi.Sicak))
            {
                Console.WriteLine("Çok sıcak");
            }
            else if(sicaklik >= ((int)HavaSicakligi.Normal) && sicaklik < ((int)HavaSicakligi.CokSicak))
            {
                Console.WriteLine("Dışarı çıkılabilir");
            }
        }
    }

    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaSicakligi
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
