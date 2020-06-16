using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public class Greyhound
    {
        public int StartingPosition; //start of picture box
        public int RacetrackLength; //how long the form race track is
        public PictureBox MyPictureBox = null; //greyhouds picturebox
        public int Location; //my location on the track
        public Random Randomizer; //instance of random, each object should point to same randomizer objecter
        public PictureBox RacetrackPictureBox;

        /// <summary>
        /// Update the location of the dog with a random number 1-4
        /// </summary>
        /// <returns>true if dog wins</returns>
        public bool Run()
        {
            Location += Randomizer.Next(1, 5);
            MyPictureBox.Left = Location + RacetrackPictureBox.Location.X;
            return Location >= RacetrackLength;
        }

        /// <summary>
        /// Resets dog location
        /// </summary>
        public void TakeStartingPosition()
        {
            Location = StartingPosition;
            MyPictureBox.Left = StartingPosition + RacetrackPictureBox.Location.X;
        }
    }
}
