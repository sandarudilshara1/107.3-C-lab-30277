﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student's name:");
        string studentName = Console.ReadLine();

        Console.WriteLine("Enter student's exam marks:");
        if (int.TryParse(Console.ReadLine(), out int examMarks))
        {
            char grade = CalculateGrade(examMarks);
            Console.WriteLine($"{studentName}'s Grade: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid input for exam marks. Please enter a valid integer.");
        }

        Console.ReadLine(); // Pause to keep the console window open
    }

    static char CalculateGrade(int marks)
    {
        char grade;

        if (marks >= 75 && marks <= 100)
        {
            grade = 'A';
        }
        else
        {
            grade = 'F'; // Default to 'F' for any other marks
        }

        return grade;
    }
}