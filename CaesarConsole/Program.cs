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
            char rotated_char;

            for (int i = 0; i < inputMessage.Length; i++) // loop through input message
            {
                if (alphabet.Contains(inputMessage[i])) // check if input contains characters from alphabet
                {
                    // return character index in the alphabet
                    char_pos.Add(alphabet.IndexOf(inputMessage[i]));
                }   //TODO: else ignore said char FIXED
                //Console.WriteLine(char_pos[i]);
            }
            
            for (int j = 0; j < char_pos.Count; j++)
            {
                char_rot.Add(char_pos[j] + 13);
            }

            for (int i = 0; i < char_rot.Count; i++) {

                if (char_rot[i] < 26)
                {
                    rotated_char = alphabet[char_rot[i]];
                    char_arr.Add(rotated_char);
                }

                else
                {
                    rotated_char = alphabet[char_rot[i] % 26];
                    char_arr.Add(rotated_char);
                }
            }
            string ReturnString = string.Join("", char_arr.ToArray());

            return ReturnString;
        }
    }
}
