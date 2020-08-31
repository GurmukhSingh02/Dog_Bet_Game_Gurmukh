using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Bet_Game_Gurmukh
{
    public class GurmukhGreyHoundClass
    {
        //generate the random numbers
        Random rd = new Random();
        public int moveMent()//moving steps
        {
            return rd.Next(1, 35);
        }
    }
}
