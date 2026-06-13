using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGame
{
    public partial class TriviaChallenge : Form
    {
        private TriviaQuestion[] questions = new TriviaQuestion[5];
        private int current = 0;
        Player player;
       
        public TriviaChallenge()
        {
            InitializeComponent();
            player = new Player("Jomon");
            questions[0] = new TriviaQuestion("What's the capital of Canada? 1", "Ottawa1");
            questions[1] = new TriviaQuestion("What's the capital of Canada? 2", "Ottawa2");
            questions[2] = new TriviaQuestion("What's the capital of Canada? 3", "Ottawa3");
            questions[3] = new TriviaQuestion("What's the capital of Canada? 4", "Ottawa4");
            questions[4] = new TriviaQuestion("What's the capital of Canada? 5", "Ottawa5");


            questionLbl.Text = questions[current].Question;
        }

        private void submitAnswerBtn_Click(object sender, EventArgs e)
        {
            string answer = answerTxt.Text;
            if(answer == "")
            {
                MessageBox.Show("please enter your answer");

            }
            else
            {
                if(answer.Trim().ToLower() == questions[current].Answer.ToLower())
                {
                    MessageBox.Show("Your answer is correct");
                    player.Score++;
                    scoreLbl.Text = player.Score.ToString();
                }
                else
                {
                    MessageBox.Show("your answer is wrong");
                }
                answerTxt.Clear();
            }

        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            current++;
            questionLbl.Text = questions[current].Question;
        }
    }
}
