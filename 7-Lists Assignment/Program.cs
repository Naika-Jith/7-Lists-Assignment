
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "7-Lists Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Welcome to the Lists Assignment!");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();

            // Run Part 1 - Lists of Integers
            Part1();

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue to Part 2...");
            Console.ReadLine();

            Console.Clear();

            // Run Part 2 - Lists of Strings
            Part2();

            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        // PART 1 - LISTS OF INTEGERS
      

        static void Part1()
        {
            // Create a list of integers
            List<int> numbers = new List<int>();

            Random generator = new Random();

            // Fill the list with 25 random numbers from 10-20
            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(10, 21));
            }

            // Print the original list
            Console.WriteLine("Here is the list of numbers:");
            Console.Write("[");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);

                // Print a comma between numbers
                if (i < numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");

            // Menu
            string choice = "";

            // Repeat the menu until the user chooses 8
            while (choice != "8")
            {
                Console.WriteLine();
                Console.WriteLine("===== LIST MENU =====");
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number");
                Console.WriteLine("4 - Add a value");
                Console.WriteLine("5 - Count occurrences of a number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Quit and proceed to Part 2");
                Console.WriteLine("9 - Print the sum and average");
                Console.WriteLine("10 - Print the most frequently occurring value(s)");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().Trim();

                Console.WriteLine();

                // OPTION 8 - Quit
                if (choice == "8")
                {
                    Console.WriteLine("Thank you for using the Lists Assignment!");
                }

                // OPTION 1 - Sort the list
                else if (choice == "1")
                {
                    // Sort the numbers from smallest to largest
                    numbers.Sort();

                    Console.WriteLine("The list has been sorted!");
                }

                // OPTION 2 - Make a new list of random numbers
                else if (choice == "2")
                {
                    // Remove all numbers from the current list
                    numbers.Clear();

                    // Add 25 new random numbers
                    for (int i = 0; i < 25; i++)
                    {
                        numbers.Add(generator.Next(10, 21));
                    }

                    Console.WriteLine("A new list of random numbers has been created!");
                }

                // OPTION 3 - Remove a number
                else if (choice == "3")
                {
                    Console.Write("Enter a number to remove: ");

                    int value;

                    // Check if the user entered a valid integer
                    if (int.TryParse(Console.ReadLine(), out value))
                    {
                        // Remove ALL occurrences of the number
                        int removed = numbers.RemoveAll(n => n == value);

                        // Check if any numbers were removed
                        if (removed > 0)
                        {
                            Console.WriteLine("The number was removed " + removed + " time(s).");
                        }
                        else
                        {
                            Console.WriteLine("The number was not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }

                // OPTION 4 - Add a value
                else if (choice == "4")
                {
                    Console.Write("Enter a number to add: ");

                    int value;

                    // Check if the input is a valid integer
                    if (int.TryParse(Console.ReadLine(), out value))
                    {
                        // Add the number to the list
                        numbers.Add(value);

                        Console.WriteLine("The number was added!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }

                // OPTION 5 - Count occurrences
                else if (choice == "5")
                {
                    Console.Write("Enter a number to count: ");

                    int value;

                    // Check if the input is a valid integer
                    if (int.TryParse(Console.ReadLine(), out value))
                    {
                        // Start the counter at zero
                        int count = 0;

                        // Loop through the list
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            // Check if the current number matches the value
                            if (numbers[i] == value)
                            {
                                // Increase the counter
                                count++;
                            }
                        }

                        Console.WriteLine("The number appears " + count + " time(s).");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }

                // OPTION 6 - Print the largest value
                else if (choice == "6")
                {
                    // Check if the list contains numbers
                    if (numbers.Count > 0)
                    {
                        // Max() finds the largest number
                        Console.WriteLine("The largest value is: " + numbers.Max());
                    }
                    else
                    {
                        Console.WriteLine("The list is empty.");
                    }
                }

                // OPTION 7 - Print the smallest value
                else if (choice == "7")
                {
                    // Check if the list contains numbers
                    if (numbers.Count > 0)
                    {
                        // Min() finds the smallest number
                        Console.WriteLine("The smallest value is: " + numbers.Min());
                    }
                    else
                    {
                        Console.WriteLine("The list is empty.");
                    }
                }

                // OPTION 9 - Print the sum and average
                else if (choice == "9")
                {
                    // Check if the list contains numbers
                    if (numbers.Count > 0)
                    {
                        // Start the sum at zero
                        int sum = 0;

                        // Loop through every number in the list
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            // Add the current number to the total
                            sum += numbers[i];
                        }

                        // Divide the sum by the number of items
                        // Convert sum to double to allow decimal answers
                        double average = (double)sum / numbers.Count;

                        // Display the sum and average
                        Console.WriteLine("The sum is: " + sum);
                        Console.WriteLine("The average is: " + average);
                    }
                    else
                    {
                        Console.WriteLine("The list is empty.");
                    }
                }

                // OPTION 10 - Determine the most frequently occurring value(s)
                else if (choice == "10")
                {
                    // Check if the list contains numbers
                    if (numbers.Count > 0)
                    {
                        // Store the highest number of occurrences found
                        int highestCount = 0;

                        // FIRST PART:
                        // Find the highest frequency
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            // Count how many times the current number appears
                            int count = 0;

                            // Compare the current number with every number in the list
                            for (int j = 0; j < numbers.Count; j++)
                            {
                                // Check if the numbers match
                                if (numbers[i] == numbers[j])
                                {
                                    // Increase the counter
                                    count++;
                                }
                            }

                            // Check if this number appeared more times than the previous highest
                            if (count > highestCount)
                            {
                                // Update the highest frequency
                                highestCount = count;
                            }
                        }

                        // SECOND PART:
                        // Print the number(s) with the highest frequency
                        Console.WriteLine("The most frequently occurring value(s):");

                        // Loop through each number in the list again
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            // Count the occurrences of the current number
                            int count = 0;

                            // Track whether the number has already been printed
                            bool alreadyPrinted = false;

                            // Loop through the entire list to count matches
                            for (int j = 0; j < numbers.Count; j++) // Compare the current number with every number in the list (j)
                            {
                                // Check if the numbers match
                                if (numbers[i] == numbers[j])
                                {
                                    // Increase the counter
                                    count++;
                                }
                            }

                            // Check the positions before the current index
                            for (int j = 0; j < i; j++)
                            {
                                // If the number appeared earlier
                                if (numbers[i] == numbers[j])
                                {
                                    // Mark it as already printed
                                    alreadyPrinted = true;
                                }
                            }

                            // Check if the number has the highest frequency
                            // AND has not already been printed
                            if (count == highestCount && !alreadyPrinted)
                            {
                                // Print the number and its frequency
                                Console.WriteLine(numbers[i] + " appears " + count + " time(s).");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The list is empty.");
                    }
                }

                // Invalid menu choice
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

      
        // PART 2 - LISTS OF STRINGS
     

        static void Part2()
        {
            // Create a list containing five vegetables
            // All vegetable names are stored in uppercase
            List<string> vegetables = new List<string>()
            {
                "CARROT",
                "BEET",
                "CELERY",
                "RADISH",
                "CABBAGE"
            };

            // Display the original list of vegetables
            Console.WriteLine("Vegetables:");

            for (int i = 0; i < vegetables.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + vegetables[i]);
            }

            // Store the user's menu choice
            string choice = "";

            // Repeat the menu until the user chooses 7
            while (choice != "7")
            {
                Console.WriteLine();
                Console.WriteLine("===== VEGETABLE MENU =====");
                Console.WriteLine("1 - Remove a vegetable by index");
                Console.WriteLine("2 - Remove a vegetable by value");
                Console.WriteLine("3 - Search for a vegetable");
                Console.WriteLine("4 - Add a vegetable");
                Console.WriteLine("5 - Sort the list");
                Console.WriteLine("6 - Clear the list");
                Console.WriteLine("7 - Quit");
                Console.WriteLine();

                // Ask the user to enter their choice
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine().Trim();

                Console.WriteLine();

                // OPTION 1 - Remove a vegetable by index
                if (choice == "1")
                {
                    Console.Write("Enter the index of the vegetable to remove: ");

                    int index;

                    // Check if the input is a valid integer
                    if (int.TryParse(Console.ReadLine(), out index))
                    {
                        // Check if the index is within the list's range
                        if (index >= 0 && index < vegetables.Count)
                        {
                            // Remove the vegetable at the specified index
                            vegetables.RemoveAt(index);

                            Console.WriteLine("The vegetable was removed!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }

                // OPTION 2 - Remove a vegetable by value
                else if (choice == "2")
                {
                    Console.Write("Enter the vegetable to remove: ");

                    // Convert the user's input to uppercase
                    string vegetable = Console.ReadLine().Trim().ToUpper();

                    // Remove the vegetable if it is found
                    if (vegetables.Remove(vegetable))
                    {
                        Console.WriteLine("The vegetable was removed!");
                    }
                    else
                    {
                        Console.WriteLine("Vegetable not found.");
                    }
                }

                // OPTION 3 - Search for a vegetable
                else if (choice == "3")
                {
                    Console.Write("Enter the vegetable to search for: ");

                    // Convert the input to uppercase
                    string vegetable = Console.ReadLine().Trim().ToUpper();

                    // Find the index of the vegetable
                    // IndexOf() returns -1 if it is not found
                    int index = vegetables.IndexOf(vegetable);

                    // Check if the vegetable was found
                    if (index != -1)
                    {
                        Console.WriteLine("The vegetable was found!");

                        // Display the index of the vegetable
                        Console.WriteLine("Index: " + index);
                    }
                    else
                    {
                        Console.WriteLine("Vegetable not found.");
                    }
                }

                // OPTION 4 - Add a vegetable
                else if (choice == "4")
                {
                    Console.Write("Enter a vegetable to add: ");

                    // Convert the input to uppercase
                    string vegetable = Console.ReadLine().Trim().ToUpper();

                    // Check if the vegetable already exists
                    if (vegetables.Contains(vegetable))
                    {
                        // Do not add duplicate vegetables
                        Console.WriteLine("Error: This vegetable is already in the list.");
                    }
                    else
                    {
                        // Add the vegetable to the list
                        vegetables.Add(vegetable);

                        Console.WriteLine("The vegetable was added!");
                    }
                }

                // OPTION 5 - Sort the list
                else if (choice == "5")
                {
                    // Sort the vegetables alphabetically
                    vegetables.Sort();

                    Console.WriteLine("The list has been sorted!");
                }

                // OPTION 6 - Clear the list
                else if (choice == "6")
                {
                    // Remove all vegetables from the list
                    vegetables.Clear();

                    Console.WriteLine("The list has been cleared!");
                }

                // OPTION 7 - Quit
                else if (choice == "7")
                {
                    Console.WriteLine("Thank you for using the Lists Assignment!");
                }

                // Invalid menu choice
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                // Display the updated list after each option
                // Do not display it after choosing Quit
                if (choice != "7")
                {
                    Console.WriteLine();
                    Console.WriteLine("Vegetables:");

                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " - " + vegetables[i]);
                    }
                }
            }
        }

 
        
    }
}
