using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        /// <summary>
        /// Updates guys labels to reflect name and cash.
        /// </summary>
        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks.";
        }

        /// <summary>
        /// Clears bet to 0.
        /// </summary>
        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        /// <summary>
        /// Places the amount of money the guy bets on which dog.
        /// </summary>
        /// <param name="betAmount"></param>
        /// <param name="dogToWin"></param>
        /// <returns></returns>
        public bool PlaceBet(int betAmount, int dogToWin)
        {
            MyBet.Amount = betAmount;
            MyBet.Dog = dogToWin;
            return Cash >= betAmount;
        }

        /// <summary>
        /// Collects the winnings or loses from dog bet
        /// </summary>
        /// <param name="winner">number of winning dog</param>
        public void Collect(int winner)
        {
            Cash += MyBet.Payout(winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
