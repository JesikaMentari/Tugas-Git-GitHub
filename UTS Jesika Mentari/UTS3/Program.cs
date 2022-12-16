//by Jesika Mentari, NIM 2207125055
using System;
using System.Collections.Generic;

namespace SOAL3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama        : ");
            string name = Console.ReadLine();
            Console.Write("Tahun Lahir : ");
            try
            {
                
                int tLahir = int.Parse(Console.ReadLine());
                int umur = 2021 - tLahir;
                if (umur < 10 || umur > 60)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("|       -- Studio 1 --          |");
                    Console.WriteLine("| Nama    :               {0}|", name);
                    Console.WriteLine("| Harga   :         Rp.10000.00|");
                    Console.WriteLine("--------------------------------");
                }else
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("|      -- Studio 1 --          |");
                    Console.WriteLine("| Nama    :               {0}|", name);
                    Console.WriteLine("| Harga   :         Rp.25000.00|");
                    Console.WriteLine("--------------------------------");
                }
            }
            catch(FormatException){
                Console.WriteLine("salah input tahun");
            }
        }
    }
}