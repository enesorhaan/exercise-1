using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finding even numbers from the numbers entered by the user
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} positive numbers:",n);
            int[] sayilar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            foreach (var sayi in sayilar)
            {
                if(sayi%2==0)
                    Console.WriteLine(sayi);
            }
        }
    }
}
