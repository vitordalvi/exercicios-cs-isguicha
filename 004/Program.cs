// Faça um Programa que peça as 4 notas bimestrais e mostre a média.

class Program
{
    public static void Main(string[] args)
    {
        bool status = true;
        double[] n = new double[4];

        bool check = false;

        while (status)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\nDigite o valor da sua " + (i + 1) + "° nota: ");

                check = (double.TryParse(Console.ReadLine(), out n[i]));

                if (!check)
                {
                    Console.WriteLine("\nValor inválido. Tente novamente!");
                }


            }

            double sum = 0;

            for (int j = 0; j < 4; j++)
            {
                sum += n[j];
            }

            double media = sum / n.Length;

            Console.WriteLine("\nA média das notas é: " + media);

            Console.Write("\nVocê deseja calcular outras médias? (S/N): ");
            string op = Console.ReadLine().ToLowerInvariant();

            switch (op)
            {
                case "s":
                    status = true;
                    break;

                case "n":
                    Console.WriteLine("\nPrograma finalizado.");
                    status = false;
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }
}