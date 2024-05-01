
Console.WriteLine("Welcome to the bank of C#!");

int pin = 4980;
int userEntry;

Console.WriteLine("Please enter your Pin to proceed");

userEntry = int.Parse(Console.ReadLine());

while (userEntry != pin)
{
    Console.WriteLine("Incorrect Pin, try again {tries remaining}");
    userEntry = int.Parse(Console.ReadLine());

}

Console.WriteLine("Pin accepted!");

