﻿namespace MathGameProject
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                firstNumber = random.Next(1, 100);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------------------");

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("-----------------------------\n");
            Console.WriteLine($"Press any key to go back to the menu.");
            Console.ReadLine();
        }

        internal static void AddToHistory(int score, string name)
        {
            games.Add($"{DateTime.Now} - {name}: {score} pts");
        }

        internal static void OutputInvalidCommand()
        {
            Console.WriteLine("Invalid command. Input a valid command.");
        }
    }
}