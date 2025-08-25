// Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

class Program
{
    public static void Main(string[] args)
    {
        bool status = true;
        double PI = Math.PI;

        while (status)
        {
            Console.Write("Digite o raio do círculo: ");

            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine("Valor inválido. Tente novamente!");
            }

            double area = PI * Math.Pow(radius, 2);

            Console.WriteLine("O valor da área é: " + area.ToString("0.00"));

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