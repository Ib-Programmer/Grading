using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        string[] studentNames = new string[numberOfStudents];
        double[] studentScores = new double[numberOfStudents];
        char[] studentGrades = new char[numberOfStudents];

        // Input: Accepting names and scores
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter the name of student {i + 1}: ");
            studentNames[i] = Console.ReadLine();

            Console.Write($"Enter the score of {studentNames[i]}: ");
            studentScores[i] = double.Parse(Console.ReadLine());
        }

        // Process: Grading
        for (int i = 0; i < numberOfStudents; i++)
        {
            if (studentScores[i] >= 70)
                studentGrades[i] = 'A';
            else if (studentScores[i] >= 60)
                studentGrades[i] = 'B';
            else if (studentScores[i] >= 50)
                studentGrades[i] = 'C';
            else if (studentScores[i] >= 45)
                studentGrades[i] = 'D';
            else
                studentGrades[i] = 'F';
        }

        // Output: Displaying names with grades
        Console.WriteLine("\n\nStudent Grades:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{studentNames[i]} - Grade: {studentGrades[i]}");
        }
    }
}

