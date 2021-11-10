using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogoicProgram
{
   
    
        public class PowerOfTwo
        {
            public void printTwo()
            {
                Console.WriteLine("Enter th number:");
                int n = int.Parse(Console.ReadLine());

                int i = 0;
                int powerOfTwo = 1;
                while (i <= n)
                {
                    Console.WriteLine(i + " " + powerOfTwo);
                    powerOfTwo = 2 * powerOfTwo;
                    i = i + 1;
                }

            }
        }
    }


