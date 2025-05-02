using System;
using System.Collections.Generic;

namespace p2W12TH
{
    public class QueueSequence
    {
        // Method to generate the first 50 elements of the sequence
        public static void GenerateSequence(int N)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);

            Console.WriteLine("First 50 elements of the sequence:");
            for (int i = 0; i < 50; i++)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }

            Console.WriteLine(); // Add a newline for better formatting
        }

        // Optional: If there are other unique methods in either file, include them here
    }
}
