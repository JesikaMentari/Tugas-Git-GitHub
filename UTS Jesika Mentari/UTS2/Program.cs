//by Jesika Mentari, NIM 2207125055
using System;
using System.Collections.Generic;

namespace SOAL2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rate = 15363;
            try
            {
                Console.WriteLine("Rate USD ke RP");
                Console.WriteLine("$" +Rate);
                Console.Write("Jumlah USD     :$");
                double USD = double.Parse(Console.ReadLine());
                double RP = Rate*USD;
                Console.WriteLine("Hasil Konversi : Rp.{0}", RP);
                Console.ReadLine();
            }
            catch(FormatException)
            {
            Console.WriteLine("salah input");
            }
        }
    }
}