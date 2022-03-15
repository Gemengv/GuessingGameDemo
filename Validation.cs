using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDemo
{
    class Validation
    {
        public  void Prompt2Continue()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }

        public  string PromptRequired(string message)
        {
            string res = PromptUser(message);
            while (string.IsNullOrEmpty(res))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input required❗");
                res = PromptUser(message);
                Console.ForegroundColor = ConsoleColor.White;

            }

            return res;
        }

        public  static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine() ?? string.Empty;
        }

        public static int PromptUser4Int(string message, int min = Int32.MinValue, int max = Int32.MaxValue)
        {
            int result;
            while (!(int.TryParse(PromptUser(message), out result)) || result < min || result > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                PromptUser($@"Invalid Input, must be between {min} and {max}
Press Enter to Continue");
                Console.ForegroundColor = ConsoleColor.White;

            }

            return result;
        }
    }
}