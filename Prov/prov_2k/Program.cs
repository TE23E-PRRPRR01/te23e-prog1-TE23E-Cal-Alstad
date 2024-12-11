//Tömmer konsolen
Console.Clear();
//skriver ut vad programet är 
Console.WriteLine("Filmregister");

// Tom lista för att lagra kommande filmer
List<string> filmerLista = [];



// Loop som kontrollerar programmet så att frågan ställs om ifall inmatningen blir felaktig.
while (true)
{

    // Visa en simpel meny
    Console.Write("""

    Välj ett av nedanstående alternativ:

    1. Lägg till en film
    2. Visa alla filmer
    3. Sök efter en film i listan
    4. Avsluta programmet

    Svara här: 

    """);

    string val = Console.ReadLine();
    Console.WriteLine();

    // If-loop som kontrollerar svar från användaren
    if (val == "1")
    {
        //Frågar användaren hur många filmer hen vill lägga till 
        Console.Write("Ange hur många filmer du vill lägg till: ");
        string antalText = Console.ReadLine();
        int antal = 0;
        while (true)
        {
            bool success = int.TryParse(antalText, out antal);
            if (success == true)
            {
                break;
            }
            else 
            {
                Console.WriteLine("Var God mata in ett heltal");
            }

        }
       
        Console.WriteLine();

        for (int i = 0; i < antal; i++)
        {
            // Frågar och lägger till filmen som användaren anger
            Console.Write("Skriv namnet på filmen du vill lägga till i listan: ");
            filmerLista.Add(Console.ReadLine());
        }

    }
    else if (val == "2")
    {
        // Visa alla filmer
        Console.WriteLine("Detta är alla filmer i lista:");

        foreach (var displayfilmerLista in filmerLista)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta; // Ändrar bakgrundsfärg för tydligare avläsning
            Console.WriteLine($"- {displayfilmerLista}");
            Console.BackgroundColor = ConsoleColor.Black; // Ändrar tillbaka bakgrundsfärg för tydligare avläsning
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Skriv namnet på filmen du vill söka efter i listan: ");
        String film = Console.ReadLine();
        foreach (var filmnamn in filmerLista)
        {
            //kolla om varje film heter filmnamnet
            if (filmnamn.StartsWith(film))
            {
                Console.WriteLine($"{filmnamn} finns med i listan");
            }
        }
    
    }
    else if (val == "4")
    {
        Console.WriteLine("Programmet avslutas");
        break;
    }
    else
    {
        Console.WriteLine("""
        Kom ihåg att du måste skriva in en siffra mellan 1 och 4.
        
        """);
    }
}
