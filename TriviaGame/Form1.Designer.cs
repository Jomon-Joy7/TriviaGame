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
            this.answerLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.categoryResultLbl = new System.Windows.Forms.Label();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.previousQuestionBtn = new System.Windows.Forms.Button();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.playerNameTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(235, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(430, 60);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "TRIVIA CHALLENGE";
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.startGameBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.Location = new System.Drawing.Point(33, 154);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(118, 47);
            this.startGameBtn.TabIndex = 4;
            this.startGameBtn.Text = "Start";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // howToPlayBtn
            // 
            this.howToPlayBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.howToPlayBtn.Location = new System.Drawing.Point(210, 173);
            this.howToPlayBtn.Name = "howToPlayBtn";
            this.howToPlayBtn.Size = new System.Drawing.Size(133, 28);
            this.howToPlayBtn.TabIndex = 5;
            this.howToPlayBtn.Text = "How To Play?";
            this.howToPlayBtn.UseVisualStyleBackColor = true;
            this.howToPlayBtn.Click += new System.EventHandler(this.howToPlayBtn_Click);
            // 
            // submitAnswerBtn
            // 
            this.submitAnswerBtn.BackColor = System.Drawing.Color.LightBlue;
            this.submitAnswerBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnswerBtn.Location = new System.Drawing.Point(33, 519);
            this.submitAnswerBtn.Name = "submitAnswerBtn";
            this.submitAnswerBtn.Size = new System.Drawing.Size(160, 42);
            this.submitAnswerBtn.TabIndex = 11;
            this.submitAnswerBtn.Text = "Submit Answer";
            this.submitAnswerBtn.UseVisualStyleBackColor = false;
            this.submitAnswerBtn.Click += new System.EventHandler(this.submitAnswerBtn_Click);
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.BackColor = System.Drawing.Color.Orange;
            this.nextQuestionBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionBtn.Location = new System.Drawing.Point(450, 519);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(160, 42);
            this.nextQuestionBtn.TabIndex = 12;
            this.nextQuestionBtn.Text = "Next >>";
            this.nextQuestionBtn.UseVisualStyleBackColor = false;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // questionTitleLbl
            // 
            this.questionTitleLbl.AutoSize = true;
            this.questionTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTitleLbl.Location = new System.Drawing.Point(29, 233);
            this.questionTitleLbl.Name = "questionTitleLbl";
            this.questionTitleLbl.Size = new System.Drawing.Size(81, 20);
            this.questionTitleLbl.TabIndex = 13;
            this.questionTitleLbl.Text = "Question:";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(28, 301);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(353, 38);
            this.questionLbl.TabIndex = 14;
            this.questionLbl.Text = "Question will appear here";
            // 
            // scoreTitleLbl
            // 
            this.scoreTitleLbl.AutoSize = true;
            this.scoreTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLbl.Location = new System.Drawing.Point(796, 36);
            this.scoreTitleLbl.Name = "scoreTitleLbl";
            this.scoreTitleLbl.Size = new System.Drawing.Size(97, 20);
            this.scoreTitleLbl.TabIndex = 15;
            this.scoreTitleLbl.Text = "Your Score:";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(899, 36);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(18, 20);
            this.scoreLbl.TabIndex = 16;
            this.scoreLbl.Text = "0";
            // 
            // questionNumberLbl
            // 
            this.questionNumberLbl.AutoSize = true;
            this.questionNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLbl.Location = new System.Drawing.Point(672, 541);
            this.questionNumberLbl.Name = "questionNumberLbl";
            this.questionNumberLbl.Size = new System.Drawing.Size(108, 20);
            this.questionNumberLbl.TabIndex = 17;
            this.questionNumberLbl.Text = "Question1/10";
            // 
            // resultLst
            // 
            this.resultLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLst.FormattingEnabled = true;
            this.resultLst.ItemHeight = 18;
            this.resultLst.Location = new System.Drawing.Point(800, 115);
            this.resultLst.Name = "resultLst";
            this.resultLst.Size = new System.Drawing.Size(176, 220);
            this.resultLst.TabIndex = 18;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(796, 92);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(66, 20);
            this.resultLbl.TabIndex = 19;
            this.resultLbl.Text = "Results";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.Location = new System.Drawing.Point(29, 358);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(109, 20);
            this.answerLbl.TabIndex = 21;
            this.answerLbl.Text = "Your Answer:";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(29, 268);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(81, 20);
            this.categoryLbl.TabIndex = 22;
            this.categoryLbl.Text = "Category:";
            // 
            // categoryResultLbl
            // 
            this.categoryResultLbl.AutoSize = true;
            this.categoryResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryResultLbl.Location = new System.Drawing.Point(116, 268);
            this.categoryResultLbl.Name = "categoryResultLbl";
            this.categoryResultLbl.Size = new System.Drawing.Size(114, 20);
            this.categoryResultLbl.TabIndex = 23;
            this.categoryResultLbl.Text = "Category area";
            // 
            // answerTxt
            // 
            this.answerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxt.Location = new System.Drawing.Point(33, 393);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(327, 27);
            this.answerTxt.TabIndex = 20;
            // 
            // previousQuestionBtn
            // 
            this.previousQuestionBtn.BackColor = System.Drawing.Color.LightYellow;
            this.previousQuestionBtn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousQuestionBtn.Location = new System.Drawing.Point(254, 519);
            this.previousQuestionBtn.Name = "previousQuestionBtn";
            this.previousQuestionBtn.Size = new System.Drawing.Size(160, 42);
            this.previousQuestionBtn.TabIndex = 24;
            this.previousQuestionBtn.Text = "<< Previous";
            this.previousQuestionBtn.UseVisualStyleBackColor = false;
            this.previousQuestionBtn.Click += new System.EventHandler(this.previousQuestionBtn_Click);
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLbl.Location = new System.Drawing.Point(29, 92);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(110, 20);
            this.playerNameLbl.TabIndex = 25;
            this.playerNameLbl.Text = "Player Name:";
            // 
            // playerNameTbx
            // 
            this.playerNameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTbx.Location = new System.Drawing.Point(160, 85);
            this.playerNameTbx.Name = "playerNameTbx";
            this.playerNameTbx.Size = new System.Drawing.Size(254, 27);
            this.playerNameTbx.TabIndex = 26;
            // 
            // TriviaChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1014, 615);
            this.Controls.Add(this.playerNameTbx);
            this.Controls.Add(this.playerNameLbl);
            this.Controls.Add(this.previousQuestionBtn);
            this.Controls.Add(this.categoryResultLbl);
            this.Controls.Add(this.categoryLbl);
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
            this.Controls.Add(this.titleLbl);
            this.Name = "TriviaChallenge";
            this.Text = "Tivia Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
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
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label categoryResultLbl;
        private System.Windows.Forms.TextBox answerTxt;
        private System.Windows.Forms.Button previousQuestionBtn;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.TextBox playerNameTbx;
    }
}

