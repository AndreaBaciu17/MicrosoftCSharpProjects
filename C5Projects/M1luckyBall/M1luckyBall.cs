Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}

/* if RNG is more than 75 = good 

else if RNG is less than 25 = bad

else if RNG is between 26 and 74 = neutral


each array has 4 strings,*/

void tellFortune() 
{
    int textIndex = random.Next(text.Length); // Generate a random index within the range of the array length
    string randomTextPhrase = text[textIndex];

    int goodIndex = random.Next(good.Length); // Generate a random index within the range of the array length
    string randomGoodPhrase = good[goodIndex];

    int badIndex = random.Next(bad.Length); // Generate a random index within the range of the array length
    string randomBadPhrase = bad[badIndex];

    int neutralIndex = random.Next(neutral.Length); // Generate a random index within the range of the array length
    string randomNeutralPhrase = neutral[neutralIndex]; 

}
