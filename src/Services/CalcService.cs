namespace SimpleCalcApp
{
    public class CalcService : ICalcService
    {
        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return b * a;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}