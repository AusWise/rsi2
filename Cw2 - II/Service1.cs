using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1Contract
{
    public class Service1 : IService1
    {
        public double Power(double x, int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
                result *= x;

            Console.WriteLine("Power(" + x + ", " + n + ") = " + result);

            return result;
        }

        private int FibonacciRecursive(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public int Fibonacci(int n)
        {
            int result = FibonacciRecursive(n);

            Console.WriteLine("Fibonacci(" + n + ") = " + result);

            return result;
        }

        public int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;

            Console.WriteLine("Factorial(" + n + ") = " + result);

            return result;
        }
    }
}
