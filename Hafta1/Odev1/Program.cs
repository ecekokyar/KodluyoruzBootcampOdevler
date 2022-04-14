using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faktöriyel Hesaplama
           try
           {
                Console.WriteLine("Bir sayı giriniz: ");
                int number=Convert.ToInt32(Console.ReadLine());
    
                int factorial=1;
                
                for (int i = 1; i <= number; i++)
                {
                    factorial*=i;                
                }
                Console.WriteLine($"{number}!={factorial}");
           }
           catch (FormatException)
           {
              Console.WriteLine("Lütfen bir sayı giriniz.");
           }
        }
    }
}
