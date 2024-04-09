using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class Calcul
    {
        public decimal CalculMensualite(decimal montant, int duree, double taux)
        {
            decimal mensualite;
            double numerateur = (double)montant * (taux / 100 / 12);
            double denominateur = 1 - (Math.Pow(1 + (taux / 100 / 12), -duree));
            mensualite = (decimal)(numerateur / denominateur);
            return mensualite;
        }
        public decimal CalculTotalAvecMensualite(decimal mensualite, int duree)
        {
            double total = ((double)(mensualite * duree));
            return (decimal)total;
        }

    }
}
