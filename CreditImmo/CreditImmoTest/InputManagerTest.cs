﻿using CreditImmo;
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
        [InlineData(50000)]
        [InlineData(50000.78)]
        [InlineData(70000)]
        [InlineData(70000.89)]
        public void CheckMontantTestTrue(decimal montant)
        {
            InputManager inputManager = new InputManager();
            Assert.True(inputManager.CheckMontant(montant));
        }
        [Theory]
        [InlineData(40000.78)]
        [InlineData(-70000)]
        [InlineData(-70000.54)]
        public void CheckMontantTestFalse(decimal montant)
        {
            InputManager inputManager = new InputManager();
            Assert.False(inputManager.CheckMontant(montant));
        }
        [Theory]
        [InlineData(50)]
        [InlineData(0)]
        [InlineData(100)]
        public void CheckTauxTestTrue(double taux)
        {
            InputManager inputManager = new InputManager();
            Assert.True(inputManager.CheckTaux(taux));
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void CheckTauxTestFalse(double taux)
        {
            InputManager inputManager = new InputManager();
            Assert.False(inputManager.CheckTaux(taux));
        }

    }
}
