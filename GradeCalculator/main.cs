using System;

class Program {
  public static void Main (string[] args) {
    // Prompt the user to enter a numerical grade
    Console.WriteLine("Enter a numerical grade between 0 and 100: ");
    string input = Console.ReadLine();

    // Convert the input string to an integer
    int grade;
    if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
    {
        // Determine the letter grade based on the numerical grade
        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Display the letter grade
        Console.WriteLine($"Your grade is: {letterGrade}");
    }
    else
    {
        // Display an error message if the input is not a valid numerical grade
        Console.WriteLine("Please enter a valid numerical grade between 0 and 100.");
    }
    }
    }