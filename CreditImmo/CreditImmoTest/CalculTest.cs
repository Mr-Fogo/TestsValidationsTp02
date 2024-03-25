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

        public void CalculMensualiteTest(double montant, int duree, double taux, double result )
        {
            Calcul calcul = new Calcul();
            Assert.Equal(result, CalculMensualite(montant, duree, taux));
        }
        public double CalculMensualite(double montant, int duree, double taux)
        {
            double mensualite;
            double numerateur = montant * (taux/100 / 12);
            double denominateur = 1 - (Math.Pow(1 + (taux/100 / 12), -duree));
            mensualite = numerateur / denominateur;
            mensualite = Math.Round(mensualite, 2);
            return mensualite;
        }
    }
}