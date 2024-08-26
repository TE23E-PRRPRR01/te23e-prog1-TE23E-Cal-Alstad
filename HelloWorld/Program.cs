Console.Clear();

Console.WriteLine("Hej världen!");
Console.WriteLine("Nu mitt första C#-program");

Console.Write("Vad heter du? ");
string namn = Console.ReadLine();
Console.WriteLine("Hej! "+ namn);

Console.Write("Vad gillar du att göra på fritiden? ");
string intresse = Console.ReadLine();
Console.WriteLine("Jag gillar också " + intresse);

Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Vad tyckte du om OS i sommar? ");
Console.WriteLine("Vilken sport tyckte du var bästa? ");