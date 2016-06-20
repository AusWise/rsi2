using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService2Contract
{
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        int IndexOf(string text, string target,int fromIndex);

        [OperationContract]
        string Replace(string text, string target, string replacement);
    }
}
