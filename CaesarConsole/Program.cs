using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input here: ");
            string inputMessage = Console.ReadLine();
             
            string outputMessage = RotCaesar(inputMessage);
            Console.WriteLine("Rotated by 13 is: " + outputMessage);
            Console.ReadLine();
        }

        public static string RotCaesar(string inputMessage)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int char_pos = 0;
            char rotated_char;
            //int inputLength = inputMessage.Length;
            //string [] char_arr = new string[inputLength]; // initialize an array same length as that of inputMessage
            List<char> char_arr = new List<char>();
            //string empty = "";

            for (int i = 0; i < inputMessage.Length; i++) // loop through input message
            {
                if (alphabet.Contains(inputMessage[i])) // check if input contains characters from alphabet
                {
                    // return character index in the alphabet
                    char_pos = alphabet.IndexOf(inputMessage[i]);
                }   //TODO: else ignore said char
            }

            int char_rot = char_pos + 13; // rotated character's index by 13

            if (char_rot < 26) // less than total amount of characters in English alphabet
            {
                rotated_char = alphabet[char_rot]; // return rotated characters index in English alphabet
            }

            else // wrap text from beginning of alphabet again
            {
                rotated_char = alphabet[char_rot % 26];  // TODO: add rotated to string for output
            }

            for (int j = 0; j < char_arr.Count; j++)
            {
                char_arr.Add(rotated_char); // add rotated characters to List of chars
            }

            string ReturnString = string.Join("*", char_arr.ToArray());

            return ReturnString;
        }
    }
}
