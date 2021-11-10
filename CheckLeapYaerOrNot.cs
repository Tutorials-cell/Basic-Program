using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicProgram
{
    class CheckLeapYaerOrNot
    {
        //input 12345
        //output: 54321
        public void isReverseNum()
        {
            int perNum = int.Parse(Console.ReadLine());
            int rev = 0;
            while (perNum > 0)
            {
                int rem = perNum % 10;
                rev = (rev * 10) + rem;
                perNum = perNum / 10;
            }
            Console.WriteLine("reverse number is: " + rev);
        }
    }
}