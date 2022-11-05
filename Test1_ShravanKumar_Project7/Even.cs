using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project7
{
    class Even
    {
        public void SumOfEven(int number)
        {
            int sumEven = 0;

            for (int i = 0; i < number; i++)
            {
                if ((i % 2) == 0)
                    continue;
                
                sumEven = sumEven + i;
            }
            Console.WriteLine("Sum of Even : " + sumEven);
        }
    }
}