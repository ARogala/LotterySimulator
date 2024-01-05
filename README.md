# Lottery Simulator

## The code base in the Backup folder was not my original work 
## (credit Uncle Jim). 
## I made all changes after initial commit

Simulator Screen Shot

![Lot Sim](UI_ScreenShot2.png?raw=true "Lottery Simulator")

Simulator Use Notes:

1. The Drum is considerd the physical Drum the winning balls are drawn from. Some games have 2 drums with separate balls in them.

2. Cover Drum 2 plays all numbers in the "power ball -- the 2nd drum" thus at least one of those tickets will win something.

3. MegaMillions, PowerBall, and Cash 4 Life are all two drum specal 2nd ball games. Pick 6 and Cash 5 are not.

4. The "Don't Get Your Hopes Up!" button plays one game with your ticket -- or one game for every possible ball in drum two if Cover Drum 2 is checked.

5. Click "Get New Ticket" to generate a new random lottery ticket.

6. The "Try for Big" button will play games until you win the selected prize amount.


## Thoughts, Bugs??, and Future ideas/plans

1. This app was a good learning experience. Some interisting aspects were: 
	 -- Adding a 2nd thread to do the calulation so the UI doesn't hang up. See backgroundWorker code in Form1.cs
	 -- Learning from someone else's code base. Always good to see how someone things and codes. 
	 -- Finding some bugs that were left in.
	 -- Adding some basic memory management. Updated UI "Games Played" every so often and cleard the variable holding the string or else memory would go out of control.
	 -- Left a Bug of my own.

2. Bug 
	 -- For some reason the variable scoreValue resets to default 0 when trying to hit a jackpot. It happens reandomly and not sure why? See backgroundWorker1_ProgressChanged method

3. Plans/Ideas
   -- Maybe generate a new ticket every so often when trying for a jackpot.
   -- May have to exclude the "Games Played" output for jackpot calculations -- this may still take too much memory. Especially if you truly try to go for jackpot.
   -- Try leaving this app running and see how long it takes to hit the big jackpot for PowerBall or MegaMillions. Calulated years and or maybe add a timer to see the hours it spent running. Does it crash because "Games Played" output takes too much RAM.
   -- It was just fun the see how crummy your odds are. Good luck it may take 3 life times just to win $50,000!!



