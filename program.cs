using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LogicalPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {

            Label: Console.WriteLine(" 1.Febinoccis \n 2. PerfectNumber \n 3. PrimeNumber \n 4. Reverse \n 5. CouponNumber \n 6. StopWatch ");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("1. Febinoccis");
                    Febinoccis Febinocci_series = new Febinoccis();
                    Febinoccis.printprime();
                    break;

                case 2:
                    Console.WriteLine("2.PerfectNumber ");
                    PerfectNumber PerfectNumber = new PerfectNumber();
                    PerfectNumber.printPerfect();
                    break;


                case 3:
                    Console.WriteLine("3.PrimeNumber");
                    PrimeNumber primeNumber = new PrimeNumber();
                    PrimeNumber.PrintPrime();
                    break;

                case 4:
                    Console.WriteLine("4.Reverse");
                    ReverseNumber ReverseNumber = new ReverseNumber();
                    ReverseNumber.printReverse();
                    break;

                case 5:
                    Console.WriteLine(" 5. CouponNumber");
                    CoupenNumbers coupenNumbers = new CoupenNumbers();
                    CoupenNumbers.printCoupen();
                    break;

                case 6:
                    Console.WriteLine(" 6. StopWatch ");
                    StopWatch stopWatch = new StopWatch();
                    StopWatch.printwatch();
                    


                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("Do you want to continue.... Yes/No");
            if (Console.ReadKey().KeyChar.ToString() == "Yes")
            {
                goto Label;

            }




            }
        }





    }








   
    
   
