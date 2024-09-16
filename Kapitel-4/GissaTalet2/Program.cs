// Spelet - gissa ett slump tal 1-100
using System.Formats.Asn1;

Console.Clear();
Console.WriteLine("Spelet - gissa ett slump tal");

// En variabel för att hålla koll på antal gissningar
int antalGissningar = 0;

// Ange minimum och maximum värde
Console.Write("Ange minimumvärde för slumptal: ");
    int minimumvärde = int.Parse(Console.ReadLine());

Console.Write("Ange maximumvärde för slumptal: ");
    int maximumvärde = int.Parse(Console.ReadLine());

// Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(minimumvärde, maximumvärde+1);

// Upprepning - loop
while (true)
{
    // ställ fråga till användaren
    Console.Write($"Gissa ett tal {minimumvärde}-{maximumvärde}: ");
    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antalGissningar med 1
    antalGissningar++;

    // kontroll om gissning är rätt eller fel
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt Gissat!! Du gissade {antalGissningar} gånger");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt, Gissa igen");
    }
    else
    {
        Console.WriteLine("För lågt, Gissa igen");
    }
    
    
    //Vill användaren gissa en gång till
    Console.Write("Vill du fortsätta spela? (j/n)");

    if ((Console.ReadLine() == "n"))
    {
        break;
    }
    
    
}

// Slut på Spelet

Console.WriteLine("Tack för att du spelade, Testa igen vetja!");
