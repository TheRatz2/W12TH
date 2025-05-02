using System;
using System.Collections.Generic;
using System.Linq;

namespace p2W12TH
{
    public class NumberCounter
    {
        // Method to count occurrences of numbers in an array
        public static void CountNumbers(int[] numbers)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            Console.WriteLine("Number frequencies:");
            foreach (var pair in counts.OrderBy(pair => pair.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} times");
            }
        }

        // Method to read N integers and print them in reversed order using Stack<int>
        public static void PrintReversedOrder()
        {
            Console.Write("Enter the number of integers (N): ");
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            Console.WriteLine($"Enter {n} integers:");
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            Console.WriteLine("Reversed order:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        // Method to generate and print the first 50 elements of the sequence
        public static void GenerateSequence(int n)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            Console.WriteLine("First 50 elements of the sequence:");
            for (int i = 0; i < 50; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
        }

        // Main method to demonstrate the functionality
        public static void Run()
        {
            try
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Count numbers in an array");
                Console.WriteLine("2. Print numbers in reversed order");
                Console.WriteLine("3. Generate a sequence");
                Console.Write("Enter your choice (1-3): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Example for CountNumbers:");
                            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
                            CountNumbers(array);
                            break;

                        case 2:
                            Console.WriteLine("Example for PrintReversedOrder:");
                            PrintReversedOrder();
                            break;

                        case 3:
                            Console.Write("Enter the starting number (N) for the sequence: ");
                            if (int.TryParse(Console.ReadLine(), out int n))
                            {
                                GenerateSequence(n);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option (1-3).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
