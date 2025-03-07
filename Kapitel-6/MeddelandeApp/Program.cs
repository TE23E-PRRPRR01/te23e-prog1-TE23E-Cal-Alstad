﻿Console.Clear();

/**********************************************
*                   M A I N                   *
**********************************************/

VisaPresentation();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        SparaMeddelande();
    }
    else if (val == "2")
    {
        LäsaMeddelande();
    }
    else if (val == "3"){
        TaBortMeddelande();
    }

    else if (val == "4")
    {
        Console.WriteLine("Programmet avslutas");
        break;
    }
    else
    {
        Console.WriteLine("Felaktig inmatning. Försök igen.");
    }

}

/**********************************************
*               M E T H O D S                 *
**********************************************/

static void VisaPresentation()
{
    Console.WriteLine("Ett program för att spara och ta bort meddelanden");
}

static void VisaMeny()
{
    Console.Write("""

        -----------MENY-----------
        | 1. Spara meddelande    |
        | 2. Läs meddelande      |
        | 3. Ta bort textfil     |
        | 4. Avsluta programmet  |
        --------------------------

        Ange val nedan: 
        """);
}

static void SparaMeddelande()
{
    Console.Write("Ange ett meddelande: ");
    string meddelande = Console.ReadLine();

    Console.Write("Ange namnet på text-filen: ");
    string namnPåTextfil = Console.ReadLine();

    File.WriteAllText($"{namnPåTextfil}.txt", meddelande);

    Console.Write("Meddelandet har sparats!");

}

static void LäsaMeddelande()
{
    Console.Write("Ange namnet på textfilen du vill läsa av: ");
    string läsNamnPåTextfil = Console.ReadLine();

    string meddelande = File.ReadAllText($"{läsNamnPåTextfil}.txt");
    Console.WriteLine($"""
        Det importerade meddelandet är:

        {meddelande}
        """);
}

static void TaBortMeddelande()
{
Console.Write("Ange namnet på textfilen du vill ta bort: ");
string taBortNamnPåTextfil = Console.ReadLine();

    File.Delete($"{taBortNamnPåTextfil}.txt");
    Console.WriteLine("Textfilen har tagits bort.");
}