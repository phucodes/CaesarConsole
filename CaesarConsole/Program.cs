using System;

namespace CaesarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your input here: ");
            string inputMessage = Console.ReadLine();
            string outputMessage = RotCaesar(inputMessage);
            Console.WriteLine("Rotated by 13 is: " +outputMessage);
            Console.ReadLine();
        }

        private static string RotCaesar(string inputMessage)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int char_position;

            for (int i = 0; i < inputMessage.Length; i++)
            {

            }
        }
    }
}
