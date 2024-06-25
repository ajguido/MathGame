using MathGameProject;

var menu = new Menu();

var date = DateTime.Now;

List<string> games = new List<string>();

string? name = Helpers.GetName();

menu.ShowMenu(name, date);