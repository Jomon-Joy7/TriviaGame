//Jomon Joy
//This class controls the trivia game, displays questions,
//check answers and keep track of score.
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


            questions[0] = new TriviaQuestion("1. What is the capital of Canada?", "Ottawa", "Geography" );
            questions[1] = new TriviaQuestion("2. What is 15 x 4?", "60", "Math");
            questions[2] = new TriviaQuestion("3. Which planet is known as the Red Planet?", "Mars", "Science");
            questions[3] = new TriviaQuestion("4. How many players are on a soccer team on the field?", "11", "Sports");
            questions[4] = new TriviaQuestion("5. What is the largest ocean on Earth?", "Pacific", "Geography");
            questions[5] = new TriviaQuestion("6. What is the square root of 81?", "9", "Math");
            questions[6] = new TriviaQuestion("7. Which animal is known as the King of the Jungle?", "Lion", "Animal");
            questions[7] = new TriviaQuestion("8. What does CPU stand for?", "Central Processing Unit", "Technology");
            questions[8] = new TriviaQuestion("9. What color do you get when you mix red and blue?", "Purple", "Fun Facts");
            questions[9] = new TriviaQuestion("10. How many continents are there on Earth?", "7", "Geography");

            for (int i = 0; i < questions.Length; i++)
            {
                resultLst.Items.Add("Question " + (i+1) + " - " + questions[i].Result);
            }

            questionLbl.Text = questions[current].Question;
            categoryResultLbl.Text = questions[current].Category;
            ShowQuestionNumber();
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
            previousQuestionBtn.Visible = visibility;
            nextQuestionBtn.Visible = visibility;
            questionNumberLbl.Visible = visibility;
            scoreLbl.Visible = visibility;
            resultLst.Visible = visibility;
            resultLbl.Visible = visibility;
            scoreTitleLbl.Visible = visibility;
        }

        private void ShowQuestionNumber()
        {
            questionNumberLbl.Text = "Question: " + (current + 1).ToString() + "/" + questions.Length.ToString();
        }


        private void startGameBtn_Click(object sender, EventArgs e)
        {
            
            if (playerNameTbx.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            player = new Player(playerNameTbx.Text);

            ChangeVisibility(true);
        }

        private void howToPlayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play\n\n" +
                "1. Enter your name.\n" +
                "2. Click Start.\n" + "3. Answer each trivia question.\n" +
                "4. Gain 1 point for every correct answer.\n" +
                "5. Try to get 10/10!\n\n" + 
                "I like trivia games because they are fun and test knowledge.");
        }


        private void submitAnswerBtn_Click(object sender, EventArgs e)
        {
            string answer = answerTxt.Text;
            if(answer.Trim() == "")
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
                MessageBox.Show("Quiz Completed!\n\n" + "Player: " + player.Name + "\nScore: " + player.Score + "/" + questions.Length);

                if (player.Score >= 8)
                {
                    MessageBox.Show("Excellent! You Nailed it");
                }
                else if (player.Score >= 5)
                {
                    MessageBox.Show("Good Job!");
                }
                else
                {
                    MessageBox.Show("Give it other short!");
                }
            }

        }
        private void previousQuestionBtn_Click(object sender, EventArgs e)
        {

            if (current > 0)
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
