using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace lot
{
    class C2DrumMachine
    {
        public StringCollection scDrum1 = new StringCollection();
        public StringCollection scDrum2 = new StringCollection();
        public StringCollection scDrum1Picks = new StringCollection();
        public StringCollection scDrum2Picks = new StringCollection();
        public StringCollection scGames = new StringCollection();
        private int d1NMax;
        private int d1NPicks;
        private int d2NMax;
        private int d2NPicks;
        private Random r = new Random((int)DateTime.Now.Ticks);
        private gameTypes gameType;
        private int gameCost;

        public enum gameTypes { powerball, megamillions, custom };

        public C2DrumMachine(int drum1Picks, int drum1NMax, int drum2Picks, int drum2NMax)
        {
            setMachine(drum1Picks, drum1NMax, drum2Picks, drum2NMax);
            this.gameType = gameTypes.custom;
        }

        public C2DrumMachine(gameTypes gameName)
        {
            setGame(gameName);
        }

        public void clearGameList()
        {
            scGames.Clear();
        }

        public int getGameCost()
        {
            return (gameCost);
        }

        public void setMachine(int drum1Picks, int drum1NMax, int drum2Picks, int drum2NMax)
        {
            this.d1NMax = drum1NMax;
            this.d1NPicks = drum1Picks - 1;
            this.d2NMax = drum2NMax;
            this.d2NPicks = drum2Picks - 1;
            newGame();
        }

        public void setGame(gameTypes gameName)
        {
            this.gameType = gameName;
            switch (gameName)
            {
                case gameTypes.megamillions:
                    setMachine(5, 70, 1, 25);
                    gameCost = 2;
                    break;
                case gameTypes.powerball:
                    setMachine(5, 69, 1, 26);
                    gameCost = 2;
                    break;
            }
        }

        private string frmt(int i)
        {
            string s;

            s = i.ToString("00");
            return (s);
        }

        private void initDrum1()
        {
            scDrum1.Clear();
            scDrum1Picks.Clear();
            for (int i = 1; i <= d1NMax; i++)
                scDrum1.Add(frmt(i));
        }


        public void newGame()
        {
            int i;

            scDrum2.Clear();
            scDrum2Picks.Clear();
            for (i = 1; i <= d2NMax; i++)
                scDrum2.Add(frmt(i));
            initDrum1();
        }

        private string getN(int drumNo)
        {
            int i;
            string s = "NG";

            switch (drumNo)
            {
                case 1:
                    i = r.Next(0, scDrum1.Count - 1);
                    s = scDrum1[i];
                    this.scDrum1Picks.Add(s);
                    this.scDrum1.RemoveAt(i);
                    break;
                case 2:
                    i = r.Next(0, scDrum2.Count - 1);
                    s = scDrum2[i];
                    this.scDrum2Picks.Add(s);
                    this.scDrum2.RemoveAt(i);
                    break;
            }
            return (s);
        }

        public void playDrum2()
        {
            StringBuilder sb = new StringBuilder();
            int g2;
            int nTickets = 1;

            switch (this.gameType)
            {
                case gameTypes.megamillions: nTickets = 46; break;
                case gameTypes.powerball: nTickets = 26; break;
            }
            scGames.Clear();
            for (int g = 0; g < nTickets; g++)
            {
                initDrum1();
                sb.Length = 0;
                //______drum1________
                for (int i = 0; i <= d1NPicks; i++)
                    getN(1);
                ArrayList.Adapter(scDrum1Picks).Sort();
                for (int i = 0; i <= d1NPicks; i++)
                {
                    sb.Append(scDrum1Picks[i]);
                    sb.Append(" ");
                }
                //_____drum2__________
                sb.Append("[");
                g2 = g + 1;
                sb.Append(g2.ToString("00"));
                sb.Append("] ");
                scGames.Add(sb.ToString());
            }
        }

        public string play()
        {
            StringBuilder sb = new StringBuilder();

            newGame();
            //______drum1________
            for (int i = 0; i <= d1NPicks; i++)
                getN(1);
            ArrayList.Adapter(scDrum1Picks).Sort();
            for (int i = 0; i <= d1NPicks; i++)
            {
                sb.Append(scDrum1Picks[i]);
                sb.Append(" ");
            }
            //_____drum2__________
            for (int i = 0; i <= d2NPicks; i++)
                getN(2);
            ArrayList.Adapter(scDrum2Picks).Sort();
            for (int i = 0; i <= d2NPicks; i++)
            {
                sb.Append("[");
                sb.Append(scDrum2Picks[i]);
                sb.Append("] ");
            }
            //_______game_________
            scGames.Add(sb.ToString());
            return (sb.ToString());
        }

        public int getMatched(string target, string game)
        {
            int matched = 0;
            string[] arTarget;
            string[] arGame;
            char[] charSeparators = new char[] { ' ' };

            arTarget = target.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            arGame = game.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ball in arGame)
                if (ArrayList.Adapter(arTarget).Contains(ball))
                {
                    if (ball.IndexOf("[") > -1)
                        matched += 10;
                    else
                        matched++;
                }
            return (matched);
        }

        public int score(string target, string game)
        {
            int value = 0;

            switch (this.gameType)
            {
                case gameTypes.powerball:
                    switch (getMatched(target, game))
                    {
                        case 10:
                        case 11: value = 4; break;
                        case 3:
                        case 12: value = 7; break;
                        case 4:
                        case 13: value = 100; break;
                        case 14: value = 50000; break;
                        case 5: value = 1000000; break;
                        case 15: value = 150000000; break; //actually jackpot
                    }
                    break;
                case gameTypes.megamillions:
                    switch (getMatched(target, game))
                    {
                        case 10: value = 2; break;
                        case 11: value = 4; break;
                        case 3: value = 10; break;
                        case 12: value = 10; break;
                        case 13: value = 200; break;
                        case 4: value = 500; break;
                        case 14: value = 10000; break;
                        case 5: value = 1000000; break;
                        case 15: value = 150000000; break; //actually jackpot
                    }
                    break;
            }
            if (value > 0)
                Console.WriteLine(game + " won " + value.ToString());
            return (value);
        }


    }
}
