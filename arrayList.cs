using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            Console.WriteLine(liste[1]);

            

            Console.WriteLine("********* Add Range **********");
            string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(sayilar);
            liste.AddRange(renkler);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("********* Sort **********");
            //liste.Sort(); // sıralamak için aynı tür değişken olmalı

            Console.WriteLine("********* Binary Search **********");
            Console.WriteLine(liste.BinarySearch(3)); // search den önce sıralanması gerekmekte.

            Console.WriteLine("********* Reverse **********");
            liste.Reverse();

            Console.WriteLine("********* Clear **********");
            liste.Clear();
        }
    }
}
