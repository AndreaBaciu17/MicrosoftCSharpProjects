
// Extracts quantity from HTML and modifies output by replacing <div> tags and trademark symbol.


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
/*Set the quantity variable to the value obtained by extracting the 
text between the <span> and </span> tags.*/
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

/*Set the output variable to the value of input, then remove the <div> 
and </div> tags.*/
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

/*Replace the HTML character ™ (&trade;) with ® (&reg;) in the output
variable.*/
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

/*
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/