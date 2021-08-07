using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler =  new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("**********************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();
        }
    }
}
