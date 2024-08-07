/* This C# program constructs and displays a personalized message for a customer, Ms. Barros, 
detailing the benefits of switching from their current financial product, "Magic Yield," 
to a new offering, "Glorious Future." The message includes a comparison of returns and 
potential profits between the two products. The program demonstrates the use of string 
interpolation, formatting, and padding for creating a well-formatted output message.
*/
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Generate and display the personalized message
Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}\n\n.");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = ""; // Initialize comparison message string

// Construct the comparison message
comparisonMessage = currentProduct.PadRight(19);
comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(9);
comparisonMessage += string.Format("{0:C}", currentProfit).PadLeft(15);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(19);
comparisonMessage += string.Format("{0:P}", newReturn).PadRight(9);
comparisonMessage += string.Format("{0:C}", newProfit).PadLeft(15);

// Display the comparison message
Console.WriteLine(comparisonMessage);

/* DESIRED OUTPUT:
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%. Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/
