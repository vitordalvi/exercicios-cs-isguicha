/* 
Faça um Programa que calcule a área de um quadrado,
em seguida mostre o dobro desta área para o usuário.
*/

class Program
{
    public static void Main(string[] args)
    {
        bool status = true;

        while (status)
        {
            Console.Write("Digite valor do lado do quadrado: ");

            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                Console.WriteLine("Valor inválido. Tente novamente!");
            }

            double res = (Math.Pow(value, 2) * 2);
            Console.WriteLine("O valor do dobro da área é: " + res);

            Console.Write("Você deseja fazer mais cálculos? (S/N): ");
            string op = Console.ReadLine();

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
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}