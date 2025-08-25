using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    public class Conversion
    {
        public double CelciusToFahrenheit(string input)
        {
            if (double.TryParse(input, out double celcius))
            {
                return (celcius * 9 / 5) + 32;

            } 
            else
            {
                throw new FormatException("O valor informado não é válido.");
            }
        }
    }
}
