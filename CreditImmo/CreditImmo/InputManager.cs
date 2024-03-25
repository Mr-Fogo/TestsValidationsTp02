using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class InputManager
    {
        public bool CheckDuree(int duree)
        {
            if (duree >= 108 && duree <= 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckMontant(double montant)
        {
            if (montant >= 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckTaux(int taux)
        {
            if (taux >= 0 && taux <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckArguments(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Nombre Argument incorrect : CredImmo <montant> <duree> <taux>");
                return false;
            }
            if (!double.TryParse(args[0], out double montant))
            {
                Console.WriteLine("Le montant doit être un nombre");
                return false;
            }
            if (!int.TryParse(args[1], out int duree))
            {
                Console.WriteLine("La durée doit être un nombre entier");
                return false;
            }
            if (!int.TryParse(args[2], out int taux))
            {
                Console.WriteLine("Le taux doit être un nombre entier");
                return false;
            }
            return true;
        }
    }

}
