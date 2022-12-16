//by Jesika Mentari, NIM 2207125055
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SOAL5
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesalahan = 0;
            String jawaban = "";
            bool salah = false, menang = false, kalah = false, benar = false;
            Console.Clear();
            string[] kesempatan = new string[10];
            kesempatan[0] = "apel";
            kesempatan[1] = "jeruk";
            kesempatan[2] = "semangka";
            kesempatan[3] = "ceri";
            kesempatan[4] = "pisang";
            kesempatan[5] = "pepaya";
            kesempatan[6] = "jambu";
            kesempatan[7] = "nanas";
            kesempatan[8] = "alpukat";
            kesempatan[9] = "mangga";
            Random randGen = new Random();
            var random = randGen.Next(0, 9);
            string kesempatanGame = kesempatan[random];
            char[] guess = new char[kesempatanGame.Length];
 
            for (int p = 0; p < kesempatanGame.Length; p++) 
            {
                guess[p] = '_';
            }
 
            while (menang == false && kalah == false)
            {
                Console.Write("Huruf Tebakan : ");
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < kesempatanGame.Length; j++)
                {
                    if (playerGuess == kesempatanGame[j]) {
                        benar = true;
                        guess[j] = playerGuess;
                    } else if (j == kesempatanGame.Length - 1 && benar == false)
                    {
                        salah = true;
                    }
                }
                Console.Clear();
                jawaban = new String(guess);
                if (salah == true) 
                {
                    Console.WriteLine("Tebakan anda salah.");
                    kesalahan++;
                    salah = false;
                }
                benar = false;
                Console.WriteLine(guess);
                Console.WriteLine();
                switch (kesalahan)
                {
                    case 1:
                        Console.WriteLine("|__");
                        break;
                    case 2:
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 3:
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 4:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 5:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 6:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 7:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 8:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 9:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("|__");
                        break;
                    case 10:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("|__");
                        break;

                    default:
                        break;
                }

                if (jawaban == kesempatanGame) 
                {
                    Console.WriteLine("Selamat, anda menang!");
                    menang = true;
                } else if (kesalahan == 10 && jawaban != kesempatanGame) 
                {
                    Console.WriteLine("Anda kurang beruntung.");
                    kalah = true;
                }
            }
        }
    }
}