// Slumpa 2/10 listor
Console.Clear();
Console.WriteLine("Slumpa fram Städer!");

//Skapa en lista städer
List<string> städer = ["Stockholm", "Malmö", "Göteborg", "Uppsala", "Trelleborg", "Norrköping", "Vänersborg", "Enköping", "Linköping", "Solna"];

int antal = 2;
while (antal > 0)
{
    //Slumpa index 0-9
    int index = Random.Shared.Next(0, 10);
    //Console.WriteLine($"Det slumpade indexet är {index}");

    //Plocka ut stadem
    string stad = städer[index];

    //Skriv ut staden
    Console.WriteLine($"Din slumpade stad är {stad}");

    //Räkna ned 
    antal--;



}