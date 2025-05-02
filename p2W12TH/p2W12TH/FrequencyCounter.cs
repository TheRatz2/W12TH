using System;
using System.Collections.Generic;
using System.Linq;

namespace p2W12TH
{
    class FrequencyCounter
    {
        public static void Run() // Renamed from Main to Run to resolve the CS0017 error
        {
            // Part 2.2: Read N integers and print them in reversed order using Stack<int>
            Console.WriteLine("Enter the number of integers (N):");
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

            // Part 2.7: Count occurrences of integers in a given array
            int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            Console.WriteLine("Occurrences of each number:");
            foreach (var entry in countMap.OrderBy(e => e.Key))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} times");
            }

            // Part 2.9: Generate and print the first 50 elements of the sequence
            Console.WriteLine("Enter the starting number (N) for the sequence:");
            int start = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            Console.WriteLine("First 50 elements of the sequence:");
            for (int i = 0; i < 50; i++)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            Console.ReadKey(); // Keep the console open
        }
    }
}
