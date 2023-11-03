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
            this.btnPlay = new System.Windows.Forms.Button();
            this.rtbGames = new System.Windows.Forms.RichTextBox();
            this.cbCoverDrum2 = new System.Windows.Forms.CheckBox();
            this.btnClrGames = new System.Windows.Forms.Button();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.rgGameRbPowerBall = new System.Windows.Forms.RadioButton();
            this.rgGameRbMega = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fldBucks = new System.Windows.Forms.TextBox();
            this.btnClrBucks = new System.Windows.Forms.Button();
            this.fldTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTryForBig = new System.Windows.Forms.Button();
            this.ticketsPlayedLbl = new System.Windows.Forms.Label();
            this.ticketsWonLbl = new System.Windows.Forms.Label();
            this.rtbWon = new System.Windows.Forms.RichTextBox();
            this.cancelTryBig = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelLbl = new System.Windows.Forms.Label();
            this.moneySpentLbl = new System.Windows.Forms.Label();
            this.fldMoneySpent = new System.Windows.Forms.TextBox();
            this.moneyWonLbl = new System.Windows.Forms.Label();
            this.fldMoneyWon = new System.Windows.Forms.TextBox();
            this.gamePlayedLbl = new System.Windows.Forms.Label();
            this.fldGamesPlayed = new System.Windows.Forms.TextBox();
            this.netGainLossLbl = new System.Windows.Forms.Label();
            this.fldNetGainLoss = new System.Windows.Forms.TextBox();
            this.gbGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(274, 247);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(160, 23);
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
            this.cbCoverDrum2.Location = new System.Drawing.Point(283, 29);
            this.cbCoverDrum2.Name = "cbCoverDrum2";
            this.cbCoverDrum2.Size = new System.Drawing.Size(91, 17);
            this.cbCoverDrum2.TabIndex = 2;
            this.cbCoverDrum2.Text = "Cover Drum 2";
            this.cbCoverDrum2.UseVisualStyleBackColor = true;
            // 
            // btnClrGames
            // 
            this.btnClrGames.Location = new System.Drawing.Point(274, 189);
            this.btnClrGames.Name = "btnClrGames";
            this.btnClrGames.Size = new System.Drawing.Size(160, 23);
            this.btnClrGames.TabIndex = 3;
            this.btnClrGames.Text = "Clear Games";
            this.btnClrGames.UseVisualStyleBackColor = true;
            this.btnClrGames.Click += new System.EventHandler(this.btnClrGames_Click);
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.rgGameRbPowerBall);
            this.gbGame.Controls.Add(this.rgGameRbMega);
            this.gbGame.Location = new System.Drawing.Point(280, 65);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(154, 100);
            this.gbGame.TabIndex = 4;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            // 
            // rgGameRbPowerBall
            // 
            this.rgGameRbPowerBall.AutoSize = true;
            this.rgGameRbPowerBall.Checked = true;
            this.rgGameRbPowerBall.Location = new System.Drawing.Point(16, 59);
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
            this.rgGameRbMega.Location = new System.Drawing.Point(16, 29);
            this.rgGameRbMega.Name = "rgGameRbMega";
            this.rgGameRbMega.Size = new System.Drawing.Size(86, 17);
            this.rgGameRbMega.TabIndex = 0;
            this.rgGameRbMega.Text = "MegaMillions";
            this.rgGameRbMega.UseVisualStyleBackColor = true;
            this.rgGameRbMega.CheckedChanged += new System.EventHandler(this.rgGameRbMega_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bucks";
            // 
            // fldBucks
            // 
            this.fldBucks.Location = new System.Drawing.Point(274, 328);
            this.fldBucks.Name = "fldBucks";
            this.fldBucks.Size = new System.Drawing.Size(160, 20);
            this.fldBucks.TabIndex = 6;
            // 
            // btnClrBucks
            // 
            this.btnClrBucks.Location = new System.Drawing.Point(274, 218);
            this.btnClrBucks.Name = "btnClrBucks";
            this.btnClrBucks.Size = new System.Drawing.Size(160, 23);
            this.btnClrBucks.TabIndex = 8;
            this.btnClrBucks.Text = "Clear Bucks";
            this.btnClrBucks.UseVisualStyleBackColor = true;
            this.btnClrBucks.Click += new System.EventHandler(this.btnClrBucks_Click);
            // 
            // fldTarget
            // 
            this.fldTarget.Location = new System.Drawing.Point(274, 289);
            this.fldTarget.Name = "fldTarget";
            this.fldTarget.Size = new System.Drawing.Size(160, 20);
            this.fldTarget.TabIndex = 10;
            this.fldTarget.Text = "19 30 33 48 59 [26]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Target Numbers";
            // 
            // btnTryForBig
            // 
            this.btnTryForBig.Location = new System.Drawing.Point(274, 365);
            this.btnTryForBig.Name = "btnTryForBig";
            this.btnTryForBig.Size = new System.Drawing.Size(160, 23);
            this.btnTryForBig.TabIndex = 11;
            this.btnTryForBig.Text = "Try for Big";
            this.btnTryForBig.UseVisualStyleBackColor = true;
            this.btnTryForBig.Click += new System.EventHandler(this.btnTryForBig_Click);
            // 
            // ticketsPlayedLbl
            // 
            this.ticketsPlayedLbl.AutoSize = true;
            this.ticketsPlayedLbl.Location = new System.Drawing.Point(23, 37);
            this.ticketsPlayedLbl.Name = "ticketsPlayedLbl";
            this.ticketsPlayedLbl.Size = new System.Drawing.Size(77, 13);
            this.ticketsPlayedLbl.TabIndex = 12;
            this.ticketsPlayedLbl.Text = "Tickets Played";
            // 
            // ticketsWonLbl
            // 
            this.ticketsWonLbl.AutoSize = true;
            this.ticketsWonLbl.Location = new System.Drawing.Point(470, 37);
            this.ticketsWonLbl.Name = "ticketsWonLbl";
            this.ticketsWonLbl.Size = new System.Drawing.Size(68, 13);
            this.ticketsWonLbl.TabIndex = 13;
            this.ticketsWonLbl.Text = "Tickets Won";
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
            this.cancelTryBig.Location = new System.Drawing.Point(274, 405);
            this.cancelTryBig.Name = "cancelTryBig";
            this.cancelTryBig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelTryBig.Size = new System.Drawing.Size(160, 23);
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
            this.cancelLbl.Location = new System.Drawing.Point(283, 441);
            this.cancelLbl.Name = "cancelLbl";
            this.cancelLbl.Size = new System.Drawing.Size(0, 13);
            this.cancelLbl.TabIndex = 16;
            // 
            // moneySpentLbl
            // 
            this.moneySpentLbl.AutoSize = true;
            this.moneySpentLbl.Location = new System.Drawing.Point(271, 454);
            this.moneySpentLbl.Name = "moneySpentLbl";
            this.moneySpentLbl.Size = new System.Drawing.Size(70, 13);
            this.moneySpentLbl.TabIndex = 17;
            this.moneySpentLbl.Text = "Money Spent";
            // 
            // fldMoneySpent
            // 
            this.fldMoneySpent.Location = new System.Drawing.Point(274, 470);
            this.fldMoneySpent.Name = "fldMoneySpent";
            this.fldMoneySpent.Size = new System.Drawing.Size(160, 20);
            this.fldMoneySpent.TabIndex = 18;
            // 
            // moneyWonLbl
            // 
            this.moneyWonLbl.AutoSize = true;
            this.moneyWonLbl.Location = new System.Drawing.Point(271, 493);
            this.moneyWonLbl.Name = "moneyWonLbl";
            this.moneyWonLbl.Size = new System.Drawing.Size(65, 13);
            this.moneyWonLbl.TabIndex = 19;
            this.moneyWonLbl.Text = "Money Won";
            // 
            // fldMoneyWon
            // 
            this.fldMoneyWon.Location = new System.Drawing.Point(274, 509);
            this.fldMoneyWon.Name = "fldMoneyWon";
            this.fldMoneyWon.Size = new System.Drawing.Size(160, 20);
            this.fldMoneyWon.TabIndex = 20;
            // 
            // gamePlayedLbl
            // 
            this.gamePlayedLbl.AutoSize = true;
            this.gamePlayedLbl.Location = new System.Drawing.Point(271, 532);
            this.gamePlayedLbl.Name = "gamePlayedLbl";
            this.gamePlayedLbl.Size = new System.Drawing.Size(75, 13);
            this.gamePlayedLbl.TabIndex = 21;
            this.gamePlayedLbl.Text = "Games Played";
            // 
            // fldGamesPlayed
            // 
            this.fldGamesPlayed.Location = new System.Drawing.Point(274, 548);
            this.fldGamesPlayed.Name = "fldGamesPlayed";
            this.fldGamesPlayed.Size = new System.Drawing.Size(160, 20);
            this.fldGamesPlayed.TabIndex = 22;
            // 
            // netGainLossLbl
            // 
            this.netGainLossLbl.AutoSize = true;
            this.netGainLossLbl.Location = new System.Drawing.Point(271, 571);
            this.netGainLossLbl.Name = "netGainLossLbl";
            this.netGainLossLbl.Size = new System.Drawing.Size(70, 13);
            this.netGainLossLbl.TabIndex = 23;
            this.netGainLossLbl.Text = "Net gain/loss";
            // 
            // fldNetGainLoss
            // 
            this.fldNetGainLoss.Location = new System.Drawing.Point(274, 587);
            this.fldNetGainLoss.Name = "fldNetGainLoss";
            this.fldNetGainLoss.Size = new System.Drawing.Size(160, 20);
            this.fldNetGainLoss.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 669);
            this.Controls.Add(this.fldNetGainLoss);
            this.Controls.Add(this.netGainLossLbl);
            this.Controls.Add(this.fldGamesPlayed);
            this.Controls.Add(this.gamePlayedLbl);
            this.Controls.Add(this.fldMoneyWon);
            this.Controls.Add(this.moneyWonLbl);
            this.Controls.Add(this.fldMoneySpent);
            this.Controls.Add(this.moneySpentLbl);
            this.Controls.Add(this.cancelLbl);
            this.Controls.Add(this.cancelTryBig);
            this.Controls.Add(this.rtbWon);
            this.Controls.Add(this.ticketsWonLbl);
            this.Controls.Add(this.ticketsPlayedLbl);
            this.Controls.Add(this.btnTryForBig);
            this.Controls.Add(this.fldTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClrBucks);
            this.Controls.Add(this.fldBucks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.btnClrGames);
            this.Controls.Add(this.cbCoverDrum2);
            this.Controls.Add(this.rtbGames);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Lottery Simulator -- Hopes are Futile";
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fldBucks;
        private System.Windows.Forms.Button btnClrBucks;
        private System.Windows.Forms.TextBox fldTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTryForBig;
        private System.Windows.Forms.Label ticketsPlayedLbl;
        private System.Windows.Forms.Label ticketsWonLbl;
        private System.Windows.Forms.RichTextBox rtbWon;
        private System.Windows.Forms.Button cancelTryBig;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label cancelLbl;
        private System.Windows.Forms.Label moneySpentLbl;
        private System.Windows.Forms.TextBox fldMoneySpent;
        private System.Windows.Forms.Label moneyWonLbl;
        private System.Windows.Forms.TextBox fldMoneyWon;
        private System.Windows.Forms.Label gamePlayedLbl;
        private System.Windows.Forms.TextBox fldGamesPlayed;
        private System.Windows.Forms.Label netGainLossLbl;
        private System.Windows.Forms.TextBox fldNetGainLoss;
    }
}

