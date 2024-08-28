// Program för att registrera förnamn och efternamn
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn...");
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();
//Console.WriteLine("Hej! " + förnamn + " " + efternamn);
Console.WriteLine($"Hej! {förnamn} {efternamn}");

// Är det Cal som loggar in?
if (förnamn == "Cal")
{
    Console.WriteLine("Vad trevligt att du är tillbaka!");
}

//Är det alstad som loggar in?
if (efternamn == "Alstad")
{
Console.WriteLine("Jag har saknat dig!");
}