//Contoso Petting Zoo application

/* 18 different species of animals. visiting students are assigned 
  to groups, each group has a set of animals assigned. After visiting, 
  the students  rotate groups until seen all the animals at zoo.

students  divided into 6 groups. there are small/large student classes,
  The animals must be randomly assigned to each group.*/

/*There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

  For each visiting school, perform the following tasks
    - #1 Randomize the animals
    - #2 Assign the animals to the correct number of groups
    - #3 Print the school name
    - #4 Print the animal groups*/


using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

//perform the same tasks for each school.
void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(); //groups to the default value of 6
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

// #1 'RandomizeAnimals();' method. randomize/swap elements in 'pettingZoo' array
RandomizeAnimals();
void RandomizeAnimals()  // no input parameters due to existing pettingZoo variable
{
    /* //represent  random indices in  array
    int i = 0;
    //int r = 1;
    int r = random.Next(pettingZoo.Length);  // initialized a random object to generate a random number. between 0 and the length of the pettingZoo array
    string temp = pettingZoo[i]; //swap  values at  two indices with temp variable. prevents losing pettingZoo[i] value after overwritten
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;*/

    Random random = new Random();

    // cycle through each element in  array, select a random index, and swap with current element.
    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length); //update range of randomly selected index excluding values > 'i' since indices at values < i swapped in previous iterations of loop.
        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

//#3 print school name
Console.WriteLine("School A");


// #2 string[,] group = AssignGroup();
string[,] AssignGroup(int groups = 6) //define the assignGroups method.  return a 2D array. The number of groups can also change depending on the size of the visiting school. default size 6 so optional parameter
{
    string[,] result = new string[groups, pettingZoo.Length/groups]; // define the array size.groups represents the number of animal groups. pettingZoo.Length/groups reflects animals assigned.
    int start = 0; //'pettingZoo' starting position to navigate through array for different iterations

    //assigns animals to each group
    for (int i = 0; i < groups; i++) 
    {
        //cycles animals numbers groups contain
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++]; //assign animals 
        }
    }

    return result; //prevent errors?
}


// #4 'PrintGroup(group);'
/*#4 need to print different groups of animals several times, use 
method with the group as the input parameter. must initialize 'group'*/
void PrintGroup(string[,] groups)  //method takes 2D array
{
    for (int i = 0; i < groups.GetLength(0); i++) //number of rows
    {
        Console.Write($"Group {i + 1}: "); //helper text
        for (int j = 0; j < groups.GetLength(1); j++) //number of columns
        {
            Console.Write($"{groups[i,j]}  "); //print elements with extra spaces btwn animals
        }
        Console.WriteLine();
    }
}

/*#5 tests code
foreach(string animal in pettingZoo) 
{
    Console.WriteLine(animal);
}*/