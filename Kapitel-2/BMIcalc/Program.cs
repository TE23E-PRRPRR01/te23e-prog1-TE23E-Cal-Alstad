// BMI Calculator
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Räkna ut ditt BMI");

//Skriv in Längd och Vikt 
Console.Write("Hur lång är du(cm): ");
double Längd = double.Parse(Console.ReadLine());

Console.Write("Hur mycket väger du(kg): ");
double Vikt = double.Parse(Console.ReadLine());

//Konvertera till BMI

double BMI = Vikt / ((Längd/100)*(Längd/100));

//Skriv ut resultatet med decimaler
Console.WriteLine($"Ditt BMI är {BMI:00.00}");