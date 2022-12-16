/*
created by Jesika Mentari -2207125055
*/

using System;

namespace GameAduDadu
{
    class Program
    {
        static void Main(string[] args)
        {
            int ronde = 0;
            int daduA, daduB, skorA=0, skorB=0;
            Random rng = new Random();

            for(ronde = 1; ronde <=10; ronde++)
            {
                Console.WriteLine("Pada permainan kali ini, anda dan komputer akan bermain 10 ronde");
                Console.WriteLine("Setiap putaran dadu akan dilempar dan menghasilkan nilai tertentu");
                Console.WriteLine("Nilai dadu tertinggi akan menentukan pemenangnya");
                Console.WriteLine("Siapa yang akan menang? Selamat bermain..");
                Console.WriteLine("\nMulai?"); Console.ReadKey();

                Console.WriteLine("\nKomputer Melempar Dadu"); daduA = rng.Next(1,7);
                Console.WriteLine("Nilai Dadu: " + daduA);

                Console.WriteLine("\nPlayer Melempar Dadu"); daduB = rng.Next(1,7);
                Console.WriteLine("Nilai Dadu : " +daduB);
                Console.ReadKey();

                Console.WriteLine("\nDadu Komputer: " + daduA);
                Console.WriteLine("Dadu Player: " + daduB);
                if(daduA > daduB)
                {
                    Console.WriteLine("Komputer Menang");
                    skorA++;
                }   
                else if(daduA < daduB)
                {
                    Console.WriteLine("Player Menang");
                    skorB++;
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                if(ronde < 10)
                {
                    Console.WriteLine("\nSkor Sementara: ");
                    Console.WriteLine("- Skor Komputer: " +skorA);
                    Console.WriteLine("- Skor Player: " +skorB);
                }
                Console.WriteLine("\nLanjut ke ronde berikutnya..");
                Console.ReadKey();
            }

            Console.WriteLine("\nSkor Akhir: ");
            Console.WriteLine("-Skor Komputer: " +skorA);
            Console.WriteLine("- Skor Player: " +skorB);

            if(skorA > skorB)
            {
                Console.WriteLine("\nPLAYER KALAH!");
            }
            else if(skorA < skorB)
            {
                Console.WriteLine("\nPLAYER MENANG!!");
            }
            else
            {
                Console.WriteLine("\nPERMAINAN SERI");
            }

            Console.ReadKey();
        }
    }
}