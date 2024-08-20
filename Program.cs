// Hangman 

string[] hangSozArray = {
    "Cat", "Dog", "Bird", "Fish", "Hamster", "Rabbit", "Snake", "Cow", "Horse", "Sheep",
    "Goat", "Duck", "Chicken", "Iguana", "Rat", "Monkey", "Lion", "Tiger", "Bear", "Zebra",
    "Deer", "Moose", "Kangaroo", "Penguin", "Bat", "Giraffe", "Elephant", "Panda", "Seal", "Wolf",
    "Fox", "Mole", "Squirrel", "Owl", "Frog", "Turtle", "Hawk", "Eagle", "Parrot", "Dolphin"
};




Random rand = new Random();
string hangSozu = hangSozArray[rand.Next(hangSozArray.Length)].ToUpper();
char[] duzgunHerflerArray = new char[hangSozu.Length * 2 - 1];


for (int i = 0; i < hangSozu.Length * 2 - 1; i++)
{
    if (i % 2 == 0)
    {
        duzgunHerflerArray[i] = '_';
    }
    else
    {
        duzgunHerflerArray[i] = ' ';
    }
}

int count = 0;
int sans = 5;

Console.WriteLine("***   HANGMAN oyunu  ***");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("* Soz => " + new string(duzgunHerflerArray));
Console.WriteLine("* Verilen Sans => " + (sans));
Console.WriteLine();

while (count < sans)
{
    Console.Write("* Herfi daxil ele: ");
    char hangHerfi = Console.ReadLine().ToUpper()[0];
    Console.WriteLine();
    
    int tapilan = 0;
    bool final = true;

    for (int i = 0; i < hangSozu.Length; i++)
    {
        if (hangSozu[i] == hangHerfi)
        {
            duzgunHerflerArray[i * 2] = hangHerfi;
            tapilan++;
        }
    }

    Console.WriteLine(new string(duzgunHerflerArray));
    Console.WriteLine();

    for (int i = 0; i < hangSozu.Length; i++)
    {
        if (duzgunHerflerArray[i * 2] != hangSozu[i])
        {
            final = false;
            break;
        }
    }

    if (final == true)
    {
        Console.WriteLine("* Tebrikler, Qazandin!");
        break;
    }
    else if (tapilan == 0)
    {
        count++;
        Console.WriteLine("* Duz tapmadin! Qalan şans: " + (sans - count));
        Console.WriteLine();
    }

    if (count >= sans)
    {
        Console.WriteLine("* Uduzdun, soz '" + hangSozu + "' idi!");
    }
}

