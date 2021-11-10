using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogoicProgram
{

    class Factors
    {
    
     
        
    
        public class Factor
        {
            public void printFact()
            {
                Console.WriteLine("Enter then number:");
                int num = int.Parse(Console.ReadLine());
                int i;
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }

            internal static void PrintFact()
            {
                throw new NotImplementedException();
            }
        }
    }
}

