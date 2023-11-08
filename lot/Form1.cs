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
        int moneySpent = 0;
        int moneyWon = 0;
        int gamesWon = 0;
        //this string may get REALLY large -- not sure what to do but will likly crash the app when we go for JACKPOT
        //maybe just mute output for jackpot or dump to text file periodically then display at end...
        StringBuilder sbgamesPlayed = new StringBuilder();
        

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            dm.clearGameList();
            if (!cbCoverDrum2.Checked)
            {
                moneySpent -= dm.getGameCost();
                rtbGames.AppendText(dm.play() + "\n");
                moneyWon += dm.score(fldTarget.Text, dm.scGames[0]);
                fldMoneySpent.Text = $"{moneySpent:n0}";
                fldMoneyWon.Text = $"{moneyWon:n0}";
                fldNetGainLoss.Text = $"{(moneySpent + moneyWon):n0}";
                fldGamesPlayed.Text = $"{Math.Abs((moneySpent / dm.getGameCost())):n0}";
                //display win
                scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
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
                    moneyWon += dm.score(fldTarget.Text, dm.scGames[i]);
                    fldMoneySpent.Text = $"{moneySpent:n0}";
                    fldMoneyWon.Text = $"{moneyWon:n0}";
                    fldNetGainLoss.Text = $"{(moneySpent + moneyWon):n0}";
                    //display win
                    scoreValue = dm.score(fldTarget.Text, dm.scGames[i]);
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
                        sbgamesPlayed.Append(dm.play() + "\n");
                        moneyWon += dm.score(fldTarget.Text, dm.scGames[0]);
                        scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                        if (scoreValue > 0 && scoreValue < 100)
                        {
                            //mark as 1% complete here dont want to stop till big$$$
                            gamesWon++;
                            worker.ReportProgress(1, dm.scGames[0]);
                          
                        }
                        else if (scoreValue > 99)
                        {
                            gamesWon++;
                            worker.ReportProgress(100, dm.scGames[0]);
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
                            moneyWon += dm.score(fldTarget.Text, dm.scGames[i]);
                            sbgamesPlayed.Append(dm.scGames[i] + "\n");
                            //display win
                            scoreValue = dm.score(fldTarget.Text, dm.scGames[i]);
                            //hardest part of the whole thing was to make sure we run through the rest of the drum --- wow may be true at i = 0 
                            //testing only seems to show Case2 or Case1 and Case4 -- 3 and 5 seem valid to me just not common at all 
                            if (scoreValue > 0 && scoreValue < 100 && wow == false)
                            {
                                //mark as 1% complete here dont want to stop till big$$$
                                gamesWon++;
                                worker.ReportProgress(1, dm.scGames[i]);

                            }
                            else if (scoreValue > 99 && i < (dm.scGames.Count-1) && wow == false)
                            {
                                gamesWon++;
                                worker.ReportProgress(50, dm.scGames[i]);
                                //Console.WriteLine("Case1");
                                //Console.WriteLine("i " + i);
                                wow = true;
                            }
                            else if (scoreValue > 99 && i == (dm.scGames.Count-1) && wow == false)
                            {
                                gamesWon++;
                                worker.ReportProgress(100, dm.scGames[i]);
                                //Console.WriteLine("Case2");
                                //Console.WriteLine("i " + i);
                                wow = true;
                            }
                            else if (wow == true && i < (dm.scGames.Count-1) && scoreValue > 0)
                            {
                                gamesWon++;
                                worker.ReportProgress(50, dm.scGames[i]);
                                //Console.WriteLine("Case3");
                                //Console.WriteLine("i " + i);
                            }
                            else if (wow == true && i == (dm.scGames.Count - 1) && scoreValue > 0)
                            {
                                gamesWon++;
                                worker.ReportProgress(100, dm.scGames[i]);
                                //Console.WriteLine("Case4");
                                //Console.WriteLine("i " + i);
                            }
                            else if (wow == true && i == (dm.scGames.Count - 1) && scoreValue == 0)
                            {
                                //except shouldnt report a winning ticket here
                                string noWinAt100 = "noWinAt100";
                                worker.ReportProgress(100, noWinAt100);
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
           
            if (e.ProgressPercentage == 1 || e.ProgressPercentage == 50)
            {
                rtbWon.AppendText(e.UserState + " won " + scoreValue.ToString() + "\n");
                fldMoneySpent.Text = $"{moneySpent:n0}";
                fldMoneyWon.Text = $"{moneyWon:n0}";
                fldGamesWon.Text = $"{gamesWon:n0}";
            }
            else if(e.ProgressPercentage == 100)
            {
                rtbGames.AppendText(sbgamesPlayed.ToString());
                if ((string)e.UserState != "noWinAt100")
                {
                    rtbWon.AppendText(e.UserState + " won " + scoreValue.ToString() + "\n");
                    rtbWon.AppendText("WOW");
                }
                fldMoneySpent.Text = $"{moneySpent:n0}";
                fldMoneyWon.Text = $"{moneyWon:n0}";
                fldNetGainLoss.Text = $"{(moneySpent + moneyWon):n0}";
                fldGamesPlayed.Text = $"{Math.Abs((moneySpent / dm.getGameCost())):n0}";
                fldGamesWon.Text = $"{gamesWon:n0}";
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
            fldTarget.Text = dm.GenerateNewTicket();
        }
    }
}
