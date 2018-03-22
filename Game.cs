//Game class within GameLibrary namespace
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GameLibrary
{
    //Game class
    public class Game
    {       
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        
        //constructor
        public Game(string team1, string team2, int team1score, int team2score)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = team1score;
            this.Team2Score = team2score;

        }

        public Game()
        {

        }
        //toString method overridden 
        public override string ToString()
        {
            return this.Team1 + " " + this.Team1Score + " " + this.Team2 + " " + this.Team2Score;
        }

    }
  
}
