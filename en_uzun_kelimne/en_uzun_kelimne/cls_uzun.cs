using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace en_uzun_kelimne
{
    internal class cls_uzun
    {
        public static string uzun_olan(string kelime)
        {
            string[] ayir = kelime.Split(' ');
            string enUzunKelime = ""; 

            foreach (string kelimeParcasi in ayir)
            {
                if (kelimeParcasi.Length > enUzunKelime.Length)
                {
                    enUzunKelime = kelimeParcasi;
                }
            }

            return enUzunKelime;
        }

    }
}
