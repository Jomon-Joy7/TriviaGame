//Player Class
//This class stores player information like name and scores 
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


        public string Name    //non - auto implemented properties with validation logic
        { 
            get { return name; } 
            set 
            {
                if (value.Trim() != "")
                {
                    name = value;
                }
            } 
        }

        public int Score    //non - auto implemented property 
        {
            get { return score; }
            set { score = value;}
        }

        public Player(string name)   //constructor1
        {
            Name = name;
            Score = 0;
        }
    }
}
