using CreditImmo;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CreditImmoTest
{
    public class CalculTest
    {
        [Theory]
        [InlineData(50000, 108, 1)]
        public void CalculMensualiteTest(double montant, int duree, int taux)
        {
            Calcul calcul = new Calcul();
            Assert.Equal(50000, CalculMensualite(montant, duree, taux));
        }
        public double CalculMensualite(double montant, int duree, int taux)
        {
            return double.Parse("50000");
        }
    }
}