/*
Created by Jesika Mentari -2207125055
*/

using System;
using System.Collections.Generic;

namespace tebakKata
{
    class Program
    {
        static int Kesempatan = 5;
        static string KataMisteri = "MENTARI";
        static List<string> ListTebakan = new List<String>{};
        
    static void Main(string[] args)
        {
            Intro();
            PlayGame();
        }
    
    static void Intro()
    {
        Console.WriteLine("Haii Kamu..");
        Console.WriteLine("Ayo Bermain Tebak Kata Denganku..");
        Console.WriteLine($"Kamu Mempunyai {Kesempatan} Kesempatan Untuk Menebak Kata Misteri!!!");
        Console.WriteLine("Petunjuk Kata Misteri Adalah Nama Lain Dari Matahari");
        Console.WriteLine($"Kata Tersebut Terdiri Dari {KataMisteri.Length} Huruf");
        Console.WriteLine("Ayo Tebak!!");
    }
    
    static void PlayGame()
    {
        while(Kesempatan>0)
        {
            Console.Write("Apa Huruf Tebakanmu? ");
            Console.WriteLine("Pilih A-Z : ");
            string input = Console.ReadLine();
            ListTebakan.Add(input);
            if(CekJawaban(KataMisteri, ListTebakan))
            {
                Console.WriteLine("Selamat Kamu Berhasil Menebaknya...");
                Console.WriteLine($"Kata misterinya {KataMisteri}");
                break;
            }
            else if(KataMisteri.Contains(input))
            {
                Console.WriteLine("Hebat! Kamu Berhasil Menebaknya!");
                Console.WriteLine(CekHuruf(KataMisteri, ListTebakan));
            }else
            {
                Console.WriteLine("Sayang Sekali Tebakan Kamu Salah!");
                Kesempatan--;
                Console.WriteLine($"Sisa {Kesempatan} kesempatan");
            }

            if(Kesempatan == 0)
            {
                EndGame();
                break;
            }
        }
    
    }

    static bool CekJawaban(string KataRahasia, List<string> list)
    {
        bool status = false;
        for (int i = 0 ; i < KataRahasia.Length; i++)
        {
            string c = Convert.ToString(KataRahasia[i]);
            if(list.Contains(c)){
                status = true;
            }else{
                return status = false;
            }
        }

        return status;
    }

    static string CekHuruf(string KataRahasia, List<string> list)
    {
        string x = "";

        for (int i=0; i < KataRahasia.Length; i++)
        {
            string c = Convert.ToString(KataRahasia[i]);
            if(list.Contains(c))
            {
                x = x + c;
            }else
            {
                x = x + "-";
            }
        }

        return x;
    }

    static void EndGame()
    {

    
    {
        Console.WriteLine("Kesempatan Telah Habis...");
        Console.WriteLine("Permainan Berakhir");
    }

    }
    }
}