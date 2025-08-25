namespace _009
{
    public class Conversion
    {
        public double FahrenheitToCelcius(string input)
        {
            if (double.TryParse(input, out double fahrenheit))
            {
                return (fahrenheit - 32 * 5 / 9);
            }

            else
            {
                throw new FormatException("O valor inserido é inválido!");
            } 
        }
    }
}
