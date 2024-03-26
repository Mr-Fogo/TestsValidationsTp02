using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class CSVMaker
    {
        public string MakeCSV(int duree, double mensualite, double totalAvecMensualite, double total)
        {
            // Création du fichier CSV
             StringBuilder streamBuilder = new StringBuilder();
            double capitalRestant = totalAvecMensualite - mensualite;
            double capitalRembourse = mensualite;
            double credit = totalAvecMensualite-total;
            streamBuilder.AppendLine($"N;Mensualite;Capital Rembourse;Capital Restant;Cout Credit :;{credit}");
            for (int i = 0; i < duree; i++)
            {
                streamBuilder.AppendLine($"{i + 1};{Math.Round(mensualite,2)};{Math.Round(capitalRembourse,2)};{Math.Round(capitalRestant,2)}");
                capitalRembourse = capitalRembourse + mensualite;
                capitalRestant = capitalRestant - mensualite;
            }
            return streamBuilder.ToString();
        }
        public void SaveCSV(string csv)
        {
            System.IO.File.WriteAllText("amortissement.csv", csv);
            Console.WriteLine("Fichier amortissement.csv créé");
        }

    }
}
