using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Recursive
{
    public class Multiply
    {
        public int Run(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0) return 0;
            var factor = 1;
            if(secondNumber <0)
            {
                factor = -1;
                secondNumber = secondNumber * factor;
            }
            return factor * ( firstNumber + Run(firstNumber, secondNumber - 1));
        }
    }
}
