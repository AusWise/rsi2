using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1Contract
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double Power(double x, int n);

        [OperationContract]
        int Fibonacci(int n);

        [OperationContract]
        int Factorial(int n);
    }
}
