using System;
// //The complete basic layout of the code::
// //initialize variables - graded assignments 

//int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;


// //shorten version of the code::

// int currentAssignments = 5;
// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
// foreach (string name in studentNames)
// {
//     Console.WriteLine($"{name}");

// }

// int[] sophiaScores = new int[] {90, 86, 87, 98, 100}; //longer way of doing it
// int[] andrewScores = [92, 89, 81, 96, 90];
// int[] emmaScores = [90, 85, 87, 98, 68];
// int[] loganScores = [90, 95, 87, 88, 96];

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;
// //simplified into "sum = 0"

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;
// //simplified into "decimal studentScore"

//     foreach (int score in sophiaScores)
//     {
//         sophiaSum += score;
//     }
//     ;

// foreach (int score in andrewScores)
// {
//     andrewSum += score;
// }
// ;

// foreach (int score in emmaScores)
// {
//     emmaSum += score;
// };

// foreach (int score in loganScores)
// {
//     loganSum += score;
// };


// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;
// //simplfied to "studentScore = "

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();


// //EVEN SHORTER SIMPLIFIED CODE LAYOUT(HOW IT SHOULD BE):::

int currentAssignments = 5;
string currentStudentLetterGrade = "";

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] jackScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[10];

    Console.WriteLine("\nStudent\t\tGrade");
// //'name' could be used to substitute 'currentStudent' but this is to see logic better
foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
        
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;
        
    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;
        
   //links all name vars to one var "currentStudent" and all the diff array scores to "studentScores"

    int sum = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal studentScore = 0;

    int gradedAssignments = 0;

    int examAssignments = currentAssignments;
    //changing the var name to not get confused

    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;
        
        if (gradedAssignments <= examAssignments)
            sum += score;

        else
        sum += score / 10;

    }
    ;

    /*student-agnostic array - doesn't belong to a single var, can be used for multiple vars 
    "studentScores = sophiaScores" - a single var assigned to other diff vars so they all attached to one var*/

    studentScore = (decimal)(sum) / examAssignments;

    //the last var we used "studentScore" is used to find the letter grade//

    

    if (studentScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (studentScore >= 93)
        currentStudentLetterGrade = "A";

    else if (studentScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (studentScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (studentScore >= 83)
        currentStudentLetterGrade = "B";

    else if (studentScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (studentScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (studentScore >= 73)
        currentStudentLetterGrade = "C";

    else if (studentScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (studentScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (studentScore >= 63)
        currentStudentLetterGrade = "D";

    else if (studentScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t {studentScore} \t{currentStudentLetterGrade}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
