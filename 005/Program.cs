class Program
{
    public static void Main(string[] args)
    {

        bool status = true;

        while (status)
        {
            Console.Write("Digite o valor em centimetros: ");

            if (!double.TryParse(Console.ReadLine(), out double cm))
            {
                Console.WriteLine("Valor inválido. Tente novamente!");
                continue;
            }

            double conversion = cm / 100;

            Console.WriteLine("O resultado de " + cm + "cm é: " + conversion + "m.");

            Console.Write("Você deseja fazer mais conversões? (S/N): ");
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
            }
        }
    }
}