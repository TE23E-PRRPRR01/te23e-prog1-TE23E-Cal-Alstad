// Program för att skriva till och läsa från filer 
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Program för att skriva till och läsa från filer");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Program loop som snurrar tills användaren säger avsluta
while (true)
{
    Console.Write("""
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta
    Välj ett av valen ovan:
    """);
    val = Console.ReadLine();
    

    if (val == "1")
    {
        //Fråga användaren vad den vill skriva
        Console.Write("Vad vill du skriva i filen: ");
        string text = Console.ReadLine();
        File.WriteAllText("filnamn.txt", text);
    }
    else if (val == "2")
    {
        if (File.Exists("filnamn.txt"))
        {
        // Läs in text från filen
        string text = File.ReadAllText("filnamn.txt");
        Console.WriteLine(text);
            
        }
        else
        {
            Console.WriteLine("Filen existerat inte!");
        }

    }
    else if (val == "3")
    {
        //Avslutar 
        Console.WriteLine("Avslutar...");
        break;
    }
    else
    {
        Console.WriteLine("Du valde inget av de giltiga alternativen, Försök igen!");
    }

}



