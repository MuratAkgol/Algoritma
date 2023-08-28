using System;

namespace faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            decimal c = 1;
            for (int i = 1; i < a+1; i++)
            {
              
                //int b = 1;
                c = c * i;
               
                if (i == a)
                {
                    Console.WriteLine(c);
                }
            }
            
        Console.ReadLine();
        }
    }
}
