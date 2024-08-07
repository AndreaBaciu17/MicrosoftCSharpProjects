//system.Radom class, stores references to object in "dice" variable
//Random.Next() method on the dice object three times
Random dice = new Random(); 

//values between 1 and 6 (the upper bound is exclusive)
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


//CODE I ADDED MYSELF
/*
Console.Write("Enter first roll: ");
roll1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd roll: ");
roll2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 3rd roll: ");
roll3 = Convert.ToInt32(Console.ReadLine());
*/

int total = roll1 + roll2 + roll3;

//WriteLine() method to display the three values using string interpolation.
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//creates doubles
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    /*Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}*/

//rolls triples
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles  +2 bonus to total!");
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

//"total > 14" is a boolean expression
/*if (total > 14)
{ // code block
    Console.WriteLine("You win!");
}*/

// both if statements compare total with the same numeric value
/*if (total >= 15)
{
    Console.WriteLine("You win!");
}

//if (total < 15)
else
{
    Console.WriteLine("Sorry, you lose.");
}*/


if (total >= 16) //If the player scores greater or equal to 16, they'll win a new car.
{
    Console.WriteLine("You win a new car!");
}
//when you only want one outcome to happen, but you have several possible conditions and results, use as many else if statements as you want.
else if (total >= 10) //If the player scores greater or equal to 10, they'll win a new laptop
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7) //If the player scores exactly 7, they'll win a trip
{
    Console.WriteLine("You win a trip for two!");
}
//If none of the if and else if statements apply, the final else code block will be executed. must come last
else //Otherwise, the player wins a kitten
{
    Console.WriteLine("You win a kitten!");
}

