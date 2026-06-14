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
        string[] options = new string[4];
        private string answer;

        public string Category { get; set; }   //auto implemented property
        public int Result { get; set; }

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
        public string[] Options
        {
            get { return options; }
            set {  options = value; }

        } 

        public TriviaQuestion(string question, string answer, string category, string[] options)
        {
            Question = question;
            Answer = answer;
            Category = category;
            Result = 0;
            Options = options;
        }

    }
}
