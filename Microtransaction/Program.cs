using System.Runtime.InteropServices;

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

//priset per ply

int price = 0;

if (köpa == "1")
{
    price = 500;
}

else if (köpa == "2")
{
    price = 1000;
}

else if (köpa == "3")
{
    price = 2000;
}

//Hur Många
Console.WriteLine("Hur många vill du köpa din jävla invandrare!!!");
int numToBuy = 0;
while (numToBuy == 0)
{
    string num = Console.ReadLine();
    bool success = int.TryParse(num, out numToBuy);
    if (success == false)
    {
        Console.WriteLine("Du är en idiot skriva en siffra!");
    }
}






}


Console.ReadLine();