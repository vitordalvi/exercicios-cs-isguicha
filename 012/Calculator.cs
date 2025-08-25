using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012
{
    public class Calculator
    {
        public double CalcWeight()
        {
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                throw new FormatException("O valor inserido é inválido. Tente novamente!");
            }

            return (72.7 * weight) - 58;

            } 
    }
}
