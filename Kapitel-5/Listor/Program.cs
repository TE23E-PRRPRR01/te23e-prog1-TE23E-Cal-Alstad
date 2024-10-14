// Använda listor för att skapa/hantera samlingar
using System.Threading.Tasks.Dataflow;

Console.Clear();

//Lista på trevliga frukter, tex "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter[0]} {frukter[1]} {frukter[2]}");

//Ändra i listan
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]} {frukter[1]} {frukter[2]}");

//Gå igenom listan = loopa igenom = från första till sista 
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

//skapa en lista på valfri sak (4st)
//skriv ut varje sak på samma rad
List<string> länder = ["Chile", "Canada", "Belgien", "Vietnam", "Kenya", "Samoa"];

foreach (var land in länder)
{
    Console.Write($"{land} ");
}

for (int i = 0; i < länder.Count; i++)
{
    Console.Write($"{länder[i]} ");
}


//Skapa ett register
Console.Clear();
//En tom lista 
List<string> namnlista = [];

//while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    //Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}