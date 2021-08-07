using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.KacTekerlekVar().ToString());
            Console.WriteLine(focus.StandartRengi().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarka().ToString());
            Console.WriteLine(civic.KacTekerlekVar().ToString());
            Console.WriteLine(civic.StandartRengi().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarka().ToString());
            Console.WriteLine(corolla.KacTekerlekVar().ToString());
            Console.WriteLine(corolla.StandartRengi().ToString());
        }
    }
}
