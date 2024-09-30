//Ett annat exempel, Lista på 3 årtal
//List<int> Åtal = [1957, 1969, 1989];

// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur ett kortlek!");

//Skapa en lista kort
//List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "🃖Sexa", "Sjua", "Åtta", "Nia", "Tia", "Knekt", "Dam", "Kung"];
//List<string> kortlek = ["🃑", "🃒", "🃓", "🃔", "🃕", "🃖", "🃗", "🃘", "🃙", "🃚", "🃛", "🃝", "🃞"];
List<string> kortlek = ["🌝", "🃒", "🃓", "🃔", "🃕", "🃖", "🃗", "🃘", "🃙", "🃚", "🃛", "🃝", "🃞"];

int antal = 5;
while (antal > 0)
{
    //Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    //Console.WriteLine($"Det slumpade indexet är {index}");

    //Plocka ut det sjunde kortet, index = 6
    string kort = kortlek[index];

    //Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    //Skriv ut  kortet
    Console.WriteLine($"Ditt slumpade kort är en {kort}");

    //Räkna ned 
    antal--;



}