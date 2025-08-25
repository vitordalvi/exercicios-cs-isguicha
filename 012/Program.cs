/*
Tendo como dados de entrada a altura de uma pessoa,
construa um algoritmo que calcule seu peso ideal,
usando a seguinte fórmula: (72.7*altura) - 58
*/

using _012;

class Program
{
    public static void Main(string[] args)
    {
        bool status = true;
        Calculator calc = new Calculator();

        while (status)
        {
            Console.Write("Digite o valor da altura em centímetros: ");
            double weight = calc.CalcWeight();

            Console.WriteLine($"O peso ideal para sua altura é: {weight}Kg.");

            Console.Write("Você deseja fazer mais cálculos? (S/N): ");
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
                    Console.WriteLine("Valor inválido.");
                    break;
            }
        }
    }
}