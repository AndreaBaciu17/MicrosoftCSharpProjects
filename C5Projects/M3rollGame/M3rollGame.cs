using System.Xml.XPath;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
    PlayGame();

void PlayGame() 
{
    var play = true;
    while (play) 
    {
    //values between 1 and 6 (the upper bound is exclusive)
        var target = getTarget;
        //int target = random.Next(1, 7);
        var roll = getRoll;
        //int roll = random.Next(1, 7);


        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}



//target variable method
int getTarget()
{
    return random.Next(1, 6); // target number that is a random number between one and five (inclusive)
}



//roll variable method
int getRoll()
{
    return random.Next(1, 7); //values between 1 and 6 (the upper bound is exclusive)
}



//retrieve user input and determine if the user wants to play again
bool ShouldPlay()
{
    string readResult = Console.ReadLine();
    return readResult.ToLower().Equals("y");
}



//determines if player won or lose
string WinOrLose(int roll, int target)
{
    if (roll > target)
        return "You win!";
    else
        return "You lose!";
}

//