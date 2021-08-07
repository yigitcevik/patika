namespace arayuzler_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public int KacTekerlekVar()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Beyaz;
        }
    }
}