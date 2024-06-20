Console.WriteLine("Please type your name:");
string? name = Console.ReadLine();

var date = DateTime.UtcNow;

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
do
{
    command = Console.ReadLine();

    // Ensure command is formatted correctly
    if (command == null || (command != null && command.Length != 1))
    {
        OutputInvalidCommand();
        continue;
    }

    char operation = command.Trim().ToLower()[0];
    switch(operation)
    {
        case 'a':
            AdditionGame("Addition game selected");
            break;
        case 's':
            SubtractionGame("Subtraction game selected");
            break;
        case 'm':
            MultiplicationGame("Multiplication game selected");
            break;
        case 'd':
            DivisionGame("Division game selected");
            break;
        case 'q':
            Console.WriteLine("Quitting program. Goodbye.");
            Environment.Exit(1);
            break;
        default:
            OutputInvalidCommand();
            break;
    }
} while (true);


void AdditionGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void OutputInvalidCommand()
{
    Console.WriteLine("Invalid command. Input a valid command.");
}