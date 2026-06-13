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

        public string Category { get; set; }   //auto implemented 

        public string Question
        {
            get { return question; }  //non- auto implementated property
            set { question = value; }
        }

        public string Answer
        {
            get { return answer; }     //====
            set {  answer = value; }
        }

        public TriviaQuestion(string question, string answer, string category)
        {
            Question = question;
            Answer = answer;
            Category = category;
        }

    }
}
