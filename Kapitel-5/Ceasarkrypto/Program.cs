// Ett program med kryptering med Caesar-chiffer
using System.ComponentModel;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program med kryptering med Caesar-chiffer");

// Alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en bokstav
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

// Ange en nyckel
Console.Write("Ange en nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

foreach (char bokstav in meddelande)
{
    // Hitta bokstavens position (index)
    int index = alfabetet.IndexOf(bokstav);
    //Console.WriteLine($"{bokstav} är index = {index}");
    // Om bokstaven finns i alfabetet 
    if (index >= 0)
    {

        // Caesar-kryptering, adderar en nyckel(tex 2)
        int nyIndex = index + nyckel;
        //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

        // Börja om från början efter 29 
        if (nyIndex > alfabetet.Length)
        {
            nyIndex = nyIndex - alfabetet.Length;
        }

        // Plocka ut bokstaven för nyIndex
        char krypteradBokstav = alfabetet[nyIndex];
        //Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
        Console.Write(krypteradBokstav);
    }
    else
    {
        // Lämna tecken som inte finns i alfabetet oförändrade
        //Console.WriteLine($"Bokstaven oförändrad: ");
        Console.Write(bokstav);
    }

}



