using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class Calcul
    {
        public double CalculMensualite(double montant, int duree, double taux)
        {
            double mensualite;
            double numerateur = montant * (taux / 100 / 12);
            double denominateur = 1 - (Math.Pow(1 + (taux / 100 / 12), -duree));
            mensualite = numerateur / denominateur;
            mensualite = Math.Round(mensualite, 2);
            return mensualite;
        }
        public double CalculTotalAvecMensualite(double mensualite, int duree)
        {
            double total = mensualite * duree;
            return total;
        }
        public double CalculTotalSansMensualite(double mensualite, int duree)
        {
            double total = mensualite * duree;
            return total;
        }
    }
}
