// Interactiv Story
using System.Xml.Serialization;

Console.Clear();
Console.WriteLine ("Hej och Välkommen till ditt egna äventyr!");

Console.WriteLine("Du vaknar upp i en mörk kall skog, det är mitt i vintern, du kollar dig omkrig och ser att du är i en korsning");
Console.WriteLine("Vilken väg tar du? Väg A leder mot ett vagt ljus åt vänster, Väg B leder åt höger mot tysta röster i horrizonten (A/B)");
string answer = Console.ReadLine().ToUpper();

if (answer == "A")
{
    Console.Write("Du valde att gå vänster och kommer till ett Slott. Går du in? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("Du går in i slottet och möts av en väg av faklor, går du vidare? (Y/N)");
        answer = Console.ReadLine();
        if (answer == "Y")
        {
            Console.WriteLine("Du går vidare och hittar en skattkista!! Grattis du är nu rik..... dock så är du fast i slottet förevigt");
        }
        else
        {
            Console.WriteLine("Du går ut ur slottet och blir direkt attackerad av vargar och dör RIP");
        }
    }
    else
    {
         Console.WriteLine("Du bestämmer dig för att stå kvar och vänta på hjälp, hjälp kommer aldrig och du fryser ihjäl.");
        
    }
}
else 
{
     Console.Write("Du valde att gå Höger och kommer till en by. En gammal dam ser dig och erbjuder dig att stanna hos henne tills natten blivit till dag. Du anser dock att hon ser lite illvillig ut. Accepterar du hennas hjälp eller inte? (Y/N)");
    answer = Console.ReadLine();
   if (answer == "Y")
   {
     Console.WriteLine("Grattis du valde att förtro dig kvinnan och du valde rätt, du fick mat och någonstans att sova. Du är tacksam och fortsätter resa till henne var år för att fortsätta visa din tacksamhet ");
   }
   else
   {
     Console.WriteLine("Du valde att inte lita på kvinnan och det slutade med att ingen annan ville ta in dig, du somnar i skogen och vaknar aldrig mer. Du förfrös RIP");
   }
}