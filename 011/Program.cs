/*
Faça um Programa que peça 2 números inteiros e um número real.
Calcule e mostre:
    o produto do dobro do primeiro com metade do segundo.
    a soma do triplo do primeiro com o terceiro.
    o terceiro elevado ao cubo.
*/

namespace _011
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Verifier verifier = new Verifier();

            Console.Write("Digite o primeiro valor inteiro: ");
            int n1 = Verifier.VerifyIntegerInput();

            Console.Write("Digite o segundo valor inteiro: ");
            int n2 = verifier.VerifyInteger(Console.ReadLine());

            Console.Write("Digite o valor real: ");
            double n3 = verifier.VerifyDouble(Console.ReadLine());

            int res1 = calculator.FirstCalc(n1, n2);
            Console.WriteLine($"Resultado da primeira operação: {res1.ToString("0.00")}");

            double res2 = Math.Round(calculator.SecondCalc(n1, n3));
            Console.WriteLine($"Resultado da segunda operação: {res2.ToString("0.00")}");

            double res3 = Math.Round(calculator.thirdCalc(n3));
            Console.WriteLine($"Resultado da terceira operação: {res3.ToString("0.00")}");
        }
    }
}