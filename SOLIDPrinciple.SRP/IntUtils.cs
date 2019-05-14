using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SRP
{
    public class IntUtils : IUtility
    {
        public string Add(string input1, string input2) => (int.Parse(input1) + int.Parse(input2)).ToString();
    }
}
