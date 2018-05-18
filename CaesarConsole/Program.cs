using System;
using System.Collections.Generic;
using System.Linq;

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
            List<int> char_pos = new List<int>();
            List<char> char_arr = new List<char>();
            List<int> char_rot = new List<int>();
            char rotated_char; // TODO: change input function to ignore space and nonalpha characters

            for (int i = 0; i < inputMessage.Length; i++) // loop through input message
            {
                if (alphabet.Contains(inputMessage[i]) && Char.IsLetter(inputMessage[i])) // check if input contains characters from alphabet
                {
                    // return character index in the alphabet
                    char_pos.Add(alphabet.IndexOf(inputMessage[i])); // add to list of initial index positions
                }   //TODO: else ignore said char
                //else
                //    char_arr.Insert(i, inputMessage[i]);
            }
            
            for (int j = 0; j < char_pos.Count; j++)
            {
                char_rot.Add(char_pos[j] + 13); // add to list of rotated position
            }

            for (int i = 0; i < char_rot.Count; i++) {

                if (char_rot[i] < 26)
                {
                    rotated_char = alphabet[char_rot[i]];
                    char_arr.Add(rotated_char); // add to list of strings
                }

                else // if rotated characters is beyond alphabet, wrap it around
                {
                    rotated_char = alphabet[char_rot[i] % 26];
                    char_arr.Add(rotated_char);
                }
            }
            string ReturnString = string.Join("", char_arr.ToArray()); // build output string

            return ReturnString;
        }
    }
}
