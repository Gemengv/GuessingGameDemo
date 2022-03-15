using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDemo
{
    public class StartUp
    {
        private Service _service = new Service();

        // Add Methods
        public void Run()
        {
            int maxNum = ConsoleIO.GetMaxNum();
            _service.CreateRandomNumber(maxNum);

            //TODO: Add While Loop
            while (true)
            {
                if (CheckGuess())
                {
                    break;
                }
            }
            
        }

        public bool CheckGuess()
        {

            // TODO: Guess a number between one and some maximum.
            ConsoleIO.DisplayMessage($"Guess a number between 1 and {_service.MaxNum}: ");
            int userGuess = ConsoleIO.GetGuess(_service.MaxNum);

            _service.GuessCount++;

          
                if (userGuess == _service.TargetNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    ConsoleIO.DisplayMessage($"You guessed it right! The number was {_service.TargetNum} and it took you {_service.GuessCount} guesses!");
                    Console.ForegroundColor = ConsoleColor.White;

                return true;
                }
                else if (userGuess < _service.TargetNum)
                {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleIO.DisplayMessage("Guess is too low, try something higher!\n");
                Console.ForegroundColor = ConsoleColor.White;

                return false;
                }
                else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleIO.DisplayMessage("Guess is too high, try something lower!\n ");
                Console.ForegroundColor = ConsoleColor.White;

                return false;
            }

        }

    }
}
