using System;
using System.Collections;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boyut girin: ");  
            int count = int.Parse(Console.ReadLine());  
            for (int i = 0; i < count; i++) {  
                for (int j = 0; j <= i; j++) {  
                    Console.Write("*");  
                }  
                Console.Write("\n");  
            }  
        }
    }
}
