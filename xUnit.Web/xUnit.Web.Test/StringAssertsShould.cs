using Xunit;

namespace xUnit.Web.Test
{
    public class StringAssertsShould
    {

        /// <summary>
        /// İki tane string ifadeyi karşılaştırmak için kullanılır.
        /// </summary>
        [Fact]
        public void CompareFullName()
        {
            var fullName = "Ahmet Uyar";
            Assert.Equal("Ahmet Uyar", fullName);
        }
    }
}
