/* Program to inventory a manufacturing company's warehouse, 
counting total finished products and those in each bin. Helps 
track inventory changes and detect shrinkage.*/
int[] inventory = { 200, 450, 700, 175, 250 };

//adds variable to increment sum value of each element in array
int sum = 0; // represents the sum of all finished products in your warehouse
int bin = 0; // counter Variable to track current iteration of foreach loop. store the number of the bin whose inventory is currently being processed.

//foreach iterate through each element of "inventory" array
foreach (int items in inventory) //temporarily assigns value of current array element to int named "items"
{
    sum += items; //adds current value stored in items to sum variable
    bin++; //increment bin each time code block executes
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})"); //reports  bin number, finished item count, and running total.

}

//reports the final sum of items in your inventory
Console.WriteLine($"We have {sum} items in inventory.");