using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static double soucet(double a, double b)
        {
            double vysledek = a + b;
            return vysledek;
        }
        static double rozdil(double a, double b)
        {
            double vysledek = a - b;
            return vysledek;
        }
        static double soucin(double a, double b)
        {
            double vysledek = a * b;
            return vysledek;
        }
        static double podil(double a, double b)
        {
            double vysledek = a / b;
            return vysledek;
        }
        static double mocnina(double a, double b)
        {
            double vysledek = Math.Pow(a, b);
            return vysledek;
        }
        static int modulo(int c)
        {
            int vysledek = c % 2;
            return vysledek;
        }
        static int vysledekDeleni(int c)
        {
            int vysledek;
            if (c % 2 == 0)
            {
                vysledek = c / 2;
            }
            else
            {
                vysledek = (c - 1) / 2;
            }
            return vysledek;
        }
        static int faktorial(int c)
        {
            if(c ==  1)
            {
                return 1;
            }
            int vysledek = c * faktorial(c - 1);
            return vysledek;
        }

        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

            int c, zbytek;
            double a, b, result;
            bool successA, successB, successC;
            string operace, prevod;
            result = 0;
            successA = false;
            successB = false;
            successC = false;
            a = 0;
            b = 0;
            c = 0;
            prevod = "";

            Console.WriteLine("Vyber +, -, *, /, m (mocnina), !(faktoriál), d (převod do dvojkové soustavy)");
            operace = Console.ReadLine();

            switch (operace)
            {
                case "+":
                    Console.WriteLine("Zadej čísla a, b. Výpočet bude vypadat jako a + b.");
                    while (successA == false)
                    {
                        Console.WriteLine("Číslu a zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo a.");
                        successA = double.TryParse(Console.ReadLine(), out a);
                    }
                    while (successB == false)
                    {
                        Console.WriteLine("Číslu b zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo b.");
                        successB = double.TryParse(Console.ReadLine(), out b);
                    }
                    result = soucet(a, b);
                    break;
                case "-":
                    Console.WriteLine("Zadej čísla a, b. Výpočet bude vypadat jako a - b.");
                    while (successA == false)
                    {
                        Console.WriteLine("Číslu a zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo a.");
                        successA = double.TryParse(Console.ReadLine(), out a);
                    }
                    while (successB == false)
                    {
                        Console.WriteLine("Číslu b zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo b.");
                        successB = double.TryParse(Console.ReadLine(), out b);
                    }
                    result = rozdil(a, b);
                    break;
                case "*":
                    Console.WriteLine("Zadej čísla a, b. Výpočet bude vypadat jako a * b.");
                    while (successA == false)
                    {
                        Console.WriteLine("Číslu a zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo a.");
                        successA = double.TryParse(Console.ReadLine(), out a);
                    }
                    while (successB == false)
                    {
                        Console.WriteLine("Číslu b zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo b.");
                        successB = double.TryParse(Console.ReadLine(), out b);
                    }
                    result = soucin(a, b);
                    break;
                case "/":
                    Console.WriteLine("Zadej čísla a, b. Výpočet bude vypadat jako a / b.");
                    while (successA == false)
                    {
                        Console.WriteLine("Číslu a zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo a.");
                        successA = double.TryParse(Console.ReadLine(), out a);
                    }
                    while (successB == false)
                    {
                        Console.WriteLine("Číslu b zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo b.");
                        successB = double.TryParse(Console.ReadLine(), out b);
                    }
                    result = podil(a, b);
                    break;
                case "m":
                    Console.WriteLine("Zadej čísla a, b. Výpočet bude vypadat jako a na b.");
                    while (successA == false)
                    {
                        Console.WriteLine("Číslu a zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo a.");
                        successA = double.TryParse(Console.ReadLine(), out a);
                    }
                    while (successB == false)
                    {
                        Console.WriteLine("Číslu b zatím nebyla přiřazená žádná číselná hodnota.Napiš číslo b.");
                        successB = double.TryParse(Console.ReadLine(), out b);
                    }
                    result = mocnina(a, b);
                    break;
                case "!":
                    while (successC == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané žádné číslo k výpočtu faktoriálu. Zadej přirozené číslo:");
                        successC = int.TryParse(Console.ReadLine(), out c);
                    }
                    result = faktorial(c); 
                    break;
                case "d":
                    while (successC == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané žádné číslo k převodu do dvojkové soustavy. Zadej přirozené číslo:");
                        successC = int.TryParse(Console.ReadLine(), out c);
                    }
                    while(c > 0)
                    {
                        zbytek = modulo(c);
                        prevod += zbytek.ToString();
                        c = vysledekDeleni(c);
                    }
                    break;
            }
            if (operace == "d")
            {
                Console.WriteLine("Cislo ve dvojkové soustavě(POZOR, čti pozpátku) je: " + prevod);
            }
            else
            {
                Console.WriteLine("Výsledek je " + result.ToString());
            }
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }   
    }
}
