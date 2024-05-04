
Console.WriteLine("Welcome to the bank of C#!");

int pin = 4980;
int userEntry;
userEntry = pin + 5;

Console.WriteLine("Please enter your Pin to proceed");

try
{
    userEntry = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("That's definitely not your pin because it's not a number, try again!!");
}

while (userEntry != pin)
{
    Console.WriteLine("Incorrect Pin, try again {tries remaining}");
    try
    {
        userEntry = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Woah that can't be your pin, it's not a number! Try again!");
    }
}

Console.WriteLine("Pin accepted!");

