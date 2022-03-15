using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDemo
{
    public class ConsoleIO
    {
        public static void DisplayMessage(string message)
        {
            Console.Write(message);
        }

        public static int GetGuess(int maxNum)
        {
            
            return Validation.PromptUser4Int("Enter your guess: ", 1, maxNum);
        }
        public static int GetMaxNum()
        {
            return Validation.PromptUser4Int("Enter the max number to guess");
        }
    }
}
