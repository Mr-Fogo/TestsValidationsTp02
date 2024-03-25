using CreditImmo;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CreditImmoTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calcul calcul = new Calcul();
            string result = calcul.returnHello("Hello World!");
            Assert.Equal("Hello World!", result);
            
        }
    }
}