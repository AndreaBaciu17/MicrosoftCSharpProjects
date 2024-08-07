/*use what you've learned about code blocks and variable scope to fix
 the poorly written code sample provided*/
 int[] numbers = { 4, 8, 15, 16, 23, 42 };
 int total = 0;
 bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}
if (found)
    Console.WriteLine($"Set contains {numbers[5]}");

Console.WriteLine($"Total: {total}");
