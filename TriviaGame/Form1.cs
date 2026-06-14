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
        private TriviaQuestion[] questions = new TriviaQuestion[10];
        private int current = 0;
        Player player;
       
        public TriviaChallenge()
        {
            InitializeComponent();
            ChangeVisibility(false);

            player = new Player("Jomon");

            questions[0] = new TriviaQuestion("What is the capital of Canada?", "Ottawa", "Geography", new string[] { "Ottawa", "something", "something", "something" });
            questions[1] = new TriviaQuestion("What is 15 x 4?", "60", "Math", new string[] { "Ottawa", "something", "something", "something" });
            questions[2] = new TriviaQuestion("Which planet is known as the Red Planet?", "Mars", "Science", new string[] { "Ottawa", "something", "something", "something" }   );
            questions[3] = new TriviaQuestion("How many players are on a soccer team on the field?", "11", "Sports", new string[] { "Ottawa", "something", "something", "something" });
            questions[4] = new TriviaQuestion("What is the largest ocean on Earth?", "Pacific", "Geography", new string[] { "Ottawa", "something", "something", "something" });
            questions[5] = new TriviaQuestion("What is the square root of 81?", "9", "Math", new string[] { "Ottawa", "something", "something", "something" });
            questions[6] = new TriviaQuestion("Which animal is known as the King of the Jungle?", "Lion", "Animal", new string[] { "Ottawa", "something", "something", "something" });
            questions[7] = new TriviaQuestion("What does CPU stand for?", "Central Processing Unit", "Technology", new string[] { "Ottawa", "something", "something", "something" });
            questions[8] = new TriviaQuestion("What color do you get when you mix red and blue?", "Purple", "Fun Facts", new string[] { "Ottawa", "something", "something", "something" });
            questions[9] = new TriviaQuestion("How many continents are there on Earth?", "7", "Geography", new string[] { "Ottawa", "something", "something", "something" });

            for (int i = 0; i < questions.Length; i++)
            {
                resultLst.Items.Add("Question " + (i+1) + " - " + questions[i].Result);
            }

            questionLbl.Text = questions[current].Question;
            categoryResultLbl.Text = questions[current].Category;
            ShowQuestionNumber();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            ChangeVisibility(true);

        }

        private void ChangeVisibility(bool visibility )
        {
            categoryLbl.Visible = visibility;
            categoryResultLbl.Visible = visibility;
            questionLbl.Visible = visibility;
            questionTitleLbl.Visible = visibility;
            answerLbl.Visible = visibility;
            answerTxt.Visible = visibility;
            submitAnswerBtn.Visible = visibility;
            nextQuestionBtn.Visible = visibility;
            questionNumberLbl.Visible = visibility;
            scoreLbl.Visible = visibility;
            resultLst.Visible = visibility;
            resultLbl.Visible = visibility;
            scoreTitleLbl.Visible = visibility;
        }

        private void submitAnswerBtn_Click(object sender, EventArgs e)
        {
            string answer = answerTxt.Text;
            if(answer == "")
            {
                MessageBox.Show("Please enter your answer");

            }
            else
            {
                if(answer.Trim().ToLower() == questions[current].Answer.ToLower())
                {
                    MessageBox.Show("Your answer is correct");
                    player.Score++;
                    scoreLbl.Text = player.Score.ToString();
                    questions[current].Result = 1;
                    resultLst.Items[current] = "Question " + (current + 1) + " - " + questions[current].Result;
                }
                else
                {
                    MessageBox.Show("Your answer is wrong");
                }
                answerTxt.Clear();
            }

        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            if (current < questions.Length - 1)
            {
                current++;
                questionLbl.Text = questions[current].Question;
                categoryResultLbl.Text = questions[current].Category;
                ShowQuestionNumber();
            }
            else
            {
                MessageBox.Show("Quiz Completed!");
            }

        }

       private void ShowQuestionNumber()
        {
            questionNumberLbl.Text = "Question: " + (current + 1).ToString() + "/" + questions.Length.ToString();
        }

        private void howToPlayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("follow the question"+ "\nfollow");
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (current>0)
            {
                current--;
                questionLbl.Text = questions[current].Question;
                categoryResultLbl.Text = questions[current].Category;
                ShowQuestionNumber();
            }
            else
            {
                MessageBox.Show("You can't go back!");
            }
        }
    }
}
