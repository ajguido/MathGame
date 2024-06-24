using MathGameProject;

var menu = new Menu();

var date = DateTime.Now;

List<string> games = new List<string>();

string? name = GetName();

menu.ShowMenu(name, date);

return;

string? GetName()
{
    Console.WriteLine("Please type your name:");
    string? name = Console.ReadLine();
    return name;
}