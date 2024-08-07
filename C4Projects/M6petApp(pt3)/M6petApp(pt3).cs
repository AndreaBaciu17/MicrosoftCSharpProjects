// #1 the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = ""; //added donation features. create a new variable to hold suggested donations and expand the ourAnimals array to hold the new data.  intended to be a numeric value, but is collected and stored as a string

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m; //declare decimalDonation

// #3 array used to store runtime data, there is no persisted data
//string[,] ourAnimals = new string[maxPets, 6];
string[,] ourAnimals = new string[maxPets, 7]; //Update ourAnimals array to hold 7 "columns" of data for each animal room for the new suggestedDonation data.

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00"; //suggestedDonation value amounts to the sample data
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99"; //suggestedDonation value amounts to the sample data
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00"; //suggestedDonation value amounts to the sample data
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = ""; //suggestedDonation value amounts to the sample data
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = ""; //suggestedDonation value amounts to the sample data
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    //Data validation with TryParse(). validate suggestedDonation represents a decimal, and that you can convert it to a decimal so it's available to use for billing calculations.
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
        decimalDonation = 45.00m; // if suggestedDonation NOT a number(can't be cast as a decimal), default to 45.00
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}"; //You used the decimalDonation version of the suggested donation data. You also used string interpolation and currency formatting in the output.  display with the local currency symbol and two decimal places as directed by the currency formatting :C2.
}

// #5 display the top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
        menuSelection = readResult.ToLower();

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++) // increased exit condition t prints the pet attributes to account for suggestedDonation data added.
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Display all dogs with a specified characteristic
            string dogCharacteristic = "";
            while (dogCharacteristic == "") //gather the input requires a while loop that continues to prompt the user until they submit an input.scoped to case "2":. You won't be able to utilize dogCharacteristic anywhere outside of the case statement code.
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                readResult = Console.ReadLine(); //gathers user input as dogCharacteristic it ensures value isn't null, and sets the string to lowercase and trims the surrounding spaces.
                if (readResult != null) //dogCharacteristic has a null value
                    dogCharacteristic = readResult.ToLower().Trim(); // then the loop repeats gathering input.
            }
            bool noMatchesDog = true; // need to account for the "no matches found" message.
            string dogDescription = ""; //Declare dogDescription to hold the combined data that originated from animalPhysicalDescription and animalPersonalityDescription;.Combine the dog descriptions to make it easier to search

// #6 loop through the ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++) //code filters for "dogs" using ourAnimals[i,1]
            {
                bool dogMatch = true;
                if (ourAnimals[i, 1].Contains("dog")) //Identify which animals are dogs
                {
                    if (dogMatch == true)
                    {
// #7 Search combined descriptions and report results
                        dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5]; //Using the dogDescription variable populate it with animalPhysicalDescription and animalPersonalityDescription;.
                   
                        //Search the combined descriptions of dogs and display
                        if (dogDescription.Contains(dogCharacteristic))
                        {
                            Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                            Console.WriteLine(dogDescription);
                            noMatchesDog = false;

                        }
                    }
                }
            }
            if (noMatchesDog)
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);


            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }

} while (menuSelection != " ");
