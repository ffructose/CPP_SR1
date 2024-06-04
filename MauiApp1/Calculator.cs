using System;
using System.Collections.Generic;
using System.Linq;

namespace MauiApp1
{
    internal class Calculator
    {
        public int A { get; set; }
        public int B { get; set; }
        public int[] Numbers { get; set; }

        public int ProductOfMultiplesOf6()
        {
            int product = 1;
            bool hasMultiple = false;
            for (int i = A; i <= B; i++)
            {
                if (i % 6 == 0)
                {
                    product *= i;
                    hasMultiple = true;
                }
            }
            return hasMultiple ? product : 0;
        }

        public int ProductInRange()
        {
            int prod = 1;
            int count = 0;
           
            for (int i = 0; i < 3; i++)
            {
                if (Numbers[i] > 10 && Numbers[i] < 15)
                {
                    prod = prod * Numbers[i];
                    count++;
                }
            }

            if(count >1) return prod ;
            else return 0;
        }
    }
}
