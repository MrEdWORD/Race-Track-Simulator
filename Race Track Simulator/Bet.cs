﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Simulator
{
    class Bet
    {
        public int Amount; //The amount of cash that was bet
        public int Dog; //The number of the dog the bet is on
        public Gambler Bettor; //The guy who placed the bet

        public string GetDescription()
        {
            //Return a string that says who placed the bet, how much
            //cash was bet, and which dog he bet on ("Joe bets 8 on dog
            //#4"). If the amount is zero, no bet was placed.
            //("Joe hasn't placed a bet").

            //Just need to assemble a string or message from different bits of data here
        }

        public int PayOut(int Winner)
        {
            //The parameter is the winner of the race. If the dog won,
            //return the amount bet. Otherwise, return the negative of
            //the amount bet.
        }
    }
}
