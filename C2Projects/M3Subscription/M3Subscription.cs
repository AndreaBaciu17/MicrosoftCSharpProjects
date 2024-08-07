/*Rule1: display 1 renewal message when a user logs into the software 
system and is notified their subscription will soon end. For rules 2-6, 
the higher numbered rules take precedence over the lower numbered rules.*/
Random randomNum = new Random();
int daysUntilExpiration = randomNum.Next(12); //generates a random number with a value of 0 - 11

int discountPercentage = 0;// variable increment sum. 0 starting point

/*Rule2: If the user's subscription will expire in 10 days or less, 
display the message: "Your subscription will expire soon. Renew now!"*/
//Use an else if to ensure each expiration rule is accounted for.
if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}


/*Rule3: If the user's subscription will expire in five days or less, 
display the messages:
 Your subscription expires in ___(value stored in the variable daysUntilExpiration)___ days.
Renew now and save 10%!*/
//Use an else if to ensure each expiration rule is accounted for.
//Create a separate if statement that displays a discount offer.
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage += 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");

}

/*Rule 4: If the user's subscription will expire in one day, 
display the messages:
Your subscription expires within a day!
Renew now and save 20%!*/
//Use an else if to ensure each expiration rule is accounted for.
//Create a separate if statement that displays a discount offer.
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} day.");
    discountPercentage += 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}


/*Rule 5: If the user's subscription has expired, display the message:
Your subscription has expired.*/
//Use an else if to ensure each expiration rule is accounted for.
else if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}


/*Rule 6: If the user's subscription doesn't expire in 10 days or less, 
display nothing*/
else
{
    Console.WriteLine("");
}