/*write code that would store Order IDs belonging to potentially 
fraudulent orders. Your goal is to find fraudulent orders as early
 as possible and flag them for deeper analysis.*/
/*Pattern: Orders that start with the letter "B" encounter fraud at a
rate 25 times greater than the normal rate. output the Order ID of new 
 orders where the Order ID starts with the letter "B"*/

 /*STEP1: Declare an array and initialize it to contain these elements
 (represents the fraudulent Order ID data that your application use):
 B123 index 0, 1st element
C234 index 1, 2nd element
A345 index 2, 3rd element
C15 index 3, 4th element
B177 index 4, 5th element
G3003 index 5, 6th element
C235 index 6, 7th element
B179 index 7, 8th element*/
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};



/*STEP2: create "foreach" to iterate through each element of array*/


foreach (string orderID in orderIDs)
{


//if statement?


/*STEP3: Report the Order IDs that start with the letter "B." Evaluate
 each array element for potential fraud by checking for Order IDs
 starting with "B" using String.StartsWith() method.*/
if (orderID.StartsWith("B")) 
{
    Console.WriteLine(orderID);
}
}


/*OUTPUT:
B123
B177
B179
*/