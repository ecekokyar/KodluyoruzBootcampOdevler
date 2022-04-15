using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liste içinde birden fazla olan öğeleri bir kez yazdırma

            List<string> cities = new List<string>() {"Ankara","Ankara","Ankara","Sinop","İstanbul","İstanbul","Eskişehir","Ankara"};

            List<string> newColection=cities.Distinct().ToList();
            // C# Linq Distinct Metodu:
            // Koleksiyonda bulunan verilerin tekrarlayan kayıtların tekrarlanmamasını sağlar.

            foreach (var city in newColection)
            {
                Console.WriteLine(city);
            }
        }
    }
}
