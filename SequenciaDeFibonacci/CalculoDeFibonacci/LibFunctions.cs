namespace CalculoDeFibonacci
{
    using System;

    public class FrameWorkLib
    {
        public static double Fibonacci(Double n)
        {
            Double a = 0;
            Double b = 1;
            // Para n etapas, será calculado um numero baseado 
            for (Double i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}