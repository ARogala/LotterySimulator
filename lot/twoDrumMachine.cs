using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace lot
{
    class C2DrumMachine
    {
        //scDrum1 and 2 store all the lottery numbers -- represents the lottery balls
        public StringCollection scDrum1 = new StringCollection();
        public StringCollection scDrum2 = new StringCollection();
        //scDrum1Picks and scDrum2Picks store the randomly selected numbers -- match these to your ticket and win
        public StringCollection scDrum1Picks = new StringCollection();
        public StringCollection scDrum2Picks = new StringCollection();
        //stores all the randomly selected numbers in both scDrum1Picks and scDrum2Picks
        public StringCollection scGames = new StringCollection();
        private int d1NMax;
        private int d1NPicks;
        private int? d2NMax;
        private int? d2NPicks;
        //If your application requires different random number sequences, invoke this constructor repeatedly with different seed values
        //add some more randomness to this thing -- great i like it
        private Random r = new Random((int)DateTime.Now.Ticks);
        private gameTypes gameType;
        private int gameCost;

        public enum gameTypes { powerball, megamillions, cash4Life, pick6, custom };
        //1st constructor -- for use with custom game type
        public C2DrumMachine(int drum1Picks, int drum1NMax, int drum2Picks, int drum2NMax)
        {
            setMachine(drum1Picks, drum1NMax, drum2Picks, drum2NMax);
            this.gameType = gameTypes.custom;
        }
        //2nd constructor
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
        //why -1 on number of picks? ok see the loop in play()
        //set vars based on game type 
        public void setMachine(int drum1Picks, int drum1NMax, int? drum2Picks = null, int? drum2NMax = null)
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
                case gameTypes.cash4Life:
                    setMachine(5, 60, 1, 4);
                    gameCost = 2;
                    break;
                case gameTypes.pick6:
                    setMachine(6, 46);
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

        //clear the old string collectios scDrum1, scDrum2, scDrum1Picks, and scDrum2Picks 
        //and add the drum numbers (lottery balls) to string collections scDrum1, scDrum2
        public void newGame()
        {
            int i;

            scDrum2.Clear();
            scDrum2Picks.Clear();
            for (i = 1; i <= d2NMax; i++)
                scDrum2.Add(frmt(i));
            initDrum1();
        }
        //function that returns random number as string -- getRandomNumber
        //select a random range from the scDrum array
        //add random number from lottery balls to scDrum1/2Picks
        //remove that number from the drum/lottery balls so it cannot be selected again
        private string getN(int drumNo)
        {
            int i;
            string s = "NG";

            switch (drumNo)
            {
                case 1:
                    i = r.Next(0, scDrum1.Count); //remove count - 1
                    s = scDrum1[i];
                    this.scDrum1Picks.Add(s);
                    this.scDrum1.RemoveAt(i);
                    break;
                case 2:
                    i = r.Next(0, scDrum2.Count); //remove count - 1 
                    s = scDrum2[i];
                    this.scDrum2Picks.Add(s);
                    this.scDrum2.RemoveAt(i);
                    break;
            }
            return (s);
        }

        //does the same as play() except plays each number in drum 2
        public void playDrum2()
        {
            StringBuilder sb = new StringBuilder();
            int g2;
            int nTickets = 1;

            switch (this.gameType)
            {
                case gameTypes.megamillions: nTickets = 25; break; //shouldnt this be 25? was 46
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

        //picks your lucky random numbers adds them to scDrumPicks -- sorts scDrumPicks
        //retruns a string of lucky random numbers
        //adds all lucky nums to scGames
        public string play(bool twoDrum)
        {
            //cool oddly i dont remember ever using this class before -- better than concatenation
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

            if(twoDrum)
            {
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
            }
            //_______game_________
            scGames.Add(sb.ToString());
            return (sb.ToString());
        }
        //same as play except DO NOT add to scGames
        public string GenerateNewTicket(bool twoDrum)
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
            if(twoDrum)
            {
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
            }
            
            return (sb.ToString());
        }
        //target is the numbers on your ticket game is scGames[0] which are the random picked numbers to match
        //foreach num in game check for a matching num on ticket
        //if matched number is not 2nd drum (powerball) add 1
        //if matched numer is the powerball add 10
        //return the sum
        public int getMatched(string target, string game)
        {
            int matched = 0;
            string[] arTarget;
            string[] arGame;
            char[] charSeparators = new char[] { ' ' };
            //your ticket numbers --- not sure if StringSplitOptions.RemoveEmptyEntries was/is needed dont think it will ever have Empty. added for safety i assume?
            arTarget = target.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            //random nums from drum
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

        //returns the $$$ won on each ticket
        public int score(string target, string game)
        {
            int value = 0;

            switch (this.gameType)
            {
                //power ball rule change for 4 and 3 and 10
                //mega is still correct
                case gameTypes.powerball:
                    switch (getMatched(target, game))
                    {
                        case 10: value = 4; break;
                        case 11: value = 4; break;
                        case 3:  value = 7; break;
                        case 12: value = 7; break;
                        case 4:  value = 100; break;
                        case 13: value = 100; break;
                        case 14: value = 50000; break;
                        case 5:  value = 1000000; break;
                        case 15: value = 150000000; break; //actually jackpot
                    }
                    break;
                case gameTypes.megamillions:
                    switch (getMatched(target, game))
                    {
                        case 10: value = 2; break;
                        case 11: value = 4; break;
                        case 3:  value = 10; break;
                        case 12: value = 10; break;
                        case 13: value = 200; break;
                        case 4:  value = 500; break;
                        case 14: value = 10000; break;
                        case 5:  value = 1000000; break;
                        case 15: value = 150000000; break; //actually jackpot
                    }
                    break;
                case gameTypes.cash4Life:
                    switch (getMatched(target, game))
                    {
                        case 11: value = 2; break;
                        case 2:  value = 4; break;
                        case 12: value = 10; break;
                        case 3:  value = 25; break;
                        case 13: value = 100; break;
                        case 4:  value = 500; break;
                        case 14: value = 2500; break;
                        case 5:  value = 1000000; break;
                        case 15: value = 7000000; break;
                    }
                    break;
                case gameTypes.pick6:
                    switch (getMatched(target, game))
                    {
                        case 3: value = 2; break;
                        case 4: value = 30; break;
                        case 5: value = 1500; break;
                        case 6: value = 2000000; break;
                    }
                    break;
            }
           
            return (value);
        }


    }
}
