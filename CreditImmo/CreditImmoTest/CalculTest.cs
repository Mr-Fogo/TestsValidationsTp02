using CreditImmo;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CreditImmoTest
{
    public class CalculTest
    {
        [Theory]
        [InlineData(50000, 108, 1)]
        public void CalculMensualiteTest(double montant, int duree, double taux)
        {
            Calcul calcul = new Calcul();
            Assert.Equal(4167.4, CalculMensualite(montant, duree, taux));
        }
        public double CalculMensualite(double montant, int duree, double taux)
        {
            double mensualite;
            double numerateur = montant * (taux / 12);
            double denominateur = 1 - Math.Pow(1 + taux / 12, -duree);
            mensualite = numerateur / denominateur;
            mensualite = Math.Round(mensualite, 2);
            return mensualite;
        }
    }
}