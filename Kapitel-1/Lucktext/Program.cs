// Lucktext
using System.ComponentModel;

Console.Clear();
Console.WriteLine("Välkommen till vår Lucktext!");
Console.Write("Ange ditt förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange ett adjektiv: ");
string adjektiv = Console.ReadLine();
Console.Write("Ange en känsla: ");
string känsla = Console.ReadLine();
Console.Write("Ange ett land: ");
string land = Console.ReadLine();
Console.WriteLine($"Det var en {adjektiv} tonåring vid namn {förnamn} som kände sig {känsla} och bestämde sig för att åka till {land}");


