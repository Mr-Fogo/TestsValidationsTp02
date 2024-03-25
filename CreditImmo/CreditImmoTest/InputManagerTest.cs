using CreditImmo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmoTest
{
    public class InputManagerTest
    {
        [Theory]
        [InlineData(200)]
        [InlineData(108)]
        [InlineData(300)]
        public void CheckDureeTestTrue(int duree)
        {
            InputManager inputManager = new InputManager();
            Assert.True(inputManager.CheckDuree(duree));
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(45)]
        [InlineData(451)]
        public void CheckDureeTestFlase(int duree)
        {
            InputManager inputManager = new InputManager();
            Assert.False(inputManager.CheckDuree(duree));
        }
        [Theory]
        [InlineData(10)]
        public void CheckMontantTestTrue(int montant)
        {
           // InputManager inputManager = new InputManager();
            Assert.True(CheckMontant(montant));
        }

        public bool CheckMontant(int montant)
        {
            if (montant > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
