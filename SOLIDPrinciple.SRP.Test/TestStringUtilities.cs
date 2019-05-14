using System;
using Xunit;

namespace SOLIDPrinciple.SRP.Test
{
    public class TestStringUtilities
    {
        [Fact]
        public void TestStringWithoutVowel()
        {
            string inputString = "I Love My India and Maharashtra";
            string expectedString = " Lv My nd nd Mhrshtr";
            Assert.Equal(inputString.RemoveVowels(), expectedString);
        }
        [Fact]
        public void TestConcat()
        {
            string targetString = "Test is";
            string sourceString = "Test";
            string expectedString = "Test is Test";
            Assert.Equal(targetString.ConcatString(sourceString), expectedString);
        }
    }
}
