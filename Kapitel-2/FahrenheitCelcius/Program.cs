// Program för att konvertera från Fahrenheit till Celcius
using System.ComponentModel;

Console.Clear();
Console.WriteLine("Program för att konvertera från Fahrenheit till Celcius");

// Läsa in temperaturen i Fahrenheit
Console.Write("Ange temperaturen i Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Konvertera Fa -> Ce
double tempCelcius = (tempFahrenheit - 32) * 5/9;


// Skriva ut resultatet med decimaler
Console.WriteLine($"{tempFahrenheit} Fahrenheit blir {tempCelcius} Celcius");