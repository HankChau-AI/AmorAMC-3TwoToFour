using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmorAMC_3TwoToFour.Services
{
    public class GreaterLessThan
    {
         public string compare(int num1, int num2)
        {
            string firstStatement;
            string secondStatement;

            if (num1 > num2)
            {
                firstStatement = $"{num1} is greater than {num2}.";
                secondStatement = $"{num2} is less than {num1}.";
            }
            else if (num1 < num2)
            {
                firstStatement = $"{num1} is less than {num2}.";
                secondStatement = $"{num2} is greater than {num1}.";
            }
            else
            {
                firstStatement = $"{num1} is equal to {num2}.";
                secondStatement = $"{num2} is equal to {num1}.";
            }

            return $"{firstStatement} {secondStatement}";
        }
    }
}