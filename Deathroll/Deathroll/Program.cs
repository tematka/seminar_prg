﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu (lze udelat i rekurzi).
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo.
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 0-1000, padne mu 920. Druhy hrac rolluje 0-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 0 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */
          
            int goldComputer, goldPLayer, roll, round, sazka;
            Random rnd = new Random();

            Console.WriteLine("Napiš výchozí gold hráče");
            goldPLayer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napiš výchozí gold počítače");
            goldComputer = Convert.ToInt32(Console.ReadLine());

            while(goldComputer > 0 && goldPLayer > 0)
            {
                Console.WriteLine("Kolik vsadíš?(Hodnota musí být alesúpoň 2)");
                sazka = Convert.ToInt32(Console.ReadLine());

                if(sazka > goldPLayer || sazka > goldComputer)
                {
                    Console.WriteLine("Ty nebo počítač nemáš na tokovou sázku dostatečný gold");
                }
                else
                {
                    round = 0;
                    roll = sazka;
                    while (roll != 1) 
                    {
                        if(round %2  == 0)
                        {
                            roll = rnd.Next(1, roll);
                            Console.WriteLine("Hráč rollnul " + roll);
                            if(roll == 1)
                            {
                                Console.WriteLine("Prohrál si");
                                goldComputer += sazka;
                                goldPLayer -= sazka;
                            }
                        }
                        else
                        {
                            roll = rnd.Next(1, roll);
                            Console.WriteLine("Počítač rollnul" + roll);
                            if (roll == 1)
                            {
                                Console.WriteLine("Vyhrál si");
                                goldComputer -= sazka;
                                goldPLayer += sazka;
                            }
                        }
                        round++;
                    }
                    Console.WriteLine("Gold hráče je " + goldPLayer);
                    Console.WriteLine("Gold počítače je " + goldComputer);
                }
            }

            bool success = float.TryParse(Console.ReadLine(), out float loadedNumber);
            
            Console.ReadKey();
        }
    }
}
