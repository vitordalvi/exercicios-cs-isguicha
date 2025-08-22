/*
Faça um Programa que peça um número e então mostre a mensagem
O número informado foi [número].

*/

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Insira um número: ");
        string input = Console.ReadLine();

        if (!double.TryParse(input, out double n))
        {
            Console.WriteLine("O tipo de dado está incorreto.");
        } else
        {
            Console.WriteLine("O número informado foi: " + n);
        }
    }
}