// Slumpa många tal och spara i lista
using System.ComponentModel.DataAnnotations;
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

List<int> listaSlumptal = [];

// be användaren ange antal slumptal
Console.Write("Ange antal slumptal: ");
int antal = int.Parse(Console.ReadLine());

// Be användaren ange min och max slumptal
Console.Write("Ange minsta värde för slumptal: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange högsta värde för slumptal: ");
int max = int.Parse(Console.ReadLine());
// loppa 5 ggr 
for (int i = 0; i< antal; i++)
{        
// slumpa ett tal 1-100
int slumptal = 0;
slumptal = Random.Shared.Next(min, max+1);

// lägg till slumptalet i listan

listaSlumptal.Add(slumptal);
Console.WriteLine($"Slumpat tal {i+1}: {slumptal}");

}

