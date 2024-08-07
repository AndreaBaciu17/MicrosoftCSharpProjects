//Contoso Pets application

/*use selection and iteration statements to create sample data, 
list the animals in your care, 
and add new animals to your business*/

/*//Add predefined sample data to the pets array.
    "ourAnimals" array includes the following "pet characteristics" for each 
    animal:
    Pet ID #.
    Pet species (cat or dog).
    Pet age (years).
    A description of the pet's physical condition/characteristics.
    A description of the pet's personality.
    The pet's nickname.



Iterate a "menu options and user selection" code block to establish the 
outer loop of your application.

Implement code branches corresponding to the user's menu selections.

Display all the information contained in the array used to store pet data
 (based on user's menu selection).
 

Iterate an "add new animal information" code block that enables the user
 to add one or more new animals to the pets array (based on user's menu 
 selection).*/

/*code uses a for loop around an if-elseif-else construct to 
populate the ourAnimals array with a sample dataset.

The code displays the following main menu options for user selection:
   List all of our current pet information.
   Assign values to the ourAnimals array fields.
   Ensure animal ages and physical descriptions are complete.
   Ensure animal nicknames and personality descriptions are complete.
   Edit an animal’s age.
   Edit an animal’s personality description.
   Display all cats with a specified characteristic.
   Display all dogs with a specified characteristic.
   Enter menu item selection or type "Exit" to exit the program

The code reads the user's menu item selection and displays a message 
echoing their selection.

code should have these features:
Update the code that's used to create the sample data for the app.
Construct a loop around the main menu and create a selection statement that establishes a code branch for each menu option.
Write the code to display all ourAnimals array data (menu option 1).
Build a loop for entering new ourAnimals array data (menu option 2 - 
part 1).
Write code to read and save new ourAnimals array data (menu option 2 
- part 2).*/
using System;
using System.IO;
// the ourAnimals array will store the following: 
// initalized zero strings for 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry/sample data
int maxPets = 8; // # of rows
string? readResult; //reading values with the Console.ReadLine() method best to use a nullable type
string menuSelection = "";
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;

// array used to store runtime data, there is no persisted data, two dimensional
string[,] ourAnimals = new string[maxPets, 6]; //uses new operator since we're instantiating the array without initializing any values  to create a new instance of a type


// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    /*if (i == 0)
    {
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
    }*/
    // TODO: Convert the if-elseif-else construct to a switch statement
    switch (i)
    {
        case 0: //same as "if (i == 0)
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        /*else if (i == 1)
        {
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
        }*/
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        /*else if (i == 2)
        {
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
        }*/
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        /*else if (i == 3) //4th iteration:  all characteristics are assigned an empty, or zero-length, string.
        {
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
        }*/
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        /*else
        {
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
        }*/
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    // animal characteristic variables are assigned to the ourAnimals array
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    Console.Clear(); // display the top-level menu options
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine(); //capturing input from the ReadLine() method
    if (readResult != null) //if input value isn't invalid
    {
        menuSelection = readResult.ToLower(); //then assign the value to a standard string variable named menuSelection
    }    

    /*Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();*/
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            //for loop used bc of ourAnimals multiimensional array that each element contained within ourAnimals is a separate item of type string
            for (int i = 0; i < maxPets; i++) // i used for animal being examined
            {
                // array checks the value assigned to petID for each animal in the array.
                if (ourAnimals[i, 0] != "ID #: ") //valuates as true whenever the value assigned to petID "ourAnimals[i, 0]" is NOT equal to the value listed on the right side of the equation.
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++) //j used for this loop that is inside another loop, using index range 0-5
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }    
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            anotherPet = "y"; //initializes before while loop
            petCount = 0; //# of animals with pet characteristics incremented by 1 in while loop, added to ourAnimals array
            for (int i = 0; i < maxPets; i++) //loops through ourAnimals array checking for assigned data
            {
                if (ourAnimals[i, 0] != "ID #: ") //if animal with assigned data is found in array
                {
                    petCount += 1; //increment by 1
                } 
            }
            if (petCount < maxPets)
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

            while (anotherPet == "y" && petCount < maxPets)
            {
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (validEntry == false);

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (validEntry == false);

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;


                petCount = petCount + 1; // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                if (petCount < maxPets) // check maxPet limit
                {
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                            anotherPet = readResult.ToLower();

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            
            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }
} while (menuSelection != "exit"); //Enter menu item selection or type "Exit" to exit the program

