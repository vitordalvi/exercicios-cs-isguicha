namespace _011
{
    public class Verifier
    {
        public int VerifyInteger(string input)
        {
            if (!int.TryParse(input, out int value))
            {
                throw new FormatException("Valor inválido!");
            }

            return value;
        }

        public double VerifyDouble(string input)
        {
            if (!double.TryParse(input, out double value))
            {
                throw new FormatException("Valor inválido!");
            }

            return value;
        }

        public static int VerifyIntegerInput()
        {

            int value;
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out value))
                    break;
                Console.WriteLine("Valor inválido. Tente novamente!");
            }

            return value;
        }

        public static double VerifyDoubleInput()
        {
            double value;

            while (true)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out value))
                    break;

                Console.WriteLine("Valor inválido. Tente novamente!");
            }

            return value;
        }
    }
}
