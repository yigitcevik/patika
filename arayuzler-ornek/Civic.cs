namespace arayuzler_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public int KacTekerlekVar()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Gri;
        }
    }
}