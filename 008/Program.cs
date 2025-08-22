/* 
Faça um Programa que pergunte quanto você ganha por hora e o número de horas
trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.
*/

class Program
{
    public static void Main(string[] args)
    {
        bool status = true;

        while (status)
        {
            Console.Write("Digite o valor por hora: ");

            if (!double.TryParse(Console.ReadLine(), out double valuePerHour))
            {
                Console.WriteLine("Valor inválido. Tente novamente!");
            }

            Console.Write("Digite número de horas trabalhadas por mês: ");

            if (!Int32.TryParse(Console.ReadLine(), out int workedHours))
            {
                Console.WriteLine("Você não pode considerar horas quebradas");
            }

            double res = valuePerHour * workedHours;
            Console.WriteLine("O seu salário é: " + res + " reais.");

            Console.Write("Você deseja fazer mais cálculos? (S/N): ");
            string op = Console.ReadLine().ToLowerInvariant();

            switch (op)
            {
                case "s":
                    status = true;
                    break;

                case "n":
                    Console.WriteLine("\nPrograma finalizado");
                    status = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}