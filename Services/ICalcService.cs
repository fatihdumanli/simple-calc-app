namespace SimpleCalcApp
{
    public interface ICalcService
    {
        int Sum(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
    }
}