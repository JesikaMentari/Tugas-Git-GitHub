/*
Created by Jesika Mentari 2207125055
*/

using System;

namespace HelloWorld_Statement_Operator_Variabel
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            const int a = 1;
            const int b = 2;
            const int c = 3;

            const int hasilTambah = a + b +  c;
            const int hasilKali = a * b * c;
            int tambah = a + b + c;
            int kali = a * b * c;
            int kurang = a - b - c;
            int bagi = a / b / c;

            Console.WriteLine("Hello World"); 

            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + tambah);
            Console.WriteLine("- Jika dikalikan hasilnya " + kali);
            Console.WriteLine("- Jika dikurangkan hasilnya " + kurang);
            Console.WriteLine("- Jika dibagikan hasilnya " + bagi);
            Console.Write("\n\nEnter Code : ");

            Console.WriteLine(hasilTambah);
            Console.WriteLine(hasilKali);

            Console.ReadKey();
        }
    }
}