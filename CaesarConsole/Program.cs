﻿using System;
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
            // string outputMessage = RotCaesar(inputMessage);
            // Console.WriteLine("Rotated by 13 is: " +outputMessage);
            Console.ReadLine();
        }

        public static string RotCaesar(string inputMessage)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int char_pos = 0;
            int inputLength = inputMessage.Length;
            string [] char_arr = new string[inputLength]; // initialize an array same length as that of inputMessage
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
                char rotated_char = alphabet[char_rot]; // return rotated characters index in English alphabet
            }

            else // wrap text from beginning of alphabet again
            {
                char rotated_char = alphabet[char_rot % 26];  // TODO: add rotated to string for output
            }
        }
    }
}
