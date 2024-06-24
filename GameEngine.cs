﻿namespace MathGameProject
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, 10);
                secondNumber = random.Next(0, 10);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();
                if (!int.TryParse(result, out int answer))
                {
                    Console.WriteLine("Invalid answer");
                    Environment.Exit(1);
                }

                if (answer == (firstNumber + secondNumber))
                {
                    Console.WriteLine("Your answer was correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Addition");
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, 10);
                secondNumber = random.Next(0, 10);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                if (!int.TryParse(result, out int answer))
                {
                    Console.WriteLine("Invalid answer");
                    Environment.Exit(1);
                }

                if (answer == (firstNumber - secondNumber))
                {
                    Console.WriteLine("Your answer was correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Subtraction");
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(0, 10);
                secondNumber = random.Next(0, 10);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                if (!int.TryParse(result, out int answer))
                {
                    Console.WriteLine("Invalid answer");
                    Environment.Exit(1);
                }

                if (answer == (firstNumber * secondNumber))
                {
                    Console.WriteLine("Your answer was correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                if (!int.TryParse(result, out int answer))
                {
                    Console.WriteLine("Invalid answer");
                    Environment.Exit(1);
                }

                if (answer == (firstNumber / secondNumber))
                {
                    Console.WriteLine("Your answer was correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect.Type any key for next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Division");
        }
    }
}
