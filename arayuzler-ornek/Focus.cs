namespace arayuzler_ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Ford;
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