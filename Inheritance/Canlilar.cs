using System;

public class Canlilar // kalıtımı engellemek için "public sealed class Canlilar" şeklinde kullan.
{
    protected void Beslenme()
    {
        Console.WriteLine("Canlılar beslenir.");
    }

    protected void Solunum()
    {
        Console.WriteLine("Canlılar solunum yapar.");
    }

    protected void Bosaltim()
    {
        Console.WriteLine("Canlılar boşaltım yapar.");
    }

    public virtual void UyaranlaraTepki()
    {
        Console.WriteLine("Canlılar uyaranlara tepki verir");
    }
}