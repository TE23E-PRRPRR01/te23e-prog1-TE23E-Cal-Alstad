/******************************************************************
*                              M A I N                            *
*******************************************************************/
//Använd Metoderna Här!

/*int svar = Addera(3, 5);
Console.WriteLine($"Svaret är {svar}");
Console.WriteLine(Addera(3, 5));*/
Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

Console.Write("Skriv den text du vill vända: ");
string texten = Console.ReadLine();
Console.WriteLine($"{texten} blir vänt {VändText(texten)}");

Console.WriteLine($"3 * 5 = {Multiplicera(3, 5)}");

Console.WriteLine($"3 / 5 = {Dividera(3, 5)}");

Console.WriteLine($"Längst av Hej och Hejsan är {Längst("Hej", "Hejsan")}");

Console.Write("Ange ett tal: ");
int nyTal1 = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();

/******************************************************************
*                           M E T O D E R                         *
*******************************************************************/
//Skapa Metoder Här!

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns>Summan</returns>
static int Addera(int tal1, int tal2) //signatur
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText (string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0 ; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

/// <summary>
/// Multiplicera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera (double tal1, double tal2)
{
    double summa2 = tal1 * tal2;
    return summa2;
}

/// <summary>
/// Dividera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera (double tal1, double tal2)
{
    double summa3 = tal1 / tal2;
    return summa3;
}

/// <summary>
/// Returnera det längsta string
/// </summary>
/// <param name="text1"></param>
/// <param name="text2"></param>
/// <returns></returns>
static string Längst(string text1, string text2)
{
    if (text2.Length > text1.Length)
    {
        return text2;
    }
    else
    {
        return text1;
    }
}

/// <summary>
/// Säkert sätt att läsa in ett tal (Utan att det krashar)
/// </summary>
/// <param name="args"></param>
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        //Läs in från användaren
        string textSomBlirTal = Console.ReadLine();

        //Kolla om texten är ett tal
         bool lycakdes = int.TryParse(textSomBlirTal, out tal);

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

