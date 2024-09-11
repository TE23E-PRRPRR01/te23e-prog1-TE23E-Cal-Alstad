// Program för att konvertera temperaturen från Celcius till Fahrenheit
Console.Clear();
Console.WriteLine("Program för att konvertera temperaturen från Celcius till Fahrenheit");

// Läser in temp i celcius
Console.Write("Ange temperatur i Celcius: ");
int tempCelcius = int.Parse(Console.ReadLine());

// Konvertera till Fahrenheit
int tempFahrenheit = tempCelcius* 9/5 + 32;

//Skriver ut resultatet 
Console.WriteLine($"{tempCelcius} Celcius är {tempFahrenheit} Fahrenheit");