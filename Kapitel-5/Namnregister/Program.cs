// Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");
//Skapa ett register
//En tom lista 
List<string> namnlista = [];
//programloopen
while (true)
{
    //Visa en meny
    Console.WriteLine("""
    1. Registrera namn
    2. Skriva ut namnregistret
    3. Avsluta programmet
    Ange ditt val: 
    """);
    string val = Console.ReadLine();

    if (val == "1")
    {
        //while-loop
        while (true)
        {
            Console.Write("Ange ett namn: ");
            string namn = Console.ReadLine();
            namnlista.Add(namn);
        }
    }
    else if (val == "2")
    {
         //Skriv ut hela listan på en rad
            foreach (var namnet in namnlista)
            {
                Console.Write($"{namnet}, ");
            }
            Console.WriteLine();
    }
    else if (val == "3")
    {
        Console.WriteLine("Programet avslutas");
        break;
    }
    
}
