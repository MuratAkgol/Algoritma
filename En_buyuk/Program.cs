using System;

namespace En_buyuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odada kaç kişi var?");
            int Mamber = Convert.ToInt32(Console.ReadLine());
            Count(Mamber);            
        }
        public static void Count(int a)
        {
            decimal c = 1;
            decimal d = 1;
            decimal e = a - 2;
            for (int i = 1; i <= a; i++)
            {
                c = c * i;
               
                if (i == a)
                {
                    //Console.WriteLine(c);
                }
            }

            for (int i = 1; i <= e; i++)
            {
                d = d * i;
                if (i == e)
                {
                    Console.WriteLine(c/(2*d) + " defa el sıkışılır.");
                    Console.ReadLine() ;
                }
            }
        }
    }
}
