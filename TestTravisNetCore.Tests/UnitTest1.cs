using System;
using Xunit;
using TestTravis;

namespace TestTravisNetCore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(new CompareIntegerHelper().IsZero(1));
        }
    }
}
