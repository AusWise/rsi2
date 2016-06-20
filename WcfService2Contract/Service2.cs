using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService2Contract
{
    public class Service2 : IService2
    {
        public int IndexOf(string text, string target, int fromIndex)
        {
            int result = text.IndexOf(target, fromIndex);

            Console.WriteLine("IndexOf(" + text + ", " + target + ", " + fromIndex + ") = " + result);

            return result;
        }

        public string Replace(string text, string target, string replacement)
        {
            string result = text.Replace(target, replacement);

            Console.WriteLine("Replace(" + text + ", " + target + ", " + replacement + ") = " + result);

            return result;
        }
    }
}
