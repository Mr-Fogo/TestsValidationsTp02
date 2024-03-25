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
        [InlineData(1)]
        [InlineData(108)]
        public void CheckDureeTestFalse(int duree)
        {
            Assert.False(CheckDuree(duree));
        }

        public static bool CheckDuree(int duree)
        {
           if (duree >= 108)
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
