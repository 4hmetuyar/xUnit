using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnit.Web.Test
{
    public class NumericAssertsShould
    {
        [Fact]
        public void NumberCompareMetod()
        {
            int value = 100;

            Assert.Equal(100, value);
        }
    }
}
