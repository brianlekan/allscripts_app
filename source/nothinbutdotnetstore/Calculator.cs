namespace nothinbutdotnetstore
{
    public interface ICalculate
    {
        int add(int first, int second);
    }

    public class Calculator : ICalculate
    {
        public int add(int first, int second)
        {
            return first + second;
        }
    }
}