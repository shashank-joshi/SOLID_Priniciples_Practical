using System;
using Xunit;


namespace SOLIDPrinciple.SRP.Test
{
    public class IntegerTest
    {
        [Fact]
        public void TestAddition()
        {
            IUtility utilityInt = new IntUtils();
            Assert.Equal("23", utilityInt.Add("2", "21"));
        }

    }
}
