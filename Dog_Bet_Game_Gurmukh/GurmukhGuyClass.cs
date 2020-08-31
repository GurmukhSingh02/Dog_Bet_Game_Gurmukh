using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Bet_Game_Gurmukh
{
    public class GurmukhGuyClass: GurmukhGreyHoundClass
    {
        public int budgetSet(String data, int Budget, int winnerDog)
        {

            String[] filter = data.Split(' ');

            if (winnerDog==Convert.ToInt32(filter[2]))
            {
                return Budget + Convert.ToInt32(filter[5]);
            }
            else
            {
                return Budget - Convert.ToInt32(filter[5]);
            }
        }
    }
}
