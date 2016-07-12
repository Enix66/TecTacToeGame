namespace TicTacToeGame.Game.TwoPlayers
{
    partial class TwoPlayersGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoPlayersGame));
            this.TicTacToeTitle = new System.Windows.Forms.Label();
            this.GameBackGroundImage = new System.Windows.Forms.PictureBox();
            this.Pos02 = new System.Windows.Forms.Button();
            this.Pos12 = new System.Windows.Forms.Button();
            this.Pos21 = new System.Windows.Forms.Button();
            this.Pos11 = new System.Windows.Forms.Button();
            this.Pos01 = new System.Windows.Forms.Button();
            this.Pos00 = new System.Windows.Forms.Button();
            this.Pos10 = new System.Windows.Forms.Button();
            this.Pos20 = new System.Windows.Forms.Button();
            this.ScoresBackGround = new System.Windows.Forms.Label();
            this.Pos22 = new System.Windows.Forms.Button();
            this.TitlePlayerTurn = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.TextBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ScoreTitle = new System.Windows.Forms.Label();
            this.Player1WinsTitle = new System.Windows.Forms.Label();
            this.Player1Wins = new System.Windows.Forms.TextBox();
            this.Player2Wins = new System.Windows.Forms.TextBox();
            this.Player2WinsTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DrawsGamesTitle = new System.Windows.Forms.Label();
            this.DrawsGames = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackGroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TicTacToeTitle
            // 
            this.TicTacToeTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.TicTacToeTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TicTacToeTitle.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold);
            this.TicTacToeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TicTacToeTitle.Location = new System.Drawing.Point(489, 9);
            this.TicTacToeTitle.Name = "TicTacToeTitle";
            this.TicTacToeTitle.Size = new System.Drawing.Size(300, 59);
            this.TicTacToeTitle.TabIndex = 1016;
            this.TicTacToeTitle.Text = "Tic Tac Toe";
            this.TicTacToeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameBackGroundImage
            // 
            this.GameBackGroundImage.Image = ((System.Drawing.Image)(resources.GetObject("GameBackGroundImage.Image")));
            this.GameBackGroundImage.Location = new System.Drawing.Point(39, 47);
            this.GameBackGroundImage.Name = "GameBackGroundImage";
            this.GameBackGroundImage.Size = new System.Drawing.Size(402, 354);
            this.GameBackGroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameBackGroundImage.TabIndex = 1017;
            this.GameBackGroundImage.TabStop = false;
            // 
            // Pos02
            // 
            this.Pos02.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos02.FlatAppearance.BorderSize = 0;
            this.Pos02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos02.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos02.Location = new System.Drawing.Point(300, 47);
            this.Pos02.Name = "Pos02";
            this.Pos02.Size = new System.Drawing.Size(141, 100);
            this.Pos02.TabIndex = 1023;
            this.Pos02.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos02.UseVisualStyleBackColor = false;
            this.Pos02.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos12
            // 
            this.Pos12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos12.FlatAppearance.BorderSize = 0;
            this.Pos12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos12.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos12.Location = new System.Drawing.Point(300, 157);
            this.Pos12.Name = "Pos12";
            this.Pos12.Size = new System.Drawing.Size(141, 100);
            this.Pos12.TabIndex = 1024;
            this.Pos12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos12.UseVisualStyleBackColor = false;
            this.Pos12.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos21
            // 
            this.Pos21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos21.FlatAppearance.BorderSize = 0;
            this.Pos21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos21.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos21.Location = new System.Drawing.Point(186, 269);
            this.Pos21.Name = "Pos21";
            this.Pos21.Size = new System.Drawing.Size(108, 100);
            this.Pos21.TabIndex = 1026;
            this.Pos21.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos21.UseVisualStyleBackColor = false;
            this.Pos21.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos11
            // 
            this.Pos11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos11.FlatAppearance.BorderSize = 0;
            this.Pos11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos11.Font = new System.Drawing.Font("Bradley Hand ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos11.Location = new System.Drawing.Point(186, 157);
            this.Pos11.Name = "Pos11";
            this.Pos11.Size = new System.Drawing.Size(108, 100);
            this.Pos11.TabIndex = 1027;
            this.Pos11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos11.UseVisualStyleBackColor = false;
            this.Pos11.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos01
            // 
            this.Pos01.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos01.FlatAppearance.BorderSize = 0;
            this.Pos01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos01.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos01.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos01.Location = new System.Drawing.Point(186, 47);
            this.Pos01.Name = "Pos01";
            this.Pos01.Size = new System.Drawing.Size(108, 100);
            this.Pos01.TabIndex = 1028;
            this.Pos01.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos01.UseVisualStyleBackColor = false;
            this.Pos01.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos00
            // 
            this.Pos00.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos00.FlatAppearance.BorderSize = 0;
            this.Pos00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos00.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos00.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos00.Location = new System.Drawing.Point(39, 47);
            this.Pos00.Name = "Pos00";
            this.Pos00.Size = new System.Drawing.Size(141, 100);
            this.Pos00.TabIndex = 1029;
            this.Pos00.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos00.UseVisualStyleBackColor = false;
            this.Pos00.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos10
            // 
            this.Pos10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos10.FlatAppearance.BorderSize = 0;
            this.Pos10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos10.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos10.Location = new System.Drawing.Point(39, 157);
            this.Pos10.Name = "Pos10";
            this.Pos10.Size = new System.Drawing.Size(141, 100);
            this.Pos10.TabIndex = 1030;
            this.Pos10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos10.UseVisualStyleBackColor = false;
            this.Pos10.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // Pos20
            // 
            this.Pos20.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos20.FlatAppearance.BorderSize = 0;
            this.Pos20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos20.Font = new System.Drawing.Font("Bradley Hand ITC", 72F);
            this.Pos20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos20.Location = new System.Drawing.Point(39, 269);
            this.Pos20.Name = "Pos20";
            this.Pos20.Size = new System.Drawing.Size(141, 100);
            this.Pos20.TabIndex = 1031;
            this.Pos20.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos20.UseVisualStyleBackColor = false;
            this.Pos20.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // ScoresBackGround
            // 
            this.ScoresBackGround.BackColor = System.Drawing.Color.DodgerBlue;
            this.ScoresBackGround.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ScoresBackGround.Location = new System.Drawing.Point(489, 78);
            this.ScoresBackGround.Name = "ScoresBackGround";
            this.ScoresBackGround.Size = new System.Drawing.Size(300, 69);
            this.ScoresBackGround.TabIndex = 1032;
            // 
            // Pos22
            // 
            this.Pos22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pos22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pos22.FlatAppearance.BorderSize = 0;
            this.Pos22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pos22.Font = new System.Drawing.Font("Bradley Hand ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pos22.Location = new System.Drawing.Point(300, 269);
            this.Pos22.Name = "Pos22";
            this.Pos22.Size = new System.Drawing.Size(141, 100);
            this.Pos22.TabIndex = 1033;
            this.Pos22.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pos22.UseVisualStyleBackColor = false;
            this.Pos22.Click += new System.EventHandler(this.ButtonActionPlayer);
            // 
            // TitlePlayerTurn
            // 
            this.TitlePlayerTurn.BackColor = System.Drawing.Color.DodgerBlue;
            this.TitlePlayerTurn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitlePlayerTurn.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.TitlePlayerTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitlePlayerTurn.Location = new System.Drawing.Point(512, 97);
            this.TitlePlayerTurn.Name = "TitlePlayerTurn";
            this.TitlePlayerTurn.Size = new System.Drawing.Size(138, 32);
            this.TitlePlayerTurn.TabIndex = 1034;
            this.TitlePlayerTurn.Text = "Player Turn:";
            this.TitlePlayerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.PlayerTurn.Location = new System.Drawing.Point(656, 95);
            this.PlayerTurn.Multiline = true;
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(123, 35);
            this.PlayerTurn.TabIndex = 1035;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeButton.Location = new System.Drawing.Point(12, 408);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(126, 42);
            this.HomeButton.TabIndex = 1036;
            this.HomeButton.Text = "Back";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ScoreTitle
            // 
            this.ScoreTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.ScoreTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ScoreTitle.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Bold);
            this.ScoreTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreTitle.Location = new System.Drawing.Point(491, 169);
            this.ScoreTitle.Name = "ScoreTitle";
            this.ScoreTitle.Size = new System.Drawing.Size(290, 46);
            this.ScoreTitle.TabIndex = 1037;
            this.ScoreTitle.Text = "Scores";
            this.ScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1WinsTitle
            // 
            this.Player1WinsTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.Player1WinsTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Player1WinsTitle.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.Player1WinsTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player1WinsTitle.Location = new System.Drawing.Point(510, 225);
            this.Player1WinsTitle.Name = "Player1WinsTitle";
            this.Player1WinsTitle.Size = new System.Drawing.Size(123, 60);
            this.Player1WinsTitle.TabIndex = 1038;
            this.Player1WinsTitle.Text = "Player 1 Wins:";
            this.Player1WinsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1Wins
            // 
            this.Player1Wins.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.Player1Wins.Location = new System.Drawing.Point(510, 288);
            this.Player1Wins.Multiline = true;
            this.Player1Wins.Name = "Player1Wins";
            this.Player1Wins.Size = new System.Drawing.Size(123, 35);
            this.Player1Wins.TabIndex = 1040;
            // 
            // Player2Wins
            // 
            this.Player2Wins.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.Player2Wins.Location = new System.Drawing.Point(649, 288);
            this.Player2Wins.Multiline = true;
            this.Player2Wins.Name = "Player2Wins";
            this.Player2Wins.Size = new System.Drawing.Size(123, 35);
            this.Player2Wins.TabIndex = 1042;
            // 
            // Player2WinsTitle
            // 
            this.Player2WinsTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.Player2WinsTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Player2WinsTitle.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.Player2WinsTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player2WinsTitle.Location = new System.Drawing.Point(649, 225);
            this.Player2WinsTitle.Name = "Player2WinsTitle";
            this.Player2WinsTitle.Size = new System.Drawing.Size(123, 60);
            this.Player2WinsTitle.TabIndex = 1041;
            this.Player2WinsTitle.Text = "Player 2 Wins:";
            this.Player2WinsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(489, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 294);
            this.label3.TabIndex = 1043;
            // 
            // DrawsGamesTitle
            // 
            this.DrawsGamesTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.DrawsGamesTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DrawsGamesTitle.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.DrawsGamesTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrawsGamesTitle.Location = new System.Drawing.Point(494, 366);
            this.DrawsGamesTitle.Name = "DrawsGamesTitle";
            this.DrawsGamesTitle.Size = new System.Drawing.Size(158, 35);
            this.DrawsGamesTitle.TabIndex = 1044;
            this.DrawsGamesTitle.Text = "Draws Games:";
            this.DrawsGamesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawsGames
            // 
            this.DrawsGames.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.DrawsGames.Location = new System.Drawing.Point(656, 366);
            this.DrawsGames.Multiline = true;
            this.DrawsGames.Name = "DrawsGames";
            this.DrawsGames.Size = new System.Drawing.Size(123, 35);
            this.DrawsGames.TabIndex = 1045;
            // 
            // TwoPlayersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.HomeButton;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.DrawsGames);
            this.Controls.Add(this.DrawsGamesTitle);
            this.Controls.Add(this.Player2Wins);
            this.Controls.Add(this.Player2WinsTitle);
            this.Controls.Add(this.Player1Wins);
            this.Controls.Add(this.Player1WinsTitle);
            this.Controls.Add(this.ScoreTitle);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.TitlePlayerTurn);
            this.Controls.Add(this.Pos22);
            this.Controls.Add(this.ScoresBackGround);
            this.Controls.Add(this.Pos20);
            this.Controls.Add(this.Pos10);
            this.Controls.Add(this.Pos00);
            this.Controls.Add(this.Pos01);
            this.Controls.Add(this.Pos11);
            this.Controls.Add(this.Pos21);
            this.Controls.Add(this.Pos12);
            this.Controls.Add(this.Pos02);
            this.Controls.Add(this.GameBackGroundImage);
            this.Controls.Add(this.TicTacToeTitle);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TwoPlayersGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Two Players Game";
            this.Load += new System.EventHandler(this.TwoPlayersGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBackGroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicTacToeTitle;
        private System.Windows.Forms.PictureBox GameBackGroundImage;
        private System.Windows.Forms.Button Pos02;
        private System.Windows.Forms.Button Pos12;
        private System.Windows.Forms.Button Pos21;
        private System.Windows.Forms.Button Pos11;
        private System.Windows.Forms.Button Pos01;
        private System.Windows.Forms.Button Pos00;
        private System.Windows.Forms.Button Pos10;
        private System.Windows.Forms.Button Pos20;
        private System.Windows.Forms.Label ScoresBackGround;
        private System.Windows.Forms.Button Pos22;
        private System.Windows.Forms.Label TitlePlayerTurn;
        private System.Windows.Forms.TextBox PlayerTurn;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label ScoreTitle;
        private System.Windows.Forms.Label Player1WinsTitle;
        private System.Windows.Forms.TextBox Player1Wins;
        private System.Windows.Forms.TextBox Player2Wins;
        private System.Windows.Forms.Label Player2WinsTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DrawsGamesTitle;
        private System.Windows.Forms.TextBox DrawsGames;
    }
}