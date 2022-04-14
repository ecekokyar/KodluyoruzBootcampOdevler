using System;
using System.Collections.Generic;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1'den 10.000'e kadar tüm asal sayılar

            int number=1;
            bool status =true;

            while (number<10000)
            {
                number++;
                for (int i = 2; i <number; i++)
                {
                    if (number%i==0)
                    {
                        status=false;
                    }

                }
                if (status==true)
                {
                    Console.WriteLine(number);
                }
                status=true;
            }
            
           
           

            
        }
    }
}
