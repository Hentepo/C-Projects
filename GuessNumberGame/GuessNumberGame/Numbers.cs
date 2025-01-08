using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public class Numbers
    {

        internal static int GenerateNumber()
        {
            Random rnd = new Random();

            int rndnum = rnd.Next(1, 10);
            return rndnum;
        }



}
}
