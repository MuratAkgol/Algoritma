using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en_uzun_kelimne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bİr cümle giriniz");
            string cümle = Console.ReadLine();

            Console.WriteLine("Bu metindeki en uzun kelime: "+cls_uzun.uzun_olan(cümle));

            Console.ReadLine();
        }
    }
}
