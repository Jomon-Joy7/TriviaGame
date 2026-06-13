namespace TriviaGame
{
    partial class TriviaChallenge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.subTitleLbl = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.howToPlayBtn = new System.Windows.Forms.Button();
            this.submitAnswerBtn = new System.Windows.Forms.Button();
            this.nextQuestionBtn = new System.Windows.Forms.Button();
            this.questionTitleLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.scoreTitleLbl = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.questionNumberLbl = new System.Windows.Forms.Label();
            this.resultLst = new System.Windows.Forms.ListBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.answerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(235, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(462, 49);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "TRIVIA CHALLENGE";
            // 
            // subTitleLbl
            // 
            this.subTitleLbl.AutoSize = true;
            this.subTitleLbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLbl.Location = new System.Drawing.Point(295, 58);
            this.subTitleLbl.Name = "subTitleLbl";
            this.subTitleLbl.Size = new System.Drawing.Size(334, 20);
            this.subTitleLbl.TabIndex = 1;
            this.subTitleLbl.Text = "----Test Your Knowledge and have Fun!----";
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(332, 126);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(118, 23);
            this.startGameBtn.TabIndex = 4;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            // 
            // howToPlayBtn
            // 
            this.howToPlayBtn.Location = new System.Drawing.Point(493, 126);
            this.howToPlayBtn.Name = "howToPlayBtn";
            this.howToPlayBtn.Size = new System.Drawing.Size(117, 23);
            this.howToPlayBtn.TabIndex = 5;
            this.howToPlayBtn.Text = "How To Play?";
            this.howToPlayBtn.UseVisualStyleBackColor = true;
            // 
            // submitAnswerBtn
            // 
            this.submitAnswerBtn.Location = new System.Drawing.Point(33, 519);
            this.submitAnswerBtn.Name = "submitAnswerBtn";
            this.submitAnswerBtn.Size = new System.Drawing.Size(135, 42);
            this.submitAnswerBtn.TabIndex = 11;
            this.submitAnswerBtn.Text = "Submit Answer";
            this.submitAnswerBtn.UseVisualStyleBackColor = true;
            this.submitAnswerBtn.Click += new System.EventHandler(this.submitAnswerBtn_Click);
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.Location = new System.Drawing.Point(322, 519);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(128, 42);
            this.nextQuestionBtn.TabIndex = 12;
            this.nextQuestionBtn.Text = "Next Question";
            this.nextQuestionBtn.UseVisualStyleBackColor = true;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // questionTitleLbl
            // 
            this.questionTitleLbl.AutoSize = true;
            this.questionTitleLbl.Location = new System.Drawing.Point(31, 189);
            this.questionTitleLbl.Name = "questionTitleLbl";
            this.questionTitleLbl.Size = new System.Drawing.Size(63, 16);
            this.questionTitleLbl.TabIndex = 13;
            this.questionTitleLbl.Text = "Question:";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(30, 232);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(158, 16);
            this.questionLbl.TabIndex = 14;
            this.questionLbl.Text = "Question will appear here";
            // 
            // scoreTitleLbl
            // 
            this.scoreTitleLbl.AutoSize = true;
            this.scoreTitleLbl.Location = new System.Drawing.Point(852, 30);
            this.scoreTitleLbl.Name = "scoreTitleLbl";
            this.scoreTitleLbl.Size = new System.Drawing.Size(46, 16);
            this.scoreTitleLbl.TabIndex = 15;
            this.scoreTitleLbl.Text = "Score:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(919, 30);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(14, 16);
            this.scoreLbl.TabIndex = 16;
            this.scoreLbl.Text = "0";
            // 
            // questionNumberLbl
            // 
            this.questionNumberLbl.AutoSize = true;
            this.questionNumberLbl.Location = new System.Drawing.Point(614, 519);
            this.questionNumberLbl.Name = "questionNumberLbl";
            this.questionNumberLbl.Size = new System.Drawing.Size(85, 16);
            this.questionNumberLbl.TabIndex = 17;
            this.questionNumberLbl.Text = "Question1/10";
            // 
            // resultLst
            // 
            this.resultLst.FormattingEnabled = true;
            this.resultLst.ItemHeight = 16;
            this.resultLst.Location = new System.Drawing.Point(855, 111);
            this.resultLst.Name = "resultLst";
            this.resultLst.Size = new System.Drawing.Size(120, 116);
            this.resultLst.TabIndex = 18;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(852, 80);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(52, 16);
            this.resultLbl.TabIndex = 19;
            this.resultLbl.Text = "Results";
            // 
            // answerTxt
            // 
            this.answerTxt.Location = new System.Drawing.Point(33, 340);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(327, 22);
            this.answerTxt.TabIndex = 20;
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(34, 284);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(114, 16);
            this.answerLbl.TabIndex = 21;
            this.answerLbl.Text = "Type your answer";
            // 
            // TriviaChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 615);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.answerTxt);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.resultLst);
            this.Controls.Add(this.questionNumberLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.scoreTitleLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.questionTitleLbl);
            this.Controls.Add(this.nextQuestionBtn);
            this.Controls.Add(this.submitAnswerBtn);
            this.Controls.Add(this.howToPlayBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.subTitleLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "TriviaChallenge";
            this.Text = "Tivia Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label subTitleLbl;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button howToPlayBtn;
        private System.Windows.Forms.Button submitAnswerBtn;
        private System.Windows.Forms.Button nextQuestionBtn;
        private System.Windows.Forms.Label questionTitleLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label scoreTitleLbl;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label questionNumberLbl;
        private System.Windows.Forms.ListBox resultLst;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox answerTxt;
        private System.Windows.Forms.Label answerLbl;
    }
}

