using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student's grade");
        Console.Write("What's the student's final score? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);

        if (grade >= 90)
        {
            Console.WriteLine("They're final grade is an A");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine("They're final grade is a B");
        }
        else if (grade < 80 && grade >= 70)
        {
            Console.WriteLine("They're final grade is a C");
        }
        else if (grade < 70 && grade >= 60)
        {
            Console.WriteLine("They're final grade is a D");
        }
        else
        {
            Console.WriteLine("They're final grade is an F");
        }
    }
}