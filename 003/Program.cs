//Faça um Programa que peça dois números e imprima a soma.

class Program
{
    public static void Main(string[] args)
    {
        bool status = true;
        double[] n = new double[2];

        while (status)
        {
            for (int i = 0; i < 2; i++)
            {
                bool check = false;

                while (!check)
                {
                    Console.Write("Digite o " + (i + 1) + "° número: ");
                    check = double.TryParse(Console.ReadLine(), out n[i]);

                    if (!check)
                    {
                        Console.WriteLine("Valor inválido! Tente novamente.");
                    }
                }
            }

            Console.WriteLine("O resultado é: " + (n[0] + n[1]));

            Console.Write("Você deseja fazer mais contas cálculos? (S/N):" );
            string op = Console.ReadLine().ToLowerInvariant();

            if (op != "s" && op != "n") {
                Console.WriteLine("Resposta inválida, utilize: S ou N");
                continue;
            } 

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
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
