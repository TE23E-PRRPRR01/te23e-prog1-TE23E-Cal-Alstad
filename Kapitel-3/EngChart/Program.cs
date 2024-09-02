// Program som simulerar kända Engeneering Flowchart
using System.Reflection;
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Välkommen till Ingenjörens flödesschema");

//Visa en ASCii art
Console.WriteLine($"""
    Y
  .-^-.
 /     \      .- ~ ~ -.
()     ()    /   _ _   `.                     _ _ _
 \_   _/    /  /     \   \                . ~  _ _  ~ .
   | |     /  /       \   \             .' .~       ~-. `.
   | |    /  /         )   )           /  /             `.`.
   \ \_ _/  /         /   /           /  /                `'
    \_ _ _.'         /   /           (  (
                    /   /             \  \
                   /   /               \  \
                  /   /                 )  )
                 (   (                 /  /
                  `.  `.             .'  /
                    `.   ~ - - - - ~   .'
                       ~ . _ _ _ _ . ~
""");

Console.WriteLine("Does it move? (y/n) ");
string answer = Console.ReadLine();

//Kolla om svar är ja/nej
if (answer == "y")
{ // y
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    { 
        Console.WriteLine("No Problem");
    }
    else
    {
        Console.WriteLine("Please use Duct Tape!!");
    }
}
else
{ // n
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("PLease use WD-40!!");
    }
    else
    {
        Console.WriteLine("No Problem!! ");
    }
}