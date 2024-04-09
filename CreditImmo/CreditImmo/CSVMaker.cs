using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class CSVMaker
    {
        public void SaveCSV(string csv)
        {
            System.IO.File.WriteAllText("amortissement.csv", csv);
            Console.WriteLine("Fichier amortissement.csv créé");
        }

        public string MakeCSV(int duree, decimal montant, double taux)
        {
            Calcul calcul = new Calcul();
            StringBuilder streamBuilder = new StringBuilder();
            decimal mensualite = calcul.CalculMensualite(montant, duree, taux);
            decimal capitalRestant = montant;
            decimal totalAvecMensualite = calcul.CalculTotalAvecMensualite(mensualite, duree);
            decimal credit = totalAvecMensualite - montant;
            decimal capitalRembourseTotal = 0;
            decimal capitalRestantTotal = totalAvecMensualite;

            streamBuilder.AppendLine($"N;Mensualite;Capital Rembourse Total;Capital Restant;Capital a rembourse;Interet;Cout Credit :;{Math.Round(credit,2)}");
            for (int i = 0; i < duree; i++)
            {
                double interet = (double)capitalRestant * taux / 100 / 12;
                decimal interets = (decimal)interet;
                decimal capitalRembourse = mensualite - interets;
                capitalRestant = capitalRestant - capitalRembourse;
                capitalRembourseTotal += mensualite;
                capitalRestantTotal -= mensualite;
                streamBuilder.AppendLine($"{i + 1};{Math.Round(mensualite,2)};{Math.Round(capitalRembourseTotal,2)};{Math.Round(capitalRestantTotal)};{Math.Round(capitalRembourse)};{Math.Round(interets)}");
            }
            return streamBuilder.ToString();
        }
    }
}
