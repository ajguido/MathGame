namespace MathGameProject
{
    internal class Menu
    {
        GameEngine gameEngine = new();

        internal void ShowMenu(string? name, DateTime date)
        {
            Console.Clear();

            Console.WriteLine($"Hello {name}. It's {date}. This is your math game.\n");
            Console.WriteLine("Press any key to show the menu.");
            Console.ReadLine();

            Console.WriteLine("--------------------------------------------------");

            bool isGameOn = true;

            do
            {
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        V - View previous games
        Q - Quit program");

                Console.WriteLine("--------------------------------------------------");

                string? command;

                command = Console.ReadLine();

                switch (command.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "q":
                        Console.WriteLine("Quitting program. Goodbye.");
                        isGameOn = false;
                        break;
                    default:
                        Helpers.OutputInvalidCommand();
                        break;
                }
                Console.Clear();
            } while (isGameOn);

        }
    }
}
