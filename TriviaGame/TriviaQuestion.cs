//Trivia Question class
//This class stores the question, answer,category and result for
//each trivia questions 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    internal class TriviaQuestion
    {
        private string question;
        private string answer;

        public string Category { get; set; }   //auto implemented property
        public int Result { get; set; }       //auto implemented property

        public string Question          //non - auto implementated property
        {
            get { return question; }  
            set { question = value; }
        }

        public string Answer        //non - auto implemented property
        {
            get { return answer; }     
            set {  answer = value; }
        }
       

        public TriviaQuestion(string question, string answer, string category)   //constructor2
        {
            Question = question;
            Answer = answer;
            Category = category;
            Result = 0;
           
        }

    }
}
