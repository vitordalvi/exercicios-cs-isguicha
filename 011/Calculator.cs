namespace _011
{
    public class Calculator
    {
        
        public int FirstCalc(int firstInput, int secondInput)
        {
            return (firstInput * 2) * (secondInput / 2);
        }

        public double SecondCalc(int firstInput, double thirdInput)
        {
            return (firstInput * 3) + thirdInput;
        }

        public double thirdCalc(double n3)
        {
            return Math.Pow(n3, 3);
        }
    }    
}
