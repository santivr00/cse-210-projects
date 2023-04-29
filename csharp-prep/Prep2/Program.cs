using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student's grade");
        Console.Write("What's the student's final score? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";   
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Your final grade is {letter}");
            Console.WriteLine("Congratulations on your hard work!");
        }
        else
        {
            Console.WriteLine($"Your final grade is: {letter}");
            Console.WriteLine("Work harder next time!");     
        }
    }
}