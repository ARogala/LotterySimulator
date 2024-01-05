using System;
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
        int scoreValue = 0;
        int prizeGoal = 100;
        int moneySpent = 0;
        int moneyWon = 0;
        int gamesWon = 0;
        bool twoDrum = true;
        
        StringBuilder sbgamesPlayed = new StringBuilder();
        

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        //dont get your hopes up button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            dm.clearGameList();
            if (!cbCoverDrum2.Checked)
            {
                moneySpent -= dm.getGameCost();
                rtbGames.AppendText(dm.play(twoDrum) + "\n");
                scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                moneyWon += scoreValue;
                fldMoneySpent.Text = $"{moneySpent:n0}";
                fldMoneyWon.Text = $"{moneyWon:n0}";
                fldNetGainLoss.Text = $"{(moneySpent + moneyWon):n0}";
                fldGamesPlayed.Text = $"{Math.Abs((moneySpent / dm.getGameCost())):n0}";
                //display win
                if (scoreValue > 0)
                {
                    gamesWon++;
                    rtbWon.AppendText(dm.scGames[0] + " won " + scoreValue.ToString() + "\n");
                    fldGamesWon.Text = $"{gamesWon:n0}";
                }
            }
            else
            {
                dm.playDrum2();
                for (int i = 0; i < dm.scGames.Count; i++)
                {
                    moneySpent -= dm.getGameCost();
                    rtbGames.AppendText(dm.scGames[i] + "\n");
                    scoreValue = dm.score(fldTarget.Text, dm.scGames[i]);
                    moneyWon += scoreValue;
                    fldMoneySpent.Text = $"{moneySpent:n0}";
                    fldMoneyWon.Text = $"{moneyWon:n0}";
                    fldNetGainLoss.Text = $"{(moneySpent + moneyWon):n0}";
                    //display win
                    if (scoreValue > 0)
                    {
                        gamesWon++;
                        rtbWon.AppendText(dm.scGames[i] + " won " + scoreValue.ToString() + "\n");
                        fldGamesWon.Text = $"{gamesWon:n0}";
                    }
                }
                fldGamesPlayed.Text = $"{Math.Abs((moneySpent / dm.getGameCost())):n0}";
            }
        }

        private void btnClrGames_Click(object sender, EventArgs e)
        {
            rtbGames.Text = "";
            rtbWon.Text = "";
            cancelLbl.Text = "";
            sbgamesPlayed.Clear();
            gamesWon = 0;
            fldGamesPlayed.Text = "0";
            fldGamesWon.Text = gamesWon.ToString();
            yearsToWinLbl.Text = "";
        }

        private void rgGameRbMega_CheckedChanged(object sender, EventArgs e)
        {
            //make sure we update the prizeGoal when games change
            setPrize();
            dm.setGame(C2DrumMachine.gameTypes.megamillions);
            fldTarget.Text = "19 30 33 48 59 [25]";
            twoDrum = true;
            cbCoverDrum2.Enabled = true;
        }

        private void rgGameRbPowerBall_CheckedChanged(object sender, EventArgs e)
        {
            setPrize();
            dm.setGame(C2DrumMachine.gameTypes.powerball);
            fldTarget.Text = "19 30 33 48 59 [26]";
            twoDrum = true;
            cbCoverDrum2.Enabled = true;
        }

        private void rgGameRbCash4Life_CheckedChanged(object sender, EventArgs e)
        {
            setPrize();
            dm.setGame(C2DrumMachine.gameTypes.cash4Life);
            fldTarget.Text = "19 30 33 48 59 [04]";
            twoDrum = true;
            cbCoverDrum2.Enabled = true;
        }

        private void rgGameRbPick6_CheckedChanged(object sender, EventArgs e)
        {
            setPrize();
            dm.setGame(C2DrumMachine.gameTypes.pick6);
            fldTarget.Text = "09 24 29 30 37 46";
            twoDrum = false;
            cbCoverDrum2.Checked = false;
            cbCoverDrum2.Enabled = false;
        }

        private void rgGameRbCash5_CheckedChanged(object sender, EventArgs e)
        {
            setPrize();
            dm.setGame(C2DrumMachine.gameTypes.cash5);
            fldTarget.Text = "05 10 25 31 45";
            twoDrum = false;
            cbCoverDrum2.Checked = false;
            cbCoverDrum2.Enabled = false;
        }

        private void btnClrBucks_Click(object sender, EventArgs e)
        {
            moneySpent = 0;
            moneyWon = 0;
            fldMoneySpent.Text = moneySpent.ToString();
            fldMoneyWon.Text = moneyWon.ToString();
            fldNetGainLoss.Text = "0";
        }

        //start async operation
        private void btnTryForBig_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation. -- calls DoWork()
                backgroundWorker1.RunWorkerAsync();
            }
        }

        //cancel async operation
        private void cancelTryBig_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
       
            bool wow = false;

            while (!wow)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    dm.clearGameList();
                    if (!cbCoverDrum2.Checked)
                    {
                        moneySpent -= dm.getGameCost();
                        sbgamesPlayed.Append(dm.play(twoDrum) + "\n");
                        //every hundred games or 200$ for $1 games update games played UI -- clear it so Memory dont go out of control
                        if (Math.Abs(moneySpent)%200 == 0)
                        {
                            worker.ReportProgress(2);
                        }
                        scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                        moneyWon += scoreValue;
                        if (scoreValue > 0 && scoreValue < prizeGoal)
                        {
                            //mark as 1% complete here dont want to stop till big$$$
                            gamesWon++;
                            worker.ReportProgress(1, new Tuple<string, int>(dm.scGames[0], scoreValue));
                          
                        }
                        else if (scoreValue > (prizeGoal-1))
                        {
                            gamesWon++;
                            worker.ReportProgress(100, new Tuple<string, int>(dm.scGames[0], scoreValue));
                            wow = true;
                        }
                    }
                    else
                    {
                        dm.playDrum2();
                        for (int i = 0; i < dm.scGames.Count; i++)
                        {
                            //Console.WriteLine(i);
                            moneySpent -= dm.getGameCost();
                            sbgamesPlayed.Append(dm.scGames[i] + "\n");
                            //every hundred games or 200$ for $1 games update games played UI -- clear it so Memory dont go out of control
                            if (Math.Abs(moneySpent) % 200 == 0)
                            {
                                worker.ReportProgress(2);
                            }
                            //display win
                            scoreValue = dm.score(fldTarget.Text, dm.scGames[i]);
                            moneyWon += scoreValue;
                            //hardest part of the whole thing was to make sure we run through the rest of the drum --- wow may be true at i = 0 
                            //testing only seems to show Case2 or Case1 and Case4 -- 3 and 5 seem valid to me just not common at all 
                            if (scoreValue > 0 && scoreValue < prizeGoal && wow == false)
                            {
                                //mark as 1% complete here dont want to stop till big$$$
                                gamesWon++;
                                worker.ReportProgress(1, new Tuple<string, int>(dm.scGames[i], scoreValue));

                            }
                            else if (scoreValue > (prizeGoal-1) && i < (dm.scGames.Count-1) && wow == false)
                            {
                                gamesWon++;
                                worker.ReportProgress(50, new Tuple<string, int>(dm.scGames[i], scoreValue));
                                //Console.WriteLine("Case1");
                                //Console.WriteLine("i " + i);
                                wow = true;
                            }
                            else if (scoreValue > (prizeGoal-1) && i == (dm.scGames.Count-1) && wow == false)
                            {
                                gamesWon++;
                                worker.ReportProgress(100, new Tuple<string, int>(dm.scGames[i], scoreValue));
                                //Console.WriteLine("Case2");
                                //Console.WriteLine("i " + i);
                                wow = true;
                            }
                            else if (wow == true && i < (dm.scGames.Count-1) && scoreValue > 0)
                            {
                                gamesWon++;
                                worker.ReportProgress(50, new Tuple<string, int>(dm.scGames[i], scoreValue));
                                //Console.WriteLine("Case3");
                                //Console.WriteLine("i " + i);
                            }
                            else if (wow == true && i == (dm.scGames.Count - 1) && scoreValue > 0)
                            {
                                gamesWon++;
                                worker.ReportProgress(100, new Tuple<string, int>(dm.scGames[i], scoreValue));
                                //Console.WriteLine("Case4");
                                //Console.WriteLine("i " + i);
                            }
                            else if (wow == true && i == (dm.scGames.Count - 1) && scoreValue == 0)
                            {
                                //except shouldnt report a winning ticket here
                                string noWinAt100 = "noWinAt100";
                                worker.ReportProgress(100, new Tuple<string, int>(noWinAt100, scoreValue));
                                //Console.WriteLine("Case5");
                                //Console.WriteLine("i " + i);
                            }
                        }
                    }
                }
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            Tuple<string, int> UserState = (Tuple<string, int>)e.UserState;
            if (e.ProgressPercentage == 1 || e.ProgressPercentage == 50)
            {
                //why does this happen? it happens randomly then stops. related to the 2nd thread maybe
                //only work around i can think of is to pass scoreValue in UserState as a Tuple
                if (scoreValue == 0) 
                {
                    Console.WriteLine(e.UserState +  " twoDrum " + twoDrum);
                }
                rtbWon.AppendText(UserState.Item1 + " won " + UserState.Item2.ToString() + "\n");
                fldMoneySpent.Text = $"{moneySpent:n0}";
                fldMoneyWon.Text = $"{moneyWon:n0}";
                fldGamesWon.Text = $"{gamesWon:n0}";
            }
            else if(e.ProgressPercentage == 100)
            {
                rtbGames.AppendText(sbgamesPlayed.ToString());
                sbgamesPlayed.Clear();
                if (UserState.Item1 != "noWinAt100")
                {
                    rtbWon.AppendText(UserState.Item1 + " won " + UserState.Item2.ToString() + "\n");
                    rtbWon.AppendText("WOW");
                }
                fldMoneySpent.Text = $"{moneySpent:n0}";
                fldMoneyWon.Text = $"{moneyWon:n0}";
                fldNetGainLoss.Text = $"{(moneySpent + moneyWon):n0}";
                fldGamesPlayed.Text = $"{Math.Abs((moneySpent / dm.getGameCost())):n0}";
                fldGamesWon.Text = $"{gamesWon:n0}";
                yearsToWinLbl.Text = $"Playing 5 games a week it will take you\n{Math.Abs(moneySpent / dm.getGameCost())/(5.0*52.0):n2} years to win!";
            }
            //update games played UI clear the string or memory goes out of control
            else if (e.ProgressPercentage == 2)
            {
                rtbGames.AppendText(sbgamesPlayed.ToString());
                sbgamesPlayed.Clear();
            }

        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                cancelLbl.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                cancelLbl.Text = "Error: " + e.Error.Message;
            }
            else
            {
                cancelLbl.Text = "Done!";
            }
        }

        private void btnGetNewTicket_Click(object sender, EventArgs e)
        {
            fldTarget.Text = dm.GenerateNewTicket(twoDrum);
        }

        private void linkLblToLotterySite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLblToLotterySite.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.njlottery.com/en-us/home.html");
        }

        //go for JACKPOT$$$
        private void rgTryForJackPotRbYes_CheckedChanged(object sender, EventArgs e)
        {
            setPrize();
        }
        //go for 2nd Place$$
        private void rgTryForJackPotRbNo_CheckedChanged(object sender, EventArgs e)
        {
            setPrize();
        }

        private void setPrize()
        {
            if (rgTryForJackPotRbNo.Checked == true)
            {
                //set prize goal depending on game checked
                if (rgGameRbMega.Checked == true || rgGameRbPowerBall.Checked == true || rgGameRbCash4Life.Checked == true)
                {
                    //1,000,000
                    prizeGoal = 1000000;
                }
                else if (rgGameRbPick6.Checked == true)
                {
                    prizeGoal = 1000;
                }
                else if (rgGameRbCash5.Checked == true)
                {
                    prizeGoal = 500;
                }
            }
            else if (rgTryForJackPotRbYes.Checked == true)
            {
                //set prize goal depending on game checked
                if (rgGameRbMega.Checked == true || rgGameRbPowerBall.Checked == true)
                {
                    //100,000,000
                    prizeGoal = 100000000;
                }
                else if (rgGameRbCash4Life.Checked == true)
                {
                    //5,000,000
                    prizeGoal = 5000000;
                }
                else if (rgGameRbPick6.Checked == true)
                {
                    prizeGoal = 1000000;
                }
                else if (rgGameRbCash5.Checked == true)
                {
                    prizeGoal = 100000;
                }
            }
            Console.WriteLine(prizeGoal);
        }
    }
}
