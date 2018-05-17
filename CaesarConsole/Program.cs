using System;
using System.Collections.Generic;

namespace CaesarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input here: ");
            string inputMessage = Console.ReadLine();
            //string outputMessage = RotCaesar(inputMessage);
            //Console.WriteLine("Rotated by 13 is: " +outputMessage);
            Console.ReadLine();
        }

        public static int RotCaesar(string inputMessage)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int char_position = 0;

            foreach (char characters in inputMessage)
            {
                char_position += alphabet.IndexOf(characters);
            }

            Console.WriteLine(char_position);
            Console.ReadLine();
            return char_position;
        }
    }
}
