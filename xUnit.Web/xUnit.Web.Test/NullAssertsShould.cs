using Xunit;

namespace xUnit.Web.Test
{
    public class NullAssertsShould
    {
        [Fact]
        public void NotHaveNickNameByDefault()
        {
            string user = null;
            Assert.Null(user);
        }
    }
}
