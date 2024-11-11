// Skapa lista med slumpade tal

/********************************************************************************
**                                   Main                                      **
*********************************************************************************/


// Validera användarens inmatning
Console.Clear();

// Skapar en variabel för antalet slumptal för global användning
int antal = LäsInHeltal();
int min = LäsInHeltal();
int max= LäsInHeltal();

// Deklarera variabler
// Skapa en lista för att spara de slumpade talen
List<int> listaSlumptal = [];



// Loopar {antal} gånger
for (var i = 0; i < antal; i++)
{
    // Slumpar ett mellan {min} och {max}
    int slumptal = Random.Shared.Next(min, max + 1);

    // Lägger in slumptalet i en lista
    listaSlumptal.Add(slumptal);

    // Skriver ut
    Console.WriteLine($"Slumpat tal nummer {i + 1} är: {slumptal}");
}

/********************************************************************************
**                             Mina egna metoder                               **
*********************************************************************************/

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {
        // Fråga användaren hur många slumptal som ska skapas
        Console.Write("Ange heltal: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine("Du måste skriva ett heltal");
        }

    }
    return heltal;
}

