/*develope a Student Grading application that automates the calculation
 of grades for each student in a class*/

 /*using statement enables you to write code that implements members
  of the System namespace without requiring you to specify System.*/
using System;


 /*PARAMETER1: Start with four students. Each student has five exam
  scores. Each exam score is an integer value, 0-100, where 100 
  represents 100% correct.A student's overall exam score is the 
  average of their five exam scores.*/

// initialize variables - graded assignments
/*declares variables used to define student names and individual exam 
scores for each student.*/
//Use arrays to store student names and assignment scores.!!!!
/*Use a foreach statement to iterate through the student names as an 
outer program loop.!!!!*/
int examAssignments = 5; //(old before initializing variables for graded assignments) int currentAssignments = 5;

/*int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;*/
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 }; //(before extra credit) int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };

/*int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;*/
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 }; //(before extra credit) int[] andrewScores = new int[] {92, 89, 81, 96, 90};

/*int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;*/
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 }; //(before extra credit) int[] emmaScores = new int[] {90, 85, 87, 98, 68};

/*int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;*/
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 }; //(before extra credit) int[] loganScores = new int[] {90, 95, 87, 88, 96};

// Student names array conversion
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n"); // Display the Report Header

foreach (string name in studentNames)
{
    string currentStudent = name;
/*Use an if statement within the outer loop to identify the current
 student name and access that student's assignment scores.!!!*/
    if (currentStudent == "Sophia") //assign the sophiaScores array to studentScores when currentStudent == "Sophia"
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

//integers that are being used to hold the sum of the exam scores.
    int sumAssignmentScores = 0; 
    //int sophiaSum = 0;
/*int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;*/


 /*Use a foreach statement within the outer loop to iterate through
  the assignment scores array and sum the values.*/
/*decimalsused to hold  calculated average score because an integer
 calculation rounds off the fractional portion of calculated value.*/
    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0; //decimal sophiaScore;
    int gradedAssignments = 0; // initialize/reset a counter for the number of assignment 
    foreach (int score in studentScores) //foreach (int score in sophiaScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        // add the exam score to the sum. equivalent to "sophiaSum + score;"
            sumAssignmentScores += score; //sophiaSum += score;
        else
            sumAssignmentScores += score / 10; // add the extra credit points to the sum - bonus points equal to 10% of an exam score
    }
/*decimal andrewScore;
decimal emmaScore;
decimal loganScore;*/


/* variables and algorithms used to sum the exam scores and calculate 
the average exam score for each student*/
/*Use an updated algorithm within the outer loop to calculate the 
average exam score for each student.*/
/*sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;*/
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments; //currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments; //sophiaScore = (decimal)sophiaSum / currentAssignments;

/*Use an if-elseif-else construct within the outer loop to evaluate
 the average exam score and assign a letter grade automatically.*/
    /*PARAMETER3: Your application needs to automatically assign letter grades based
   on the calculated final score for each student.
   Your application needs to output/display each student’s 
   name and formatted grade.
   Your application needs to support adding other students and scores
   with minimal impact to the code.*/
  if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";


/*andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum /
 currentAssignments;*/


  /*PARAMETER2: Criteria for extra credit assignments: 
  Include extra credit assignment scores in the student's scores array. 
  Extra credit assignments are worth 10% of an exam score 
  (when calculating the final numeric grade).
  Add extra credit assignment scores to the student's total exam score
   before calculating the final numeric grade.*/
/*must detect extra credit assignments based on the number of elements
 in the student's scores array*/
 /*must apply the 10% weighting factor to extra credit assignments
  before adding extra credit scores to the sum of exam scores.*/



//display the student grading report.
   Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");//Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?"); //Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    
}
/*Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");*/

//hard coded letter grade that the developer must apply manually.
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


 