using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Day_at_the_Races
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        /// <summary>
        /// Updates the information about person places bet
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            if (Amount > 0)
            {
                return Bettor.Name + " bet " + Amount + " dollars on dog number " + Dog + ".";
            }
            else
            {
                return Bettor.Name + " hasn't placed a bet.";
            }
        }

        /// <summary>
        /// Pays out winnings/loses to bettor
        /// </summary>
        /// <param name="winner">number of winning dog.</param>
        /// <returns></returns>
        public int Payout(int winner)
        {
            if (winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }

            //return winner == Dog ? Amount : -Amount; ? = then, : = else (a way to clean up this code?)
        }
    }
}
