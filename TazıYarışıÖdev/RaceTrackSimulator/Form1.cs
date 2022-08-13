using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceTrackSimulator {
    public partial class Form1 : Form {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public Form1() {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack() {
            MinimumBet.Text = string.Format("Minimum bet {0:c}", (int)BetAmount.Minimum);

            int startingPosition = dog1.Right - racetrack.Left;
            int raceTrackLength = racetrack.Size.Width;

            dogs[0] = new Greyhound() { MyPictureBox = dog1,
                                        RacetrackLength = raceTrackLength, 
                                        StartingPosition = startingPosition };
            dogs[1] = new Greyhound() { MyPictureBox = dog2,
                                        RacetrackLength = raceTrackLength,
                                        StartingPosition = startingPosition };
            dogs[2] = new Greyhound() { MyPictureBox = dog3,
                                        RacetrackLength = raceTrackLength,
                                        StartingPosition = startingPosition };
            dogs[3] = new Greyhound() { MyPictureBox = dog4,
                                        RacetrackLength = raceTrackLength,
                                        StartingPosition = startingPosition };

            guys[0] = new Guy("Mert", null, 100, MertButton, joeBet);
            guys[1] = new Guy("Bahadır", null, 100, BahadırButton, bobBet);
            guys[2] = new Guy("Batuhan", null, 100, BatuhanButton, alBet);

            foreach (Guy guy in guys) {
                guy.UpdateLabels();
            }
        }

        private void joeButton_CheckedChanged(object sender, EventArgs e) {
            SetBettorNameTextLabel("Mert");
        }

        private void bobButton_CheckedChanged(object sender, EventArgs e) {
            SetBettorNameTextLabel("Bahadır");
        }

        private void alButton_CheckedChanged(object sender, EventArgs e) {
            SetBettorNameTextLabel("Batuhan");
        }

        private void SetBettorNameTextLabel(string Name) {
            BettorName.Text = Name;
        }

        private void Bets_Click(object sender, EventArgs e) {
            int GuyNumber = 0;

            if (MertButton.Checked) {
                GuyNumber = 0;
            }
            if (BahadırButton.Checked) {
                GuyNumber = 1;
            }
            if (BatuhanButton.Checked) {
                GuyNumber = 2;
            }

            guys[GuyNumber].PlaceBet((int)BetAmount.Value, (int)DogNumber.Value);
            guys[GuyNumber].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e) {
            bool NoWinner = true;
            int winningDog;
            race.Enabled = false;

            while (NoWinner) {
                Application.DoEvents();
                for (int i = 0; i < dogs.Length; i++ ) {
                    if (dogs[i].Run()) {
                        winningDog = i + 1;
                        NoWinner = false;
                        winnerDog.Text = "Yarışı Kazanan Tazımız #" + winningDog + " Numaralı Tazımızdır...";
                        foreach (Guy guy in guys) {
                            if (guy.MyBet != null) {
                                guy.Collect(winningDog);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }
                        foreach (Greyhound dog in dogs) {
                            dog.TakeStartingPosition();
                        }
                        break;
                    }                    
                }                
            }

            race.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
