int adminLevel = 70;
int managerLevel = 17;
string [] permissions =  { "Admin", "Manager", "None" };

Console.Write($"{permissions[0]}, {permissions[1]}, or {permissions[2]}?");
Console.ReadLine();

if (permissions.Contains("Admin"))
{
    Console.WriteLine($"{(adminLevel > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.")}");
}


if (permissions.Contains("Manager"))
{
    Console.WriteLine($"{(managerLevel > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")}");
}

if (permissions.Contains("None"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}


/*int a = 7;
int b = 6;
Console.WriteLine(a == b); //output: false
                (a != b); // true
*/


/*Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

/or

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");*/