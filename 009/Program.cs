/* 
Faça um Programa que peça a temperatura em graus Fahrenheit,
transforme e mostre a temperatura em graus Celsius.
*/

namespace _009 { 

class Program
{
    public static void Main(string[] args)
    {
            bool status = true;
            Conversion convert = new Conversion();

            while (status)
            {
                Console.Write("Digite o valor em fahrenheit: ");
                
                if (!double.TryParse(Console.ReadLine(), out double fahrenheitValue))
                {
                    Console.WriteLine("O valor é inválido. Tente novamente!");
                }

                double res = convert.FahrenheitToCelcius(fahrenheitValue);

                Console.WriteLine("O valor de " + fahrenheitValue + "F° é: " + res.ToString("0.00") + "C°.");

                Console.Write("Você deseja fazer mais contas? (S/N): ");
                string op = Console.ReadLine();

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