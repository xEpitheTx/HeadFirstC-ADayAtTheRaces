using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class Form1 : Form
    {
        const int MAX_GREYHOUND_ARRAY_SIZE = 4;
        const int MAX_GUY_ARRAY_SIZE = 3;
        Random MyRandomizer = new Random();
        Greyhound[] GreyhoundArray = new Greyhound[MAX_GREYHOUND_ARRAY_SIZE];
        Guy[] GuyArray = new Guy[MAX_GUY_ARRAY_SIZE];

        public Form1()
        {
            InitializeComponent();
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = 0,
                RacetrackPictureBox = racetrackPictureBox,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = MyRandomizer                
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                RacetrackPictureBox = racetrackPictureBox,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = MyRandomizer                
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                RacetrackPictureBox = racetrackPictureBox,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = MyRandomizer                
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                RacetrackPictureBox = racetrackPictureBox,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = MyRandomizer
            };

            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyLabel = joeBetlabel,
                MyRadioButton = joeRadioButton
            };

            GuyArray[0].MyBet = new Bet()
            {
                Bettor = GuyArray[0],
                Amount = 0,
                Dog = (int)dogNumber.Value
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton
            };
            GuyArray[1].MyBet = new Bet()
            {
                Bettor = GuyArray[1],
                Amount = 0,
                Dog = (int)dogNumber.Value
            };
            GuyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton
            };
            GuyArray[2].MyBet = new Bet()
            {
                Bettor = GuyArray[2],
                Amount = 0,
                Dog = (int)dogNumber.Value
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < MAX_GREYHOUND_ARRAY_SIZE; i++)
            {
                bettingParlorBox.Enabled = false;
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog # " + (i + 1) + " won the race!");
                    for (int j = 0; j < MAX_GUY_ARRAY_SIZE; j++)
                    {
                        GuyArray[j].Collect(i + 1);
                        GuyArray[j].UpdateLabels();
                        GuyArray[j].ClearBet();
                        for (int k = 0; k < MAX_GREYHOUND_ARRAY_SIZE; k++)
                        {
                            GreyhoundArray[k].TakeStartingPosition();
                        }
                    }
                    bettingParlorBox.Enabled = true;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int MinimumBet = 5;
            minimumBetLabel.Text = "Minimum bet: " + MinimumBet + " bucks";
            for (int i = 0; i < MAX_GUY_ARRAY_SIZE; i++)
            {
                nameLabel.Text = GuyArray[0].Name;
                GuyArray[i].ClearBet();
                GuyArray[i].UpdateLabels();
            }
        }

        private void joeRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[0].Name;
        }

        private void bobRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[1].Name;
        }

        private void alRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[2].Name;
        }

        private void betButton_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < MAX_GUY_ARRAY_SIZE; i++)
            {
                if (GuyArray[i].MyRadioButton.Checked == true && GuyArray[i].Cash >= betAmount.Value)
                {
                    GuyArray[i].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
                    GuyArray[i].UpdateLabels();
                }
                else if (GuyArray[i].MyRadioButton.Checked == true)
                {
                    MessageBox.Show(GuyArray[i].Name + " does not have enough cash.");
                }
            }
        }

        private void raceButton_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
