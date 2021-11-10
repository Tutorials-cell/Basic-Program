using BasicLogicProgram;
using BasicLogoicProgram;
using HarmonicNumber;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using static BasicLogoicProgram.Factors;

namespace CoinFlip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Label: Console.WriteLine("1.print the percentage coin Flip \n 2. Check Leap Year Or Not \n 3. Factors 4. Harmonic Number /n 5. Power2");
            Console.WriteLine("Type the options");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("1.Print the percentage coin Flip");
                    percentageOfHeadAndTail percentageOfHeadAndTail = new percentageOfHeadAndTail();
                        percentageOfHeadAndTail.printHeadAndTail();
                    break;
                case 2:
                    Console.WriteLine("2. check Leap Year Or Not");
                    CheckLeapYaerOrNot checkLeapYaerOrNot = new CheckLeapYaerOrNot();
                    checkLeapYaerOrNot.isReverseNum();
                  break;
                case 3:
                       
                    Console.WriteLine("3. Factors");
                    Factor factors = new Factor();
                    Factor.PrintFact();
                    break;
                case 4:
                    Console.WriteLine("4. Harmonic Number");
                    Harmonic Harmonic = new Harmonic();
                    Harmonic.printHarm();

                  
                    break;
                case 5:
                    Console.WriteLine("5 Power 2");
                    PowerOfTwo powerOfTwo = power2();
                    powerOfTwo.printTwo();
                    break;










                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("Do you want to continue...yes/No");
            if (Console.ReadKey().KeyChar.ToString() == "yes")
            {
                goto Label;
            }
            Console.ReadKey();
        }

        private static PowerOfTwo power2()
        {
            throw new NotImplementedException();
        }

        private static void NewMethod4()
        {
            NewMethod3();
        }

        private static void NewMethod3()
        {
            NewMethod2();
        }

        private static void NewMethod2()
        {
            NewMethod1();
        }

        private static void NewMethod1()
        {
            Console.WriteLine(" HarmonicNumber");
        }

        
        }
    }






     