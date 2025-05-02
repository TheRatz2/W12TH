// Ensure there is only one Main method in the project.
// If there are multiple Main methods, remove or comment out the others.

namespace p2W12TH
{
    class Program
    {
        public static void Main(string[] args)
        {
            // The input sequence
            int[] numbers = {
                2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, 5, 9, 6, 8, 15, 9, 6, 11, 7, 7, 13,
                8, 12, 23, 13, 8, 15, 9, 6, 11, 7, 10, 19, 11, 7, 13, 8, 6, 11, 7, 10, 19,
                11, 7, 13, 8, 9, 17, 10, 16, 31, 17, 10, 19, 11, 7, 13, 8, 12, 23, 13, 8,
                15, 9, 8, 15, 14, 27, 15, 9, 17, 10, 13, 25, 14
            };

            // Call the NumberCounter class to count numbers
            NumberCounter.CountNumbers(numbers);

            // Or you could run a different feature
            // FrequencyCounter.RunFrequencyCounter(args);
            // QueueSequence.RunQueueSequence(args); // etc.
        }
    }
}

// Ensure no other class in the project defines a Main method.
