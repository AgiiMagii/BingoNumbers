using System;
using System.Collections.Generic;

namespace MajasDarbsSuperBingo
{
    internal class Program
    {
        static Random rnd = new Random();
        static int numCount = 10;
        static void Main(string[] args)
        {
            List<int> bingo = bingoNumber();
            List<int> guess = guessNumber();
            Console.Clear();
            int points = yourPoints(bingo, guess);
            messages(points);
            Console.ReadLine();
        }
        static List<int> bingoNumber()
        {
            List<int> bingoN = new List<int>();
            for (int i = 1; i <= numCount;)
            {
                int generatedNumb = rnd.Next(1, 100);
                if (!bingoN.Contains(generatedNumb))
                {
                    bingoN.Add(generatedNumb);
                    i++;
                }
            }
            return bingoN;
        } //Make a list of randomly generated unique integers
        static List<int> guessNumber()
        {
            List<int> guessN = new List<int>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n     GUESS THE NUMBERS!\n");
            Console.ResetColor();
            Console.WriteLine($"(write {numCount} unique integers in range 1 to 99)\n");
            
            for (int j = 1; j <= numCount;)
            {
                Console.Write($"{j}. ");
                int guess;
                bool result = int.TryParse(Console.ReadLine(), out guess);
                
                if (guess < 1 || guess >= 100)
                {
                    Console.WriteLine("Invalid integer! Try again!");
                }
                else if (result == false)
                {
                    Console.WriteLine("Not an integer! Try again!");
                }
                else if (guessN.Contains(guess))
                {
                    Console.WriteLine("Not unique integer! Try again!");
                }
                else
                {
                    j++;
                    guessN.Add(guess);
                }
                
            }
            return guessN;
        } //Make a list of user-entered integers
        static int yourPoints(List<int> bingo, List<int> guess)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("\n     LET'S SEE HOW YOU DID:\n");
            Console.ResetColor();
            Console.Write("Bingo numbers \t");
            foreach (int generatedNumber in bingo)
            {
                if (guess.Contains(generatedNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(generatedNumber + "\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(generatedNumber + "\t");
                }
            }
            int points = 0;
            Console.Write("\nYour numbers \t");
            foreach (int guessN in guess)
            {
                if (bingo.Contains(guessN))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(guessN + "\t");
                    Console.ResetColor();
                    points++;
                }
                else
                {
                    Console.Write(guessN + "\t");
                }
            }
            return points;
        } //Count matching integers, show the result
        static void messages(int points)
        {
            Console.WriteLine("\n");
            {
                if (points == 0)
                {
                    Console.WriteLine($"You earned {points} points");
                    Console.WriteLine(" COME ON... YOU CAN DO BETTER!!");
                }
                else if (points == 1)
                {
                    Console.WriteLine($"You earned {points} point");
                    Console.WriteLine(" COME ON... YOU CAN DO BETTER!!");
                }
                else if (points >= 1 && points < 3)
                {
                    Console.WriteLine($"You earned {points} points");
                    Console.WriteLine(" KEEP TRYING! YOU CAN DO IT!!");
                }
                else if (points >= 3 && points < 5)
                {
                    Console.WriteLine($"You earned {points} points");
                    Console.WriteLine(" OK! GOOD!");
                }
                else if (points >= 5 && points < 7)
                {
                    Console.WriteLine($"You earned {points} points");
                    Console.WriteLine(" GOOOOOD!!");
                }
                else if (points == 7)
                {
                    Console.WriteLine($"You earned {points} points");
                    Console.WriteLine(" !!! BINGOOOO !!!");
                }
                else
                {
                    Console.WriteLine("OOPS!! Something went wrong!!");
                }
            }
        } //Show comments depending on gathered points
    }
}
