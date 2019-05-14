using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple.SRP
{
    public class StringUtils : IUtility
    {
        public string Add(string input1, string input2) => input1.ConcatString(input2);
        
    }
}
