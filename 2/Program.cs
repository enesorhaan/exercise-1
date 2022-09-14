using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numbers entered by the user, which are divisible by m
            Console.WriteLine("Enter two positive numbers: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter {0} positive numbers:",n);
            int[] sayilar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            foreach (var sayi in sayilar)
            {
                if(sayi%m==0)
                    Console.WriteLine(sayi);
            }
        }
    }
}   
