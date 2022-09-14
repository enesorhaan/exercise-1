using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorting the words entered by the user from the bottom to the top
            Console.WriteLine("Enter a positive numbers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} words: ",n);
            string[] words = Console.ReadLine().Split(' ');

            Array.Reverse(words);

            foreach (var entry in words)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
