using System;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine(); 
            Acronym acronym = new Acronym(sentence);
            acronym.BuildAcronym();
            acronym.DisplayAcronym();
            Console.WriteLine("press any keys to to exit..");
            Console.ReadKey();
        }
        
    }
}
