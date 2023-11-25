using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace field
{
    internal class Program
    {
        static int[,] createMatrix(int a, int b)
        {
            // vytvoří se matice a * b
            int numberToAdd;
            int[,] matrix = new int[a, b];
            numberToAdd = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numberToAdd;
                    numberToAdd++;
                }
            }
            return matrix;
        }

        static int[,] matrixChangeElemennt(int xFirst, int yFirst, int xSecond, int ySecond, int[,] matrix)
        {
            //prohození dvou prvků v matici
            int first, second;
            first = matrix[xFirst, yFirst];
            second = matrix[xSecond, ySecond];
            matrix[xFirst, yFirst] = second;
            matrix[xSecond, ySecond] = first;
            return matrix;
        }

        static int[,] matrixChangeLine(int xFirst, int xSecond, int[,] matrix)
        {
            //prohození dvou řádků v matici
            int first, second;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                first = matrix[xFirst, j];
                second = matrix[xSecond, j];
                matrix[xFirst, j] = second;
                matrix[xSecond, j] = first;
            }
            return matrix;
        }

        static int[,] matrixChangeColumn(int yFirst, int ySecond, int[,] matrix)
        {
            //prohození dvou sloupců v matici
            int first, second;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                first = matrix[i, yFirst];
                second = matrix[i, ySecond];
                matrix[i, yFirst] = second;
                matrix[i, ySecond] = first;
            }
            return matrix;
        }
        static int[,] matrixChangeDiagonal(int[,] matrix)
        {
            //otáčení prvků na hlavní diagonále
            int number1, number2, lenght;
            if (matrix.GetLength(0) < matrix.GetLength(1))
            {
                lenght = matrix.GetLength(0);
            }
            else
            {
                lenght = matrix.GetLength(1);
            }
            for (int i = 0; i < lenght / 2; i++)
            {
                number1 = matrix[i, i];
                number2 = matrix[lenght - 1 - i, lenght - 1 - i];
                matrix[i, i] = number2;
                matrix[lenght - 1 - i, lenght - 1 - i] = number1;
            }
            return matrix;
        }
        static int[,] matrixChangeDiagonal2(int[,] matrix)
        {
            //otáčení prvků na vedlejší diagonále
            int number1, number2, lenght;
            if (matrix.GetLength(0) < matrix.GetLength(1))
            {
                lenght = matrix.GetLength(0);
            }
            else
            {
                lenght = matrix.GetLength(1);
            }
            for (int i = 0; i < lenght / 2; i++)
            {
                number1 = matrix[i, matrix.GetLength(1) - 1 - i];
                number2 = matrix[matrix.GetLength(1) - 1 - i, i];
                matrix[i, matrix.GetLength(1) - 1 - i] = number2;
                matrix[matrix.GetLength(1) - 1 - i, i] = number1;
            }
            return matrix;
        }
        static int[,] multiplication(int[,] matrix, int number)
        {
            //program vynásobí matici číslem
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = number * matrix[i, j];
                }
            }
            return matrix;
        }
        static int[,] multiplicationLine(int[,] matrix, int number, int line)
        {
            //program vynásobí řádek matice číslem
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[line, j] = number * matrix[line, j];
            }
            return matrix;
        }
        static int[,] matrixTransition(int[,] matrix, int a, int b)
        {
            //transpozice matice
            int[,] matrix2 = createMatrix(b, a);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    matrix2[j, i] = matrix[i, j];
                }
            }
            return matrix2;
        }
        static int[,] createMatrix2(int a, int b, int number)
        {
            // vytvoří se matice a * b
            int numberToAdd;
            int[,] matrix2 = new int[a, b];
            numberToAdd = number;
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = numberToAdd;
                    numberToAdd++;
                }
            }
            return matrix2;
        }
        static int[,] matrixSum(int[,] matrix, int[,] matrix2) 
        {
            //sečtou se matice 1 a 2
            int[,] sumMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    sumMatrix[i,j] = matrix[i,j] + matrix2[i,j];
                }
            }
            return sumMatrix;
        }
        static int[,] matrixDifference(int[,] matrix, int[,] matrix2)
        {
            //odečtou se matice 1 a 2
            int[,] differenceMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    differenceMatrix[i, j] = matrix2[i, j] - matrix[i, j];
                }
            }
            return differenceMatrix;
        }
        static int[,] matrixMultiplication(int[,] matrix, int[,] matrixSec)
        {
            int sum, lenght;
            int[,] multiplicMat = new int[matrix.GetLength(0), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            { 
                for (int j = 0; j < matrixSec.GetLength(1); j++)
                {
                    sum = 0;
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        sum += (matrix[i, k] * matrixSec[k, j]);
                    }
                    multiplicMat[i, j] = sum;
                }
            }
            return multiplicMat;
        }
        static void Main(string[] args) 
        {
            int a, b, xFirst, yFirst, xSecond, ySecond, number, line;
            bool successA, successB, succesXFirst, succesYFirst, succesXSecond, succesYSecond, succesNumber, succesLine;
            string choice;
            a = 0;
            b = 0;
            number = 0;
            line = 0;
            xFirst = 0;
            yFirst = 0;
            xSecond = 0;
            ySecond = 0;
            successA = false;
            successB = false;
            succesNumber = false;
            succesLine = false;
            succesXFirst = false; 
            succesYFirst = false;
            succesXSecond = false;
            succesYSecond = false;

            // program se dokola ptá na celé čísla a,b než je uživatel zadá. Poté si vytvoří matice a*b
            while (successA == false) 
            {
                Console.WriteLine("Zatím nebylo zadané celé číslo a. Zadej celé číslo a. Matice bude mít a řádků");
                successA = int.TryParse(Console.ReadLine(), out a);
            }
            while (successB == false)
            {
                Console.WriteLine("Zatím nebylo zadané celé číslo b. Zadej celé číslo b. Matice bude mít b sloupců");
                successB = int.TryParse(Console.ReadLine(), out b);
            }
            int[,] matrix = createMatrix(a, b);

            //matice se vypíše do konzole
            Console.WriteLine("Matice vypadá takto: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Vyber, co chceš aby se s maticí stalo:");
            Console.WriteLine("pp(prohození prvků), pr(prohození řádků), ps( sloupců), " +
                "phd(prohození čísel na hlavní diagonále), pvd(prohození čísel na vedlejší diagonále)," +
                "n(násobení matice číslem), nr(násobení řádku matice číslem), t(transpozice matice)," +
                "s(součet dvoumatic), r(rozdíl dvou matic), nm(násobení matic)");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "pp":
                    //program prohodí vybrané prvky
                    while (succesXFirst == false)
                    {
                        Console.WriteLine("Zadej řádek na kterém leží první prvek");
                        succesXFirst = int.TryParse(Console.ReadLine(), out xFirst);
                    }
                    while (succesYFirst == false)
                    {
                        Console.WriteLine("Zadej sloupec na kterém leží první prvek");
                        succesYFirst = int.TryParse(Console.ReadLine(), out yFirst);
                    }
                    while (succesXSecond == false)
                    {
                        Console.WriteLine("Zadej řádek na kterém leží druhý prvek");
                        succesXSecond = int.TryParse(Console.ReadLine(), out xSecond);
                    }
                    while (succesYSecond == false)
                    {
                        Console.WriteLine("Zadej sloupec na kterém leží druhý prvek");
                        succesYSecond = int.TryParse(Console.ReadLine(), out ySecond);
                    }
                    matrix = matrixChangeElemennt(xFirst, yFirst, xSecond, ySecond, matrix);

                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "pr":
                    //program prohodí vybrané řádky
                    while (succesXFirst == false)
                    {
                        Console.WriteLine("Zadej první řádek který chceš prohodit");
                        succesXFirst = int.TryParse(Console.ReadLine(), out xFirst);
                    }
                    while (succesXSecond == false)
                    {
                        Console.WriteLine("Zadej druhý řádek který chceš prohodit");
                        succesXSecond = int.TryParse(Console.ReadLine(), out xSecond);
                    }
                    matrix = matrixChangeLine(xFirst, xSecond, matrix);

                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "ps":
                    //program prohodí vybrané sloupce
                    while (succesYFirst == false)
                    {
                        Console.WriteLine("Zadej první sloupec který chceš prohodit");
                        succesYFirst = int.TryParse(Console.ReadLine(), out yFirst);
                    }
                    while (succesYSecond == false)
                    {
                        Console.WriteLine("Zadej druhý sloupec který chceš prohodit");
                        succesYSecond = int.TryParse(Console.ReadLine(), out ySecond);
                    }
                    matrix = matrixChangeColumn(yFirst, ySecond, matrix);

                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "phd":
                    //program prohodí prvky na hlavní diagonále
                    matrix = matrixChangeDiagonal(matrix);
                    //program vypíše pozmněněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "pvd":
                    //program prohodí prvky na vedlejší diagonále
                    matrix = matrixChangeDiagonal2(matrix);
                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "n":
                    //program vynásobí celou matici číslem
                    while (succesNumber == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané celé číslo, kterým se má matice vynásobit. Napiš celé číslo, kterým se bude matice násobit");
                        succesNumber = int.TryParse(Console.ReadLine(), out number);
                    }
                    matrix = multiplication(matrix, number);
                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "nr":
                    //program vynásobí vybraný řádek matice číslem
                    while (succesNumber == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané celé číslo, kterým se má matice vynásobit. Napiš celé číslo, kterým se bude matice násobit");
                        succesNumber = int.TryParse(Console.ReadLine(), out number);
                    }
                    while (succesLine == false)
                    {
                        Console.WriteLine("Zatím nebyl zasán řádek, který se má číslem vynásobit. Napiš řádek, který se bude v matici násobit");
                        succesLine = int.TryParse(Console.ReadLine(), out line);
                    }
                    matrix = multiplicationLine(matrix, number, line);
                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "t":
                    //transpozice matice
                    matrix = matrixTransition(matrix, a, b);
                    //program vypíše pozměněnou matici
                    Console.WriteLine("Matice vypadá takto: ");
                    for (int i = 0; i < b; i++)
                    {
                        for (int j = 0; j < a; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "s":
                    //vytvoří se druhá matice
                    while (succesNumber == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané celé číslo, kterým ¨má začínat matice, která bude přičtena k té původní. Napiš celé číslo, kterým bude druhá matice začínat");
                        succesNumber = int.TryParse(Console.ReadLine(), out number);
                    }
                    int[,] matrix2 = createMatrix2(a, b, number);

                    //druhá matice se vypíše do konzole
                    Console.WriteLine("Druhá matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrix2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");

                    //vytvoří se součet matic a nová matice se vypíše do konzole
                    int[,] sumMatrix = matrixSum(matrix, matrix2);
                    Console.WriteLine("Součet matic vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(sumMatrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "r":
                    //vytvoří se druhá matice
                    while (succesNumber == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané celé číslo, kterým ¨má začínat matice, od které bude odečtena ta původní. Napiš celé číslo, kterým bude druhá matice začínat");
                        succesNumber = int.TryParse(Console.ReadLine(), out number);
                    }
                    int[,] matrixSecond = createMatrix2(a, b, number);

                    //druhá matice se vypíše do konzole
                    Console.WriteLine("Druhá matice vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(matrixSecond[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");

                    //vytvoří se rozdíl matic a nová matice se vypíše do konzole
                    int[,] differenceMatrix= matrixDifference(matrix, matrixSecond);
                    Console.WriteLine("Rozdíl matic vypadá takto: ");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write(differenceMatrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
                case "nm":
                    //vytvoří se druhá matice
                    while (succesNumber == false)
                    {
                        Console.WriteLine("Zatím nebylo zadané celé číslo, kterým ¨má začínat matice, kterou bude vznásobena to původní. Napiš celé číslo, kterým bude druhá matice začínat");
                        succesNumber = int.TryParse(Console.ReadLine(), out number);
                    }
                    int[,] matrixSec = createMatrix2(b, a, number);

                    //druhá matice se vypíše do konzole
                    Console.WriteLine("Druhá matice vypadá takto: ");
                    for (int i = 0; i < b; i++)
                    {
                        for (int j = 0; j < a; j++)
                        {
                            Console.Write(matrixSec[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");

                    int[,] multiplicMat = matrixMultiplication(matrix, matrixSec);
                    Console.WriteLine("Součin matic vypadá takto: ");
                    for (int i = 0; i < multiplicMat.GetLength(0); i++)
                    {
                        for (int j = 0; j < multiplicMat.GetLength(1); j++)
                        {
                            Console.Write(multiplicMat[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n");
                    break;
            }
        }
    }
}