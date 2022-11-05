using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project7
{
    internal class Odd:Even
    {
        int sumOdd = 0;
        public void SumOfOdd(int number)
        {
            for (int j = 0; j < number; j++)
            {
                if ((j % 2) != 0)
                    continue;
                
                sumOdd=sumOdd+j;
            }
            Console.WriteLine("Sum of Odd : " + sumOdd);
        }
    }
}
