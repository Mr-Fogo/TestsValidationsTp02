using CreditImmo;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CreditImmoTest
{
    public class CalculTest
    {
        [Theory]
        [InlineData(50000, 108, 1, 484.3)]
        [InlineData(50000, 300, 1, 188.44)]
        [InlineData(100000,300, 10, 908.70)]
        [InlineData(100000.23,245,3.42,567.67)]
        public void CalculMensualiteTest(decimal montant, int duree, double taux, decimal result )
        {
            Calcul calcul = new Calcul();
            Assert.Equal(result, Math.Round(calcul.CalculMensualite(montant, duree, taux),2));
        }
    }
}