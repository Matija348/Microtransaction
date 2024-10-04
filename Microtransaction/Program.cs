int wallet = 10000;

while (wallet > 0)

{
Console.WriteLine($"Du har {wallet} kronor kvar");

//Köpa

Console.WriteLine("Vill du köpa nåt?, om du gör inte då kommer jag behöva ta min pew pew");

Console.WriteLine("1. Pistol (500Kr)");
Console.WriteLine("2. AR-15 (1000Kr)");
Console.WriteLine("3. AK-47 (2000kr)");

string köpa = "";

while (köpa != "1" && köpa !="2" && köpa !="3")
{
    köpa = Console.ReadLine();
}












}


Console.ReadLine();