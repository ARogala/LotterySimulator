namespace lot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.rtbGames = new System.Windows.Forms.RichTextBox();
            this.cbCoverDrum2 = new System.Windows.Forms.CheckBox();
            this.btnClrGames = new System.Windows.Forms.Button();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.rgGameRbCash5 = new System.Windows.Forms.RadioButton();
            this.rgGameRbPick6 = new System.Windows.Forms.RadioButton();
            this.rgGameRbCash4Life = new System.Windows.Forms.RadioButton();
            this.rgGameRbPowerBall = new System.Windows.Forms.RadioButton();
            this.rgGameRbMega = new System.Windows.Forms.RadioButton();
            this.btnClrBucks = new System.Windows.Forms.Button();
            this.fldTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTryForBig = new System.Windows.Forms.Button();
            this.gamesPlayedLbl = new System.Windows.Forms.Label();
            this.gamesWonLbl = new System.Windows.Forms.Label();
            this.rtbWon = new System.Windows.Forms.RichTextBox();
            this.cancelTryBig = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelLbl = new System.Windows.Forms.Label();
            this.moneySpentLbl = new System.Windows.Forms.Label();
            this.fldMoneySpent = new System.Windows.Forms.TextBox();
            this.moneyWonLbl = new System.Windows.Forms.Label();
            this.fldMoneyWon = new System.Windows.Forms.TextBox();
            this.fldGamesPlayed = new System.Windows.Forms.TextBox();
            this.netGainLossLbl = new System.Windows.Forms.Label();
            this.fldNetGainLoss = new System.Windows.Forms.TextBox();
            this.fldGamesWon = new System.Windows.Forms.TextBox();
            this.btnGetNewTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rgTryForJackPotRbNo = new System.Windows.Forms.RadioButton();
            this.rgTryForJackPotRbYes = new System.Windows.Forms.RadioButton();
            this.yearsToWinLbl = new System.Windows.Forms.Label();
            this.linkLblToLotterySite = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbGame.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(270, 267);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(164, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Don\'t Get Your Hopes Up!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rtbGames
            // 
            this.rtbGames.Location = new System.Drawing.Point(12, 65);
            this.rtbGames.Name = "rtbGames";
            this.rtbGames.Size = new System.Drawing.Size(231, 475);
            this.rtbGames.TabIndex = 1;
            this.rtbGames.Text = "";
            // 
            // cbCoverDrum2
            // 
            this.cbCoverDrum2.AutoSize = true;
            this.cbCoverDrum2.Location = new System.Drawing.Point(272, 39);
            this.cbCoverDrum2.Name = "cbCoverDrum2";
            this.cbCoverDrum2.Size = new System.Drawing.Size(91, 17);
            this.cbCoverDrum2.TabIndex = 2;
            this.cbCoverDrum2.Text = "Cover Drum 2";
            this.cbCoverDrum2.UseVisualStyleBackColor = true;
            // 
            // btnClrGames
            // 
            this.btnClrGames.Location = new System.Drawing.Point(270, 209);
            this.btnClrGames.Name = "btnClrGames";
            this.btnClrGames.Size = new System.Drawing.Size(164, 23);
            this.btnClrGames.TabIndex = 3;
            this.btnClrGames.Text = "Clear Games";
            this.btnClrGames.UseVisualStyleBackColor = true;
            this.btnClrGames.Click += new System.EventHandler(this.btnClrGames_Click);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.rgGameRbCash5);
            this.gbGame.Controls.Add(this.rgGameRbPick6);
            this.gbGame.Controls.Add(this.rgGameRbCash4Life);
            this.gbGame.Controls.Add(this.rgGameRbPowerBall);
            this.gbGame.Controls.Add(this.rgGameRbMega);
            this.gbGame.Location = new System.Drawing.Point(272, 65);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(162, 138);
            this.gbGame.TabIndex = 4;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // rgGameRbCash5
            // 
            this.rgGameRbCash5.AutoSize = true;
            this.rgGameRbCash5.Location = new System.Drawing.Point(11, 111);
            this.rgGameRbCash5.Name = "rgGameRbCash5";
            this.rgGameRbCash5.Size = new System.Drawing.Size(74, 17);
            this.rgGameRbCash5.TabIndex = 4;
            this.rgGameRbCash5.TabStop = true;
            this.rgGameRbCash5.Text = "NJ Cash 5";
            this.rgGameRbCash5.UseVisualStyleBackColor = true;
            this.rgGameRbCash5.CheckedChanged += new System.EventHandler(this.rgGameRbCash5_CheckedChanged);
            // 
            // rgGameRbPick6
            // 
            this.rgGameRbPick6.AutoSize = true;
            this.rgGameRbPick6.Location = new System.Drawing.Point(11, 88);
            this.rgGameRbPick6.Name = "rgGameRbPick6";
            this.rgGameRbPick6.Size = new System.Drawing.Size(71, 17);
            this.rgGameRbPick6.TabIndex = 3;
            this.rgGameRbPick6.TabStop = true;
            this.rgGameRbPick6.Text = "NJ Pick 6";
            this.rgGameRbPick6.UseVisualStyleBackColor = true;
            this.rgGameRbPick6.CheckedChanged += new System.EventHandler(this.rgGameRbPick6_CheckedChanged);
            // 
            // rgGameRbCash4Life
            // 
            this.rgGameRbCash4Life.AutoSize = true;
            this.rgGameRbCash4Life.Location = new System.Drawing.Point(11, 65);
            this.rgGameRbCash4Life.Name = "rgGameRbCash4Life";
            this.rgGameRbCash4Life.Size = new System.Drawing.Size(94, 17);
            this.rgGameRbCash4Life.TabIndex = 2;
            this.rgGameRbCash4Life.TabStop = true;
            this.rgGameRbCash4Life.Text = "NJ Cash 4 Life";
            this.rgGameRbCash4Life.UseVisualStyleBackColor = true;
            this.rgGameRbCash4Life.CheckedChanged += new System.EventHandler(this.rgGameRbCash4Life_CheckedChanged);
            // 
            // rgGameRbPowerBall
            // 
            this.rgGameRbPowerBall.AutoSize = true;
            this.rgGameRbPowerBall.Checked = true;
            this.rgGameRbPowerBall.Location = new System.Drawing.Point(11, 42);
            this.rgGameRbPowerBall.Name = "rgGameRbPowerBall";
            this.rgGameRbPowerBall.Size = new System.Drawing.Size(72, 17);
            this.rgGameRbPowerBall.TabIndex = 1;
            this.rgGameRbPowerBall.TabStop = true;
            this.rgGameRbPowerBall.Text = "PowerBall";
            this.rgGameRbPowerBall.UseVisualStyleBackColor = true;
            this.rgGameRbPowerBall.CheckedChanged += new System.EventHandler(this.rgGameRbPowerBall_CheckedChanged);
            // 
            // rgGameRbMega
            // 
            this.rgGameRbMega.AutoSize = true;
            this.rgGameRbMega.Location = new System.Drawing.Point(11, 19);
            this.rgGameRbMega.Name = "rgGameRbMega";
            this.rgGameRbMega.Size = new System.Drawing.Size(86, 17);
            this.rgGameRbMega.TabIndex = 0;
            this.rgGameRbMega.Text = "MegaMillions";
            this.rgGameRbMega.UseVisualStyleBackColor = true;
            this.rgGameRbMega.CheckedChanged += new System.EventHandler(this.rgGameRbMega_CheckedChanged);
            // 
            // btnClrBucks
            // 
            this.btnClrBucks.Location = new System.Drawing.Point(270, 238);
            this.btnClrBucks.Name = "btnClrBucks";
            this.btnClrBucks.Size = new System.Drawing.Size(164, 23);
            this.btnClrBucks.TabIndex = 8;
            this.btnClrBucks.Text = "Clear Bucks";
            this.btnClrBucks.UseVisualStyleBackColor = true;
            this.btnClrBucks.Click += new System.EventHandler(this.btnClrBucks_Click);
            // 
            // fldTarget
            // 
            this.fldTarget.Location = new System.Drawing.Point(270, 309);
            this.fldTarget.Name = "fldTarget";
            this.fldTarget.Size = new System.Drawing.Size(164, 20);
            this.fldTarget.TabIndex = 10;
            this.fldTarget.Text = "19 30 33 48 59 [26]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Target Numbers - Your Ticket";
            // 
            // btnTryForBig
            // 
            this.btnTryForBig.Location = new System.Drawing.Point(270, 363);
            this.btnTryForBig.Name = "btnTryForBig";
            this.btnTryForBig.Size = new System.Drawing.Size(164, 23);
            this.btnTryForBig.TabIndex = 11;
            this.btnTryForBig.Text = "Try for Big";
            this.btnTryForBig.UseVisualStyleBackColor = true;
            this.btnTryForBig.Click += new System.EventHandler(this.btnTryForBig_Click);
            // 
            // gamesPlayedLbl
            // 
            this.gamesPlayedLbl.AutoSize = true;
            this.gamesPlayedLbl.Location = new System.Drawing.Point(12, 18);
            this.gamesPlayedLbl.Name = "gamesPlayedLbl";
            this.gamesPlayedLbl.Size = new System.Drawing.Size(153, 13);
            this.gamesPlayedLbl.TabIndex = 12;
            this.gamesPlayedLbl.Text = "Games Played -- Includes Won";
            // 
            // gamesWonLbl
            // 
            this.gamesWonLbl.AutoSize = true;
            this.gamesWonLbl.Location = new System.Drawing.Point(470, 18);
            this.gamesWonLbl.Name = "gamesWonLbl";
            this.gamesWonLbl.Size = new System.Drawing.Size(66, 13);
            this.gamesWonLbl.TabIndex = 13;
            this.gamesWonLbl.Text = "Games Won";
            // 
            // rtbWon
            // 
            this.rtbWon.Location = new System.Drawing.Point(473, 65);
            this.rtbWon.Name = "rtbWon";
            this.rtbWon.Size = new System.Drawing.Size(229, 475);
            this.rtbWon.TabIndex = 14;
            this.rtbWon.Text = "";
            // 
            // cancelTryBig
            // 
            this.cancelTryBig.Location = new System.Drawing.Point(270, 501);
            this.cancelTryBig.Name = "cancelTryBig";
            this.cancelTryBig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelTryBig.Size = new System.Drawing.Size(164, 23);
            this.cancelTryBig.TabIndex = 15;
            this.cancelTryBig.Text = "Cancel";
            this.cancelTryBig.UseVisualStyleBackColor = true;
            this.cancelTryBig.Click += new System.EventHandler(this.cancelTryBig_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancelLbl
            // 
            this.cancelLbl.AutoSize = true;
            this.cancelLbl.Location = new System.Drawing.Point(271, 527);
            this.cancelLbl.Name = "cancelLbl";
            this.cancelLbl.Size = new System.Drawing.Size(40, 13);
            this.cancelLbl.TabIndex = 16;
            this.cancelLbl.Text = "Cancel";
            // 
            // moneySpentLbl
            // 
            this.moneySpentLbl.AutoSize = true;
            this.moneySpentLbl.Location = new System.Drawing.Point(271, 549);
            this.moneySpentLbl.Name = "moneySpentLbl";
            this.moneySpentLbl.Size = new System.Drawing.Size(70, 13);
            this.moneySpentLbl.TabIndex = 17;
            this.moneySpentLbl.Text = "Money Spent";
            // 
            // fldMoneySpent
            // 
            this.fldMoneySpent.Location = new System.Drawing.Point(270, 565);
            this.fldMoneySpent.Name = "fldMoneySpent";
            this.fldMoneySpent.Size = new System.Drawing.Size(164, 20);
            this.fldMoneySpent.TabIndex = 18;
            // 
            // moneyWonLbl
            // 
            this.moneyWonLbl.AutoSize = true;
            this.moneyWonLbl.Location = new System.Drawing.Point(271, 588);
            this.moneyWonLbl.Name = "moneyWonLbl";
            this.moneyWonLbl.Size = new System.Drawing.Size(65, 13);
            this.moneyWonLbl.TabIndex = 19;
            this.moneyWonLbl.Text = "Money Won";
            // 
            // fldMoneyWon
            // 
            this.fldMoneyWon.Location = new System.Drawing.Point(270, 604);
            this.fldMoneyWon.Name = "fldMoneyWon";
            this.fldMoneyWon.Size = new System.Drawing.Size(164, 20);
            this.fldMoneyWon.TabIndex = 20;
            // 
            // fldGamesPlayed
            // 
            this.fldGamesPlayed.Location = new System.Drawing.Point(15, 39);
            this.fldGamesPlayed.Name = "fldGamesPlayed";
            this.fldGamesPlayed.Size = new System.Drawing.Size(228, 20);
            this.fldGamesPlayed.TabIndex = 22;
            // 
            // netGainLossLbl
            // 
            this.netGainLossLbl.AutoSize = true;
            this.netGainLossLbl.Location = new System.Drawing.Point(271, 627);
            this.netGainLossLbl.Name = "netGainLossLbl";
            this.netGainLossLbl.Size = new System.Drawing.Size(70, 13);
            this.netGainLossLbl.TabIndex = 23;
            this.netGainLossLbl.Text = "Net gain/loss";
            // 
            // fldNetGainLoss
            // 
            this.fldNetGainLoss.Location = new System.Drawing.Point(270, 643);
            this.fldNetGainLoss.Name = "fldNetGainLoss";
            this.fldNetGainLoss.Size = new System.Drawing.Size(164, 20);
            this.fldNetGainLoss.TabIndex = 24;
            // 
            // fldGamesWon
            // 
            this.fldGamesWon.Location = new System.Drawing.Point(473, 42);
            this.fldGamesWon.Name = "fldGamesWon";
            this.fldGamesWon.Size = new System.Drawing.Size(228, 20);
            this.fldGamesWon.TabIndex = 25;
            // 
            // btnGetNewTicket
            // 
            this.btnGetNewTicket.Location = new System.Drawing.Point(270, 335);
            this.btnGetNewTicket.Name = "btnGetNewTicket";
            this.btnGetNewTicket.Size = new System.Drawing.Size(164, 22);
            this.btnGetNewTicket.TabIndex = 26;
            this.btnGetNewTicket.Text = "Get New Ticket";
            this.btnGetNewTicket.UseVisualStyleBackColor = true;
            this.btnGetNewTicket.Click += new System.EventHandler(this.btnGetNewTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rgTryForJackPotRbNo);
            this.groupBox1.Controls.Add(this.rgTryForJackPotRbYes);
            this.groupBox1.Location = new System.Drawing.Point(270, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 78);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Try For JackPot?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stops At Match 5";
            // 
            // rgTryForJackPotRbNo
            // 
            this.rgTryForJackPotRbNo.AutoSize = true;
            this.rgTryForJackPotRbNo.Location = new System.Drawing.Point(10, 42);
            this.rgTryForJackPotRbNo.Name = "rgTryForJackPotRbNo";
            this.rgTryForJackPotRbNo.Size = new System.Drawing.Size(39, 17);
            this.rgTryForJackPotRbNo.TabIndex = 1;
            this.rgTryForJackPotRbNo.Text = "No";
            this.rgTryForJackPotRbNo.UseVisualStyleBackColor = true;
            this.rgTryForJackPotRbNo.CheckedChanged += new System.EventHandler(this.rgTryForJackPotRbNo_CheckedChanged);
            // 
            // rgTryForJackPotRbYes
            // 
            this.rgTryForJackPotRbYes.AutoSize = true;
            this.rgTryForJackPotRbYes.Location = new System.Drawing.Point(10, 19);
            this.rgTryForJackPotRbYes.Name = "rgTryForJackPotRbYes";
            this.rgTryForJackPotRbYes.Size = new System.Drawing.Size(43, 17);
            this.rgTryForJackPotRbYes.TabIndex = 0;
            this.rgTryForJackPotRbYes.TabStop = true;
            this.rgTryForJackPotRbYes.Text = "Yes";
            this.rgTryForJackPotRbYes.UseVisualStyleBackColor = true;
            this.rgTryForJackPotRbYes.CheckedChanged += new System.EventHandler(this.rgTryForJackPotRbYes_CheckedChanged);
            // 
            // yearsToWinLbl
            // 
            this.yearsToWinLbl.AutoSize = true;
            this.yearsToWinLbl.Location = new System.Drawing.Point(470, 550);
            this.yearsToWinLbl.Name = "yearsToWinLbl";
            this.yearsToWinLbl.Size = new System.Drawing.Size(0, 13);
            this.yearsToWinLbl.TabIndex = 29;
            // 
            // linkLblToLotterySite
            // 
            this.linkLblToLotterySite.AutoSize = true;
            this.linkLblToLotterySite.Location = new System.Drawing.Point(9, 550);
            this.linkLblToLotterySite.Name = "linkLblToLotterySite";
            this.linkLblToLotterySite.Size = new System.Drawing.Size(142, 13);
            this.linkLblToLotterySite.TabIndex = 30;
            this.linkLblToLotterySite.TabStop = true;
            this.linkLblToLotterySite.Text = "Game Information and Prizes";
            this.linkLblToLotterySite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblToLotterySite_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 566);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(231, 142);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Un-Checked stops at 1st  prize > 1,000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Match 4 for Cash 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 745);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.linkLblToLotterySite);
            this.Controls.Add(this.yearsToWinLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetNewTicket);
            this.Controls.Add(this.fldGamesWon);
            this.Controls.Add(this.fldNetGainLoss);
            this.Controls.Add(this.netGainLossLbl);
            this.Controls.Add(this.fldGamesPlayed);
            this.Controls.Add(this.fldMoneyWon);
            this.Controls.Add(this.moneyWonLbl);
            this.Controls.Add(this.fldMoneySpent);
            this.Controls.Add(this.moneySpentLbl);
            this.Controls.Add(this.cancelLbl);
            this.Controls.Add(this.cancelTryBig);
            this.Controls.Add(this.rtbWon);
            this.Controls.Add(this.gamesWonLbl);
            this.Controls.Add(this.gamesPlayedLbl);
            this.Controls.Add(this.btnTryForBig);
            this.Controls.Add(this.fldTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClrBucks);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.btnClrGames);
            this.Controls.Add(this.cbCoverDrum2);
            this.Controls.Add(this.rtbGames);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Lottery Simulator 2023 Geek Fest -- Hopes are Futile!! The Collective Is Winning";
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RichTextBox rtbGames;
        private System.Windows.Forms.CheckBox cbCoverDrum2;
        private System.Windows.Forms.Button btnClrGames;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.RadioButton rgGameRbPowerBall;
        private System.Windows.Forms.RadioButton rgGameRbMega;
        private System.Windows.Forms.Button btnClrBucks;
        private System.Windows.Forms.TextBox fldTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTryForBig;
        private System.Windows.Forms.Label gamesPlayedLbl;
        private System.Windows.Forms.Label gamesWonLbl;
        private System.Windows.Forms.RichTextBox rtbWon;
        private System.Windows.Forms.Button cancelTryBig;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label cancelLbl;
        private System.Windows.Forms.Label moneySpentLbl;
        private System.Windows.Forms.TextBox fldMoneySpent;
        private System.Windows.Forms.Label moneyWonLbl;
        private System.Windows.Forms.TextBox fldMoneyWon;
        private System.Windows.Forms.TextBox fldGamesPlayed;
        private System.Windows.Forms.Label netGainLossLbl;
        private System.Windows.Forms.TextBox fldNetGainLoss;
        private System.Windows.Forms.TextBox fldGamesWon;
        private System.Windows.Forms.Button btnGetNewTicket;
        private System.Windows.Forms.RadioButton rgGameRbCash4Life;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rgTryForJackPotRbNo;
        private System.Windows.Forms.RadioButton rgTryForJackPotRbYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rgGameRbCash5;
        private System.Windows.Forms.RadioButton rgGameRbPick6;
        private System.Windows.Forms.Label yearsToWinLbl;
        private System.Windows.Forms.LinkLabel linkLblToLotterySite;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

