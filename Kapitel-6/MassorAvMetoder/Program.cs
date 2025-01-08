/******************************************************************
*                              M A I N                            *
*******************************************************************/

Console.Clear();
Console.WriteLine("Hej Metoder!");

SägHejNamn("Dante");
KvadreraNummer(5);


/******************************************************************
*                           M E T O D E R                         *
*******************************************************************/

/// <summary>
/// Skriv ut hälsning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
   //Console.Write("Ange namn: ");
   //string namn = Console.ReadLine();
   Console.WriteLine($"Hej på dig {namn}!");

}

/// <summary>
/// Metod som skriver ut tal i kvadrat
/// </summary>
/// <param name="nummer">Numret</param>
static void KvadreraNummer(int nummer)
{
    Console.WriteLine($"{nummer} kvadrerat blir {nummer * nummer}");

}