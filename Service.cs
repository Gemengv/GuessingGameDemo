using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDemo
{
    public class Service
    {
        // Handles business logic for application

        private Random ranNum = new Random();
        private int _maxNumer;

        public int GuessCount { get; set; }
        public int TargetNum { get; private set; }
        public int MaxNum { get; private set; }
        

        //Used to replace the get/set method within constructors above.
      /*      public Service(int maxNum)
        {
            _maxNumer = maxNum;
        }
       */

        public void CreateRandomNumber(int maxValue)
        {
            MaxNum = maxValue;
            TargetNum = ranNum.Next(1, MaxNum + 1);
        }


      
    }
}
