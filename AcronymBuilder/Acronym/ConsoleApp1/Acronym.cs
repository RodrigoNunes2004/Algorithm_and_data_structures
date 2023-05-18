using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Acronym
    {
        //private fields
        private string FullSentence;// Store the full sentence
        private string[] Words;//Stores each word of the sentence
        private Dictionary<char, string> AcronymDictionary;//stores the key value pairs

        public Acronym(string sentence)//Parameterized constructor to access the instances to initializes 
            // FullSentence to the value of sentence
        {
            FullSentence = sentence;
            AcronymDictionary = new Dictionary<char, string>();//New instance of dictionary
        }

        public void BuildAcronym()
        {
            
            Words = FullSentence.Split(' ');//Splits the FullSentence string into substrings and stores them in the
        //Words array
            
            foreach (var word in Words)//Interates over each word in array
            {
                char key = word.ToUpper()[0];//Method to extract the first letter to upercase

                //Checks if the key is already exists in the dictionary and if does takes the second char to lowercase
                if (AcronymDictionary.ContainsKey(key))
                {
                    key = word.ToLower()[0];
                }
                
                //Adds the key value pair to the dictionary
                AcronymDictionary.Add(key, word);
            }
        }

        //Display the key value pairs in the dictionary
        public void DisplayAcronym()
        {
            //interates over each key value pair
            foreach (var acronymDictionary in AcronymDictionary)
            {
                //Output the key value pairs
                Console.WriteLine($"{acronymDictionary.Key} : {acronymDictionary.Value}");
            }
        }
    }
}
