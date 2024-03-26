using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class CSVMaker
    {
        public string MakeCSV(int duree, double mensualite, double total)
        {
            // Création du fichier CSV
             StringBuilder streamBuilder = new StringBuilder();
            double capitalRestant = total;
            double capitalRembourse = 0;
            streamBuilder.AppendLine("Nb;Mensualite;Capital Rembourse;capital Restant");
            for (int i = 0; i < duree; i++)
            {
                streamBuilder.AppendLine($"{i + 1};{mensualite};{capitalRembourse};{capitalRestant}");
                capitalRembourse += mensualite;
                capitalRestant -= mensualite;
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
