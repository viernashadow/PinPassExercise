
Console.WriteLine("Welcome to the bank of C#!");

string pass = "EXO"; // case sensitive password 
string pp;
int pin = 4980;
int userEntry;
userEntry = pin + 5; // instead of initializing it as zero it's pin plus five that way it can never be the users pin if they choose it
int pinLockout = 0;
int triesRemaining = 3;

Console.WriteLine("Hey, what's the Password?");
pp = Console.ReadLine();

while (pp != pass)
{
    Console.WriteLine("Wrong Password, try again.");
    pp = Console.ReadLine();
}

Console.WriteLine("Good job, now...");
Console.WriteLine("Please enter your Pin to proceed:");

try
{
    userEntry = int.Parse(Console.ReadLine());
    triesRemaining--;
}
catch
{
    Console.WriteLine("That's definitely not your pin because it's not a number, try again!");
    triesRemaining--;


}

while (userEntry != pin)
{
    if (pinLockout <= 3)
    {
        Console.WriteLine($"Incorrect Pin, try again.. you have {triesRemaining} tries remaining");
        pinLockout++;
        try
        {
            userEntry = int.Parse(Console.ReadLine());
            pinLockout++;
            triesRemaining--;
            continue;

        }
        catch
        {
            Console.WriteLine("Woah that can't be your pin, it's not a number! Try again!");
            pinLockout++;
            triesRemaining--;


        }
    }
    else
    {
        Console.WriteLine("You are out of chances, good bye.");
        break;
    }

}

if (userEntry == pin)
{
    Console.WriteLine("Pin accepted!");
}

