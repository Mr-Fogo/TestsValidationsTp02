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
    }
}
