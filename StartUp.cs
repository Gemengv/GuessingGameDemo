using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDemo
{
    public class StartUp
    {
        // TODO: What properties do I need

        private Service _service = new Service();
        // Add Methods
        public void Run()
        {
            Console.Write("Running!");
            int maxNum = ConsoleIO.GetMaxNum();
            _service.CreateRandomNumber(maxNum);
        }

        public void CheckGuess()
        {
            // TODO: Guess a number between one and some maximum.
            ConsoleIO.DisplayMessage($"Guess a number between 1 and ....");
        }

    }
}
