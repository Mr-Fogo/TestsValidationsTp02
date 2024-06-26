﻿using System;
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
                Console.WriteLine("Durée Erreur");
                return false;
            }
        }
        public bool CheckMontant(decimal montant)
        {
            if (montant >= 50000)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Montant Erreur");
                return false;
            }
        }
        public bool CheckTaux(double taux)
        {
            if (taux >= 0 && taux <= 100)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Taux Erreur");
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
            if (!double.TryParse(args[0].Replace(".", ","), out double montant))
            {
                Console.WriteLine("Le montant doit être un nombre");
                return false;
            }
            if (!int.TryParse(args[1], out int duree))
            {
                Console.WriteLine("La durée doit être un nombre entier");
                return false;
            }
            if (!double.TryParse(args[2].Replace(".",","), out double taux))
            {
                Console.WriteLine("Le taux doit être un nombre entier");
                return false;
            }
            return true;
        }
    }

}
