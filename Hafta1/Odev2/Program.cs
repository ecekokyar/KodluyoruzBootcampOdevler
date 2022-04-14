using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Kullanıcıdan sayı al.
            //2.Sayının asal olup olmadığını bul.
            //3.Kullanıcıya sayının asallığı hakkında geri dönüş yap.

            
            Console.WriteLine("Bir sayı giriniz: ");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number == 2 || number == 3 || number == 5 || number == 7)
                Console.WriteLine($"{number} asal sayıdır.");
            else if (number==0 || number==1 || number%2 ==0 || number%3 ==0 || number%5 ==0 || number%7 ==0)
                Console.WriteLine($"{number} asal sayı değildir.");
            else 
                Console.WriteLine($"{number} asal sayıdır.");
        }
    }
}
