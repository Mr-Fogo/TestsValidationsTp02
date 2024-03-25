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
            Assert.True(CheckDuree(duree));
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(45)]
        [InlineData(451)]
        public void CheckDureeTestFlase(int duree)
        {
            Assert.False(CheckDuree(duree));
        }

        public static bool CheckDuree(int duree)
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
    }
}
