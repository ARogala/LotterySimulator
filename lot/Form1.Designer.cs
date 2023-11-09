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
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.yearsToWinLbl = new System.Windows.Forms.Label();
            this.linkLblToLotterySite = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.gbGame.Controls.Add(this.radioButton5);
            this.gbGame.Controls.Add(this.radioButton4);
            this.gbGame.Controls.Add(this.radioButton1);
            this.gbGame.Controls.Add(this.rgGameRbPowerBall);
            this.gbGame.Controls.Add(this.rgGameRbMega);
            this.gbGame.Location = new System.Drawing.Point(272, 65);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(162, 138);
            this.gbGame.TabIndex = 4;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(11, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(74, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "NJ Cash 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "NJ Pick 6";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "NJ Cash 4 Life";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.cancelTryBig.Location = new System.Drawing.Point(270, 475);
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
            this.cancelLbl.Location = new System.Drawing.Point(271, 501);
            this.cancelLbl.Name = "cancelLbl";
            this.cancelLbl.Size = new System.Drawing.Size(40, 13);
            this.cancelLbl.TabIndex = 16;
            this.cancelLbl.Text = "Cancel";
            // 
            // moneySpentLbl
            // 
            this.moneySpentLbl.AutoSize = true;
            this.moneySpentLbl.Location = new System.Drawing.Point(271, 527);
            this.moneySpentLbl.Name = "moneySpentLbl";
            this.moneySpentLbl.Size = new System.Drawing.Size(70, 13);
            this.moneySpentLbl.TabIndex = 17;
            this.moneySpentLbl.Text = "Money Spent";
            // 
            // fldMoneySpent
            // 
            this.fldMoneySpent.Location = new System.Drawing.Point(270, 543);
            this.fldMoneySpent.Name = "fldMoneySpent";
            this.fldMoneySpent.Size = new System.Drawing.Size(164, 20);
            this.fldMoneySpent.TabIndex = 18;
            // 
            // moneyWonLbl
            // 
            this.moneyWonLbl.AutoSize = true;
            this.moneyWonLbl.Location = new System.Drawing.Point(271, 566);
            this.moneyWonLbl.Name = "moneyWonLbl";
            this.moneyWonLbl.Size = new System.Drawing.Size(65, 13);
            this.moneyWonLbl.TabIndex = 19;
            this.moneyWonLbl.Text = "Money Won";
            // 
            // fldMoneyWon
            // 
            this.fldMoneyWon.Location = new System.Drawing.Point(270, 582);
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
            this.netGainLossLbl.Location = new System.Drawing.Point(271, 605);
            this.netGainLossLbl.Name = "netGainLossLbl";
            this.netGainLossLbl.Size = new System.Drawing.Size(70, 13);
            this.netGainLossLbl.TabIndex = 23;
            this.netGainLossLbl.Text = "Net gain/loss";
            // 
            // fldNetGainLoss
            // 
            this.fldNetGainLoss.Location = new System.Drawing.Point(270, 621);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(270, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 77);
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
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "No";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yes";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 745);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label yearsToWinLbl;
        private System.Windows.Forms.LinkLabel linkLblToLotterySite;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

