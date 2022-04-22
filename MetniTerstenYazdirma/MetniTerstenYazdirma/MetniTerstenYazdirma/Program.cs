using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetniTerstenYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir metin giriniz!");
            string metin = Console.ReadLine();
            Console.WriteLine("Metninizin ters hali:");
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                Console.Write(metin[i]);
               
            }
            Console.Read();
        }
    }
}
