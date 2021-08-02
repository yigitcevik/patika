using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.Write("İşlem tamamlandı");
            }

            try
            {
                int a = int.Parse("test");
                int b = int.Parse("-21345678903");
            }
            catch (ArgumentNullException ex)
            {   
                Console.WriteLine("Boş Değer");
                Console.WriteLine(ex.Message.ToString());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi yanlış");
                Console.WriteLine(ex.Message.ToString());
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük değer");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                Console.Write("İşlem tamamlandı");
            }


        }
    }
}
