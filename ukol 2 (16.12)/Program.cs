using System;

namespace ukol_2__16._12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);

            if (a > b)
            {
                Console.WriteLine("Cislo {0:F} je vetsi nez {1:F} " ,a,b);
            }  
            else if (a < b)
            {
                Console.WriteLine("Cislo {0:F} je mensi nez {1:F}" ,a,b);
            }
            else
            {
                Console.WriteLine("Cisla {0:F} jsou rovny {1:F} " ,a,b);
            }
            Console.ReadKey();

           

        }
    }
}
