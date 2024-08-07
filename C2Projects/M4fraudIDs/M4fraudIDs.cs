/*Security task: Detect patterns in fraudulent orders by 
analyzing past customer orders. Need a data structure to 
hold multiple order IDs.
string[] fraudulentOrderIDs = new string[3];*/

/*to assign "Order ID" values to elements of array
 "fradulentOrderIDs",  Each element is accessed individually
  by specifying zero-based index number inside the square brackets.
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";*/
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

//fraudulentOrderIDs[3] = "D000";   out of bounds of array

//retrieve values from elements of an array
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//reassign value of array
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//using length property
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");