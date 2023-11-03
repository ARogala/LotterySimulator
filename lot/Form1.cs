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
        int bucks = 0;
        int scoreValue = 0;
        int moneySpent = 0;
        int moneyWon = 0;

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
            rtbWon.Text = "";
            cancelLbl.Text = "";
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
       
            int startBucks = 0;
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
                        dm.play();
                        moneyWon += dm.score(fldTarget.Text, dm.scGames[0]);
                        scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                        if (scoreValue > 0 && scoreValue < 100)
                        {
                            //mark as 1% complete here dont want to stop till big$$$
                            worker.ReportProgress(1, dm.scGames[0]);
                          
                        }
                        else if (scoreValue > 99)
                        {
                            worker.ReportProgress(100);
                            wow = true;
                        }

                        /*
                        bucks -= dm.getGameCost();
                        startBucks = bucks;
                        dm.play();
                        bucks += dm.score(fldTarget.Text, dm.scGames[0]);
                        //display win
                        scoreValue = dm.score(fldTarget.Text, dm.scGames[0]);
                        if (scoreValue > 0)
                        {
                            //mark as 1% complete here dont want to stop till big$$$
                            worker.ReportProgress(1, dm.scGames[0]);
                        }
                        if ((bucks - startBucks) > 999)
                        {
                            worker.ReportProgress(100);
                            wow = true;
                        }
                        */
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
                                //mark as 1% complete here dont want to stop till big$$$
                                worker.ReportProgress(1, dm.scGames[i]);
                            }
                            if ((bucks - startBucks) > 999)
                            {
                                worker.ReportProgress(100);
                                wow = true;
                            }
                        }
                    }
                }
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
            if (e.ProgressPercentage == 1)
            {
                rtbWon.AppendText(e.UserState + " won " + scoreValue.ToString() + "\n");
            }
            else
            {
                rtbWon.AppendText("WOW");
            }
            fldBucks.Text = bucks.ToString();
            //fldBucks.Refresh();
          
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
    }
}
