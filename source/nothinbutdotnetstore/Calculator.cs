using System;

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
            if (first <=0 || second <=0 )
            {
                throw new ArgumentException();
            }
            return first + second;
        }
    }
}