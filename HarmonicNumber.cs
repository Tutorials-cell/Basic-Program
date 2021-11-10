using System;
using System.Collections.Generic;
using System.Text;

namespace HarmonicNumber
{
   public class Harmonic
    {
        public void printHarm()
        {
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());
            double i, s = 0.0;
            for (i = 1; i <= num; i++)
            {
                s = s + 1 / i;
            }
            Console.WriteLine(s);
        }

        internal static object PrintHarm()
        {
            throw new NotImplementedException();
        }
    }
}
    

