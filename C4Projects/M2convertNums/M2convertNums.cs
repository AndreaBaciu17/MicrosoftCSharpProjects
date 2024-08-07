

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

//Solve for result1: Divide value1 by value2, display the result as an int
// Hint: You need to round the result to nearest integer (don't just truncate)

//int convertValue2 = Convert.ToInt32(value2);
//int convertValue2 = (int)value2;

int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");



// Solve for result2: Divide value2 by value3, display the result as a decimal

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");



// Solve for result3: Divide value3 by value1, display the result as a float

float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");






//EXCERCISE 1


/*split up the data depending on its type and either concatenate or 
add the data accordingly.*/

/*Rule 1: If the value is alphabetical, concatenate it to form a message.

Rule 2: If the value is numeric, add it to the total.

Rule 3: The result should match the following output:*/


/*using System.Numerics;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal totalValuesNum = decimal.Parse(values[0]) + decimal.Parse(values[1]) + decimal.Parse(values[3]);

string totalValuesStr = values[2] + values[4];

Console.WriteLine($"Message: {totalValuesStr}\nTotal: {totalValuesNum}");*/

/*METHOD 1:if (int.TryParse(values[0], out result))
{
    result = value1;
}*/

//METHOD 2: decimal totalValues = Convert.ToInt32(values[0]) + Convert.ToInt32(values[1]) + Convert.ToInt32(values[3]);


/*METHOD 3: decimal result1 = 0;
decimal result2 = 0;
decimal result3 = 0;


decimal value1 = decimal.TryParse(values[0], out result1);
bool value2 = decimal.TryParse(values[1], out result2);
bool value3 = decimal.TryParse(values[3], out result3);

decimal totalValues = value1 + value2 + value3;*/