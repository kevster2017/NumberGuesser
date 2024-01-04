// See https://aka.ms/new-console-template for more information

GetAppInfo(); // Run GetAppInfo function

GreetUser(); // Run GreetUser function

while(true)
{



//int correctNumber = 7;
Random random = new Random();

int correctNumber = random.Next(1, 10);

int guess = 0;

Console.WriteLine("Guess a number between 1 and 10");

while(guess != correctNumber)
{
    string input = Console.ReadLine();

    if(!int.TryParse(input, out guess))
    {
            PrintColourMessage(ConsoleColor.Red, "Please Enter a Valid Number");

        continue;
    }
    guess = Int32.Parse(input);

    if(guess != correctNumber)
    {
            PrintColourMessage(ConsoleColor.Red,
             "Wrong number, please try again");
        }
    
}

Console.ForegroundColor = ConsoleColor.Yellow;


Console.WriteLine("Correct Number");

Console.ResetColor();

    Console.WriteLine("Play again? [Y/N]");

    string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        continue;
    }
    else if (answer == "N")
    {
        return;
    }
    else
    {
        return;
    }

}

static void GetAppInfo()
{
    string appName = "Number Guesser";
    string appVer = "1.0.0";
    string appAuthor = "Kev";

    Console.ForegroundColor = ConsoleColor.Green;


    Console.WriteLine("{0}: Version: {1} by {2}", appName, appVer, appAuthor);

    Console.ResetColor();
}

static void GreetUser()
{
    Console.WriteLine("Enter your name");

    string inputName = Console.ReadLine();

    Console.WriteLine("Hello {0}, let's play a game", inputName);
}

static void PrintColourMessage(ConsoleColor colour, string message)
{
    Console.ForegroundColor = colour;


    Console.WriteLine(message);

    Console.ResetColor();
}