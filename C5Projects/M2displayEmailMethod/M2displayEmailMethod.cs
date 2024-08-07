using System.Runtime.CompilerServices;

string[,] internals  = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] externals = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalsDomain = "hayworth.com";
string internalsDomain = "contoso.com";


void displayEmail (string[,] employees, string domain)
{
     for (int i = 0; i < employees.GetLength(0); i++)
        {
            string firstName = employees[i, 0];
            string lastName = employees[i, 1];
            string username = $"{firstName.Substring(0, 2).ToLower()}{lastName.ToLower()}";
            string emailAddress = $"{username}@{domain}";
            Console.WriteLine(emailAddress);
        }
}


for (int i = 0; i < internals.GetLength(0); i++) 
{
    // display internal email addresses
    displayEmail(internals, internalsDomain);
}

for (int i = 0; i < externals.GetLength(0); i++) 
{
    // display external email addresses
    displayEmail(externals, externalsDomain);
}

/* Method that includes optional parameter for the domain name of 
external employees.*/
