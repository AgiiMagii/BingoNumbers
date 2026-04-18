using System;
using System.Collections.Generic;

namespace MajasDarbsSuperBingo
{
    internal class Program
    {
        static readonly Random rnd = new Random();
        static readonly int numCount = 10;
        static void Main()
        {
            HashSet<int> bingo = BingoNumber();
            HashSet<int> guessList = GuessNumber();
            Console.Clear();
            int points = YourPoints(bingo, guessList);
            Messages(points);
            Console.ReadLine();
        }
        static HashSet<int> BingoNumber() //Make a list of randomly generated unique integers
        {
            HashSet<int> bingo = new HashSet<int>();

            while (bingo.Count < numCount)
            {
                bingo.Add(rnd.Next(1, 100));
            }

            return bingo;
        }
        static HashSet<int> GuessNumber() //Make a list of user-entered integers
        {
            HashSet<int> guessList = new HashSet<int>();
            PrintWithColor("\n     GUESS THE NUMBERS!\n", color: "Yellow");
            Console.WriteLine($"(write {numCount} unique integers in range 1 to 99)\n");

            int j = 1;
            while (j <= numCount)
            {
                Console.Write($" {j}. ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guessN))
                {
                    Console.WriteLine("Not an integer! Try again!");
                }
                else if (guessN < 1 || guessN >= 100)
                {
                    Console.WriteLine("Invalid integer! Try again!");
                }
                else if (!guessList.Add(guessN))
                {
                    Console.WriteLine("Not unique integer! Try again!");
                }
                else
                {
                    j++;
                }
            }
            return guessList;
        }
        static int YourPoints(HashSet<int> bingo, HashSet<int> guessList) //Count matching integers, show the result
        {
            PrintWithColor("\n     LET'S SEE HOW YOU DID:\n", color: "Yellow");

            int points = 0;

            Console.Write("\n Bingo numbers \t");
            foreach (int number in bingo)
            {
                if (guessList.Contains(number))
                {
                    PrintWithColor(number, color: "Green");
                }
                else
                {
                    Console.Write(number + "\t");
                }
            }

            Console.Write("\n Your numbers \t");
            foreach (int number in guessList)
            {
                if (bingo.Contains(number))
                {
                    PrintWithColor(number, color: "Green");
                    points++;
                }
                else
                {
                    Console.Write(number + "\t");
                }
            }

            return points;
        }
        static void Messages(int points) //Show comments depending on gathered points
        {
            Console.WriteLine($"\n\n You earned {points} {(points == 1 ? "point" : "points")}");
            string message = points switch
            {
                0 => " COME ON... YOU CAN DO BETTER!!",
                < 3 => " KEEP TRYING! YOU CAN DO IT!!",
                < 5 => " OK! GOOD!",
                < 7 => " GOOOOOD!!",
                7 => " !!! BINGOOOO !!!",
                _ => " OOPS!! Something went wrong!!"
            };
            Console.WriteLine(message);
        }
        static void PrintWithColor(object value, string color = "White") //Print text in specified color, default is white
        {
            if (!Enum.TryParse(color, true, out ConsoleColor consoleColor))
            {
                consoleColor = ConsoleColor.White;
            }
            Console.ForegroundColor = consoleColor;

            Console.Write(value + "\t");
            Console.ResetColor();
        }
    }
}
