
using System.Collections;

Console.WriteLine("welcome to student grade calculator");
Console.WriteLine("write your name please");
string name = Console.ReadLine();

Console.Write("how many subjects: ");
int numGrade = Convert.ToInt32((string)Console.ReadLine());

int totalGrade = 0;
int errors = 0;
double average;
Dictionary<string, string> subjectGrade = new Dictionary<string, string>();

double calculate_average(int total , int numGrade)
{
    average = total / numGrade;
    return average;
}

Console.WriteLine("for each subject yout take write your subject and your corresponding grade space separated");
for (int i = 0; i < numGrade; i++)
{
    string[] userInput = Console.ReadLine().Split();
    if (userInput[0] != null  && 0 < Convert.ToInt32(userInput[1]) && Convert.ToInt32(userInput[1]) < 101)
    {
        if (!subjectGrade.ContainsKey(userInput[0]))
        {
            subjectGrade.Add(userInput[0], userInput[1]);
        }
    }
    else
    {
        Console.WriteLine("your last input is not recoded because either the grade you provided is out of range or you provided no subject ");
        numGrade += 1;
        errors += 1;
    }

}

Console.WriteLine("Calculating your average Grade");
foreach(var value in subjectGrade.Values)
{
    totalGrade += Convert.ToInt32(value);
}


Console.WriteLine("your average grade is");
Console.WriteLine("Average Grade: " + calculate_average(totalGrade , numGrade - errors));