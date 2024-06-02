using System;

class Program {
  public static void Main (string[] args) {
                       // Prompt the user to enter the lengths of the three sides of a triangle
                       Console.WriteLine("Enter the length of the first side: ");
                       string input1 = Console.ReadLine();

                       Console.WriteLine("Enter the length of the second side: ");
                       string input2 = Console.ReadLine();

                       Console.WriteLine("Enter the length of the third side: ");
                       string input3 = Console.ReadLine();

                       // Convert the input strings to integers
                       double side1, side2, side3;
                       if (double.TryParse(input1, out side1) && side1 > 0 &&
                           double.TryParse(input2, out side2) && side2 > 0 &&
                           double.TryParse(input3, out side3) && side3 > 0)
                       {
                           // Determine the type of the triangle based on the side lengths
                           if (side1 == side2 && side2 == side3)
                           {
                               Console.WriteLine("The triangle is Equilateral.");
                           }
                           else if (side1 == side2 || side1 == side3 || side2 == side3)
                           {
                               Console.WriteLine("The triangle is Isosceles.");
                           }
                           else
                           {
                               Console.WriteLine("The triangle is Scalene.");
                           }
                       }
                       else
                       {
                           // Display an error message if the input is not valid
                           Console.WriteLine("Please enter valid positive numbers for the sides of the triangle.");
                       }
                   }
               }

