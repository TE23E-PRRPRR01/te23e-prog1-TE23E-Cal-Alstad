// Åldersgränser i USA
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Vad får du göra i USA?" );

//Fråga efter ålder
Console.Write("Hur gammal är du?: ");

//läs in texten
string ageText = Console.ReadLine();
//konvertera till heltal
int age = int.Parse(ageText);

if (age >= 21)
{
    Console.WriteLine("Du får köra bil, gå på kasino, samt dricka alkohol och använda tobak, du får även röka på i vissa delstater som exempelvis Michigan och Kalifornien![samt allt du fick när du var 18]");
}
else if (age >= 18) 
{
    Console.WriteLine("Du får ha sex i alla delstater, du får rösta i alla val både statliga och federala samt gå med i militären [allt du fick göra när du var 16 förutom att ha sex med minderåriga]");
}
else if (age >= 16)
{
    Console.WriteLine("Du får skaffa ett ID-kort, arbeta deltid i alla stater samt skaffa körkort och köra bil [du får göra allt du fick när du var 14]");
}
else if (age >= 14)
{
    Console.WriteLine("Du får skaffa ett lärlingskörkort, du får jobba deltid i vissa stater, samt bestämma över din egna medicinska beslut");
}
else if (age < 14)
{
    Console.WriteLine("Du har absolut ingen frihet och närstintill inga rättigheter ha så kul!");
} 


    
