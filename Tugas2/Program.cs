/*
created by Jesika Mentari -2207125055
*/

using System;

namespace tebakKode
{
    class Program
    {
        public static int codeA; public static int codeB; public static int codeC;
        public static int hasilTambah; public static int hasilKali;
        public static int kesempatan;
        public static int level;
        public static String tebakanA; public static String tebakanB; public static String tebakanC;
        public static bool bGameStart;

        public static int jumlahLevel = 5;


        static void Main(string[] args)
        {
            level = 0;
            Init();
            while (level <= jumlahLevel)
            {
                if (kesempatan > 0)
                {
                    PlayGame();
                }
                else
                {
                    ShowEnd(false);
                    break;
                }

            }
            if (level > jumlahLevel)
            {
                winner();
            }
            Console.Write("Tekan enter untuk keluar..."); Console.ReadKey();
        }
        static void Init()
        {
            level += 1;
            kesempatan = 3;

            codeA = randomNumber();
            codeB = randomNumber();
            codeC = randomNumber();

            hasilTambah = codeA + codeB + codeC;
            hasilKali = codeA * codeB * codeC;
        }

        static void winner()
        {
            Console.WriteLine("Selamat Anda Menang..\n");
        }

        static int randomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, level+1);
            return number;
        }

        static void Intro()
        {
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui");
            Console.WriteLine("Level " + level);
            Console.WriteLine("- Password terdiri dari3 angka");
            Console.WriteLine("- Jika ditambah hasilnya " +hasilTambah);
            Console.WriteLine("-Jika dikali hasilnya " + hasilKali);
        }

        static void PlayGame()
        {
            Intro();
            Console.Write("\nMasukkan Kode Pertama : "); tebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode Kedua : "); tebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode Ketiga : "); tebakanC = Console.ReadLine();

            if (tebakanA == codeA.ToString() && tebakanB == codeB.ToString() && tebakanC == codeC.ToString())
            {
                Console.WriteLine("\nSelamat Jawaban Kamu BENAR");
                Init();
            }
            else
            {
                Console.WriteLine("\nSayang Sekali Jawaban Kamu SALAH");
                kesempatan--;
                TryAgain();
            }
        }

        static  void ShowEnd(bool b)
        {
            Console.Clear();
            if (b && kesempatan <= 3)
            {
                Console.WriteLine("Selamat Jawaban Kamu Benar!\n\nKAMU MENANG");
            }
            else
            {
                Console.WriteLine("Kesempatan Habis!!\n\nKAMU KALAH!!");
            }
            bGameStart = false;
        }

        static void TryAgain()
        {
            Console.Clear();
            Console.WriteLine("Jawaban Kamu Salah, COBA LAGI!\nKesempatan anda tersisa " + (kesempatan) + "\n");
        }
    }
}