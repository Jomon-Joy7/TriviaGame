using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    public class Player
    {
        private string name;
        private int score;


        public string Name    //property
        { 
            get { return name; } 
            set { name = value; } 
        }

        public int Score    //property 
        {
            get { return score; }
            set { score = value;}
        }

        public Player(string name)   //constructor
        {
            Name = name;
            Score = 0;
        }
    }
}
