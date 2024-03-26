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
            double montant = double.Parse(args[0]);
            int duree = int.Parse(args[1]);
            int taux = int.Parse(args[2]);
            if (!inputManager.CheckMontant(montant) || !inputManager.CheckDuree(duree) || !inputManager.CheckTaux(taux))
            {
                return;
            }
            Calcul calcul = new Calcul();
            double mensualite = calcul.CalculMensualite(montant, duree, taux);
            double total = calcul.CalculTotal(mensualite, duree);
            CSVMaker csvMaker = new CSVMaker();
            string csv =csvMaker.MakeCSV(duree, mensualite, total);
            csvMaker.SaveCSV(csv);
        }
    }
}
