using System;

namespace CoinFlip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Label: Console.WriteLine("1.print the percentage coin Flip");
            Console.WriteLine("Type the options");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("1.Print the percentage coin Flip");
                    percentageOfHeadAndTail percentageOfHeadAndTail = new percentageOfHeadAndTail();
                        percentageOfHeadAndTail.printHeadAndTail();
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
    }
}




     