using System.ComponentModel;
using System.Net.Sockets;

Console.Clear();

/******************************************************************
*                              M A I N                            *
*******************************************************************/

Presentation();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    
    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {
        Subtraktion();
    }
    else if (val == "3")
    {
        Multiplikation();
    }
    else if (val == "4")
    {
        Divition();
    }
    else if (val == "5")
    {
        Console.WriteLine("Programet avslutas");
        break;
    }
    else
    {
        Console.WriteLine("Felaktig Inmatning! Försök igen");
    }

}


/******************************************************************
*                           M E T O D E R                         *
******************************************************************/

static float LäsInHeltal()
{
    float tal = 0;
    while (true)
    {
        //Läs in från användaren
        string textSomBlirTal = Console.ReadLine();

        //Kolla om texten är ett tal
         bool lycakdes = float.TryParse(textSomBlirTal, out tal);

         if (lycakdes == true)
         {
            break;
         }
         else
         {
            Console.WriteLine("Felaktig inmatning, var vänlig ange ett heltal!");
         }
    }
   

    return tal;
}

static void Presentation()
{
    Console.WriteLine("Välkommen till detta Miniräknar Programmet");
}

static void VisaMeny()
{
    Console.Write("""

        -----------MENY-----------
        | 1. Addition            |
        | 2. Subtraktion         |
        | 3. Multiplikation      |
        | 4. Divition            |
        | 5. Avsluta Programet   |
        --------------------------

        Ange val nedan: 
        """);
}

static void Addition()
{
    Console.Write("Ange ett tal: ");
    float tal1 = LäsInHeltal();
    Console.Write("Ange ett tal: ");
    float tal2 = LäsInHeltal();

    Console.Clear();
    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}" );
}

static void Subtraktion()
{
    Console.Write("Ange ett tal: ");
    float tal1 = LäsInHeltal();
    Console.Write("Ange ett tal: ");
    float tal2 = LäsInHeltal();

    Console.Clear();
    Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}" );
}

static void Multiplikation()
{
    Console.Write("Ange ett tal: ");
    float tal1 = LäsInHeltal();
    Console.Write("Ange ett tal: ");
    float tal2 = LäsInHeltal();

    Console.Clear();
    Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}" );
}

static void Divition()
{
    Console.Write("Ange ett tal: ");
    float tal1 = LäsInHeltal();
    Console.Write("Ange ett tal: ");
    float tal2 = LäsInHeltal();

    Console.Clear();
    Console.WriteLine($"{tal1} / {tal2} = {tal1 / tal2}" );
}


