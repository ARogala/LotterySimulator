﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lot
{
    public partial class Form1 : Form
    {
        C2DrumMachine dm = new C2DrumMachine(C2DrumMachine.gameTypes.powerball);
        int bucks = 0;
        int scoreValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            dm.clearGameList();
            if (!cbCoverDrum2.Checked)
            {
                bucks -= dm.getGameCost();
                rtbGames.AppendText(dm.play() + "\n");
                bucks += dm.score(fldTarget.Text, dm.scGames[0]);
                //display win
                scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                if (scoreValue > 0)
                {
                    rtbWon.AppendText(dm.scGames[0] + " won " + scoreValue.ToString());
                }
            }
            else
            {
                dm.playDrum2();
                for (int i = 0; i < dm.scGames.Count; i++)
                {
                    bucks -= dm.getGameCost();
                    rtbGames.AppendText(dm.scGames[i] + "\n");
                    bucks += dm.score(fldTarget.Text, dm.scGames[i]);
                    //display win
                    scoreValue = dm.score(fldTarget.Text, dm.scGames[i]);
                    if(scoreValue > 0)
                    {
                        rtbWon.AppendText(dm.scGames[i] + " won " + scoreValue.ToString() + "\n");
                    }
                }
            }
            fldBucks.Text = bucks.ToString();
        }

        private void btnClrGames_Click(object sender, EventArgs e)
        {
            rtbGames.Text = "";
        }

        private void rgGameRbMega_CheckedChanged(object sender, EventArgs e)
        {
            dm.setGame(C2DrumMachine.gameTypes.megamillions);
            fldTarget.Text = "19 30 33 48 59 [25]";
        }

        private void rgGameRbPowerBall_CheckedChanged(object sender, EventArgs e)
        {
            dm.setGame(C2DrumMachine.gameTypes.powerball);
            fldTarget.Text = "19 30 33 48 59 [26]";
        }

        private void btnClrBucks_Click(object sender, EventArgs e)
        {
            bucks = 0;
            fldBucks.Text = bucks.ToString();
        }

        private void btnTryForBig_Click(object sender, EventArgs e)
        {
            int startBucks = 0;
            bool wow = false;

            while (!wow)
            {
                dm.clearGameList();
                if (!cbCoverDrum2.Checked)
                {
                    bucks -= dm.getGameCost();
                    startBucks = bucks;
                    dm.play();
                    bucks += dm.score(fldTarget.Text, dm.scGames[0]);
                    //display win
                    scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                    if (scoreValue > 0)
                    {
                        rtbWon.AppendText(dm.scGames[0] + " won " + scoreValue.ToString() + "\n");
                    }
                    if ((bucks - startBucks) > 999)
                    {
                        //Console.WriteLine("WOW");
                        rtbWon.AppendText("WOW");
                        wow = true;
                    }
                }
                else
                {
                    dm.playDrum2();
                    for (int i = 0; i < dm.scGames.Count; i++)
                    {
                        bucks -= dm.getGameCost();
                        startBucks = bucks;
                        bucks += dm.score(fldTarget.Text, dm.scGames[i]);
                        //display win
                        scoreValue = dm.score(fldTarget.Text, dm.scGames[i]);
                        if (scoreValue > 0)
                        {
                            rtbWon.AppendText(dm.scGames[i] + " won " + scoreValue.ToString() + "\n");
                        }
                        if ((bucks - startBucks) > 999)
                        {
                            //Console.WriteLine("WOW");
                            rtbWon.AppendText("WOW");
                            wow = true;
                        }
                    }
                }
                fldBucks.Text = bucks.ToString();
                fldBucks.Refresh();
            }
        }

    }
}
