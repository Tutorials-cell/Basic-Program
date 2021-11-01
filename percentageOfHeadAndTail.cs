using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlip
{
    public class percentageOfHeadAndTail
    {

        public void printHeadAndTail()
        {
            int head = 0;
            int tail = 0;
            int coinresult = 0;

            Random random = new Random();

            Console.WriteLine("Enter the input of coin Flip");

            int readInputromuserNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < readInputromuserNum; i++)
            {
                coinresult = random.Next(0, 2);
                if (coinresult == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }




        }

    }
}

