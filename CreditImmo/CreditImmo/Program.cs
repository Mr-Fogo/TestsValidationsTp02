namespace CreditImmo
{
    class Program
    {
        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();
            if (!inputManager.CheckArguments(args))
            {
                return;
            }
            double montant = double.Parse(args[0].Replace(".", ","));
            int duree = int.Parse(args[1]);
            double taux = double.Parse(args[2].Replace(".", ","));
            if (!inputManager.CheckMontant(montant) || !inputManager.CheckDuree(duree) || !inputManager.CheckTaux(taux))
            {
                return;
            }
            Calcul calcul = new Calcul();
            double mensualite = calcul.CalculMensualite(montant, duree, taux);
            double total = calcul.CalculTotalAvecMensualite(mensualite, duree);
            CSVMaker csvMaker = new CSVMaker();
            string csv =csvMaker.MakeCSV(duree, mensualite, total,montant);
            csvMaker.SaveCSV(csv);
        }
    }
}
