using System;

class Program {
  public static void Main (string[] args) {
                  // Prompt the user to enter their age
                  Console.WriteLine("Enter your age: ");
                  string input = Console.ReadLine();

                  // Convert the input string to an integer
                  int age;
                  if (int.TryParse(input, out age) && age >= 0)
                  {
                      // Determine the ticket price based on the age
                      int ticketPrice;
                      if (age <= 12 || age >= 65)
                      {
                          ticketPrice = 7;
                      }
                      else
                      {
                          ticketPrice = 10;
                      }

                      // Display the ticket price
                      Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
                  }
                  else
                  {
                      // Display an error message if the input is not a valid age
                      Console.WriteLine("Please enter a valid age.");
                  }
              }
          }
