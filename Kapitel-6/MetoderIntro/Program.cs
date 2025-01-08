/******************************************************************
*                              M A I N                            *
*******************************************************************/

// Intro till metoder
using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("Hej Metoder!");

//Anropa metoden 
SägHej();

// Anropa metoden Meny
VisaMeny();

//Anropa metoden RegisterarNamn()
RegistreraNamn();



/******************************************************************
*                           M E T O D E R                         *
*******************************************************************/

/// <summary>
/// Metod som skriver ut hälsning
/// </summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}

static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta program
    """);
}

static void RegistreraNamn()
{
    Console.Write("Vad är ditt namn: ");
    string namn = Console.ReadLine();
    Console.WriteLine($"Hej {namn}");
    
}
