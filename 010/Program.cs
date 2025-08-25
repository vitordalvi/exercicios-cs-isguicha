/*
Faça um Programa que peça a temperatura em graus Celsius,
transforme e mostre em graus Fahrenheit.
*/

namespace _010
{
    class Program
    {
        public static void Main(string[] args)
        {
            Conversion convert = new Conversion();
            bool status = true;

            while (status)
            {
                Console.Write("Digite a quantidade em celcius: ");

                string celcius = Console.ReadLine();

                double res = convert.CelciusToFahrenheit(celcius);

                Console.WriteLine("O valor de " + celcius + "C° é: " + res + "F°.");

                Console.Write("Você deseja fazer mais conversões? (S/N): ");
                string op = Console.ReadLine().ToLowerInvariant();

                switch (op)
                {
                    case "s":
                        status = true;
                        break;

                    case "n":
                        Console.WriteLine("\nPrograma finalizado!");
                        status = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}