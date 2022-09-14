using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //The total number of words and letters in the sentence

            Console.Write("Write a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
            
            Console.WriteLine("Cümledeki toplam kelime sayisi: {0}, toplam harf sayisi: {1}", words.Length, sentence.Length - words.Length + 1);
        }
    }
}
