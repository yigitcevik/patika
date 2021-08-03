using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(Topla(a, b)));
            ornek.EkranaYazdir(Convert.ToString(ornek.ArttirTopla(ref a,ref b)));
            ornek.EkranaYazdir(Convert.ToString(a+b));

        }

        static int Topla(int a, int b)
        {
            return a + b;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirTopla(ref int a,ref int b)
        {
            a++;
            b++;
            return a + b;
        }
    }
}
