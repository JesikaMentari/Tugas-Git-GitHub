//by Jesika Mentari, NIM 2207125055
using System;
using System.Collections.Generic;

namespace SOAL1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama          : ");
            string name = Console.ReadLine();
            Console.Write("NIM           : ");
            string NIM = Console.ReadLine();
            Console.Write("konsentrasi   :  ");
            string konsentrasi = Console.ReadLine();
            Console.WriteLine("|*******************************|");
            Console.WriteLine("|Nama :         \t{0}\t|",name);
            Console.WriteLine("|NIM  :           \t{0}\t|",NIM);
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("|konsentrasi :         \t{0}\t|",konsentrasi);
            Console.WriteLine("|*******************************|");
            Console.ReadLine();
        }
    }
}