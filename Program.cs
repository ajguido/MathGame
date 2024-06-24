var date = DateTime.Now;

string? name = GetName();

Menu(name);

return;

string? GetName()
{
    Console.WriteLine("Please type your name:");
    string? name = Console.ReadLine();
    return name;
}

void Menu(string? name)
{
    Console.WriteLine("--------------------------------------------------");

    Console.WriteLine($"Hello {name}. It's {date}. This is your math game.\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit program");

    Console.WriteLine("--------------------------------------------------");

    string? command;

    command = Console.ReadLine();

    switch (command.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game");
            break;
        case "s":
            SubtractionGame("Subtraction game");
            break;
        case "m":
            MultiplicationGame("Multiplication game");
            break;
        case "d":
            DivisionGame("Division game");
            break;
        case "q":
            Console.WriteLine("Quitting program. Goodbye.");
            Environment.Exit(1);
            break;
        default:
            OutputInvalidCommand();
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
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
            Console.WriteLine($"Game over. Your final score is {score}.");
        }
    }

}

void SubtractionGame(string message)
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
            Console.WriteLine($"Game over. Your final score is {score}.");
        }
    }
}

void MultiplicationGame(string message)
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
            Console.WriteLine($"Game over. Your final score is {score}.");
        }
    }
}

void DivisionGame(string message)
{
    int score = 0;

    for (int i = 0; i < 5; i++) 
    {
        Console.Clear();
        Console.WriteLine(message);

        int[] divisionNumbers = GetDivisionNumbers();
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
            Console.WriteLine($"Game over. Your final score is {score}.");
        }
    }
}

int[] GetDivisionNumbers()
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

void OutputInvalidCommand()
{
    Console.WriteLine("Invalid command. Input a valid command.");
}

