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
            decimal montant = decimal.Parse(args[0].Replace(".", ","));
            int duree = int.Parse(args[1]);
            double taux = double.Parse(args[2].Replace(".", ","));
            if (!inputManager.CheckMontant(montant) || !inputManager.CheckDuree(duree) || !inputManager.CheckTaux(taux))
            {
                return;
            }
            CSVMaker csvMaker = new CSVMaker();
            string csv =csvMaker.MakeCSV(duree, montant, taux);
            csvMaker.SaveCSV(csv);
        }
    }
}
