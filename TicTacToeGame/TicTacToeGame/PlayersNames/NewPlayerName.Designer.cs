namespace TicTacToeGame.PlayersNames
{
    partial class NewPlayerName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayerName));
            this.ChangeNameBackGround = new System.Windows.Forms.Label();
            this.TitlePlayer1 = new System.Windows.Forms.Label();
            this.TitlePlayer2 = new System.Windows.Forms.Label();
            this.TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectPlayer = new System.Windows.Forms.ComboBox();
            this.TitleFirstPlayer = new System.Windows.Forms.Label();
            this.TitleWriteNames = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.IconPlayer1 = new System.Windows.Forms.Label();
            this.IconPlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeNameBackGround
            // 
            this.ChangeNameBackGround.BackColor = System.Drawing.Color.OrangeRed;
            this.ChangeNameBackGround.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChangeNameBackGround.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold);
            this.ChangeNameBackGround.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChangeNameBackGround.Location = new System.Drawing.Point(10, 10);
            this.ChangeNameBackGround.Name = "ChangeNameBackGround";
            this.ChangeNameBackGround.Size = new System.Drawing.Size(765, 185);
            this.ChangeNameBackGround.TabIndex = 1017;
            this.ChangeNameBackGround.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitlePlayer1
            // 
            this.TitlePlayer1.BackColor = System.Drawing.Color.OrangeRed;
            this.TitlePlayer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitlePlayer1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.TitlePlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitlePlayer1.Location = new System.Drawing.Point(316, 18);
            this.TitlePlayer1.Name = "TitlePlayer1";
            this.TitlePlayer1.Size = new System.Drawing.Size(178, 56);
            this.TitlePlayer1.TabIndex = 1018;
            this.TitlePlayer1.Text = "Player 1 Name:";
            this.TitlePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitlePlayer2
            // 
            this.TitlePlayer2.BackColor = System.Drawing.Color.OrangeRed;
            this.TitlePlayer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitlePlayer2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.TitlePlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitlePlayer2.Location = new System.Drawing.Point(316, 117);
            this.TitlePlayer2.Name = "TitlePlayer2";
            this.TitlePlayer2.Size = new System.Drawing.Size(178, 56);
            this.TitlePlayer2.TabIndex = 1019;
            this.TitlePlayer2.Text = "Player 2 Name:";
            this.TitlePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPlayer1
            // 
            this.TextBoxPlayer1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.TextBoxPlayer1.Location = new System.Drawing.Point(500, 30);
            this.TextBoxPlayer1.MaxLength = 10;
            this.TextBoxPlayer1.Multiline = true;
            this.TextBoxPlayer1.Name = "TextBoxPlayer1";
            this.TextBoxPlayer1.Size = new System.Drawing.Size(174, 35);
            this.TextBoxPlayer1.TabIndex = 1020;
            this.TextBoxPlayer1.Text = "Player 1";
            this.TextBoxPlayer1.TextChanged += new System.EventHandler(this.TextBoxPlayer1_TextChanged);
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.TextBoxPlayer2.Location = new System.Drawing.Point(500, 130);
            this.TextBoxPlayer2.MaxLength = 10;
            this.TextBoxPlayer2.Multiline = true;
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(174, 35);
            this.TextBoxPlayer2.TabIndex = 1021;
            this.TextBoxPlayer2.Text = "Player 2";
            this.TextBoxPlayer2.TextChanged += new System.EventHandler(this.TextBoxPlayer2_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Rockwell", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(315, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 90);
            this.label4.TabIndex = 1022;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectPlayer
            // 
            this.SelectPlayer.DisplayMember = "1,2";
            this.SelectPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectPlayer.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.SelectPlayer.FormattingEnabled = true;
            this.SelectPlayer.Items.AddRange(new object[] {
            "Player 1",
            "Player 2"});
            this.SelectPlayer.Location = new System.Drawing.Point(500, 224);
            this.SelectPlayer.Name = "SelectPlayer";
            this.SelectPlayer.Size = new System.Drawing.Size(254, 32);
            this.SelectPlayer.TabIndex = 1023;
            this.SelectPlayer.Text = "Select";
            this.SelectPlayer.SelectedIndexChanged += new System.EventHandler(this.SelectPlayer_SelectedIndexChanged);
            this.SelectPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectPlayer_KeyPress);
            // 
            // TitleFirstPlayer
            // 
            this.TitleFirstPlayer.BackColor = System.Drawing.Color.OrangeRed;
            this.TitleFirstPlayer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleFirstPlayer.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold);
            this.TitleFirstPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleFirstPlayer.Location = new System.Drawing.Point(320, 224);
            this.TitleFirstPlayer.Name = "TitleFirstPlayer";
            this.TitleFirstPlayer.Size = new System.Drawing.Size(174, 56);
            this.TitleFirstPlayer.TabIndex = 1024;
            this.TitleFirstPlayer.Text = "Select First Player";
            this.TitleFirstPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleWriteNames
            // 
            this.TitleWriteNames.BackColor = System.Drawing.Color.OrangeRed;
            this.TitleWriteNames.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleWriteNames.Font = new System.Drawing.Font("Rockwell", 25F, System.Drawing.FontStyle.Bold);
            this.TitleWriteNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleWriteNames.Location = new System.Drawing.Point(29, 18);
            this.TitleWriteNames.Name = "TitleWriteNames";
            this.TitleWriteNames.Size = new System.Drawing.Size(233, 156);
            this.TitleWriteNames.TabIndex = 1025;
            this.TitleWriteNames.Text = "Write a New Name for Players";
            this.TitleWriteNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.HomeButton.Location = new System.Drawing.Point(646, 408);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(126, 42);
            this.HomeButton.TabIndex = 1027;
            this.HomeButton.Text = "Back";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPlay.Location = new System.Drawing.Point(10, 210);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(298, 240);
            this.ButtonPlay.TabIndex = 1028;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // IconPlayer1
            // 
            this.IconPlayer1.BackColor = System.Drawing.Color.OrangeRed;
            this.IconPlayer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IconPlayer1.Font = new System.Drawing.Font("Bradley Hand ITC", 45F, System.Drawing.FontStyle.Bold);
            this.IconPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconPlayer1.Location = new System.Drawing.Point(680, 11);
            this.IconPlayer1.Name = "IconPlayer1";
            this.IconPlayer1.Size = new System.Drawing.Size(92, 56);
            this.IconPlayer1.TabIndex = 1029;
            this.IconPlayer1.Text = "X";
            this.IconPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconPlayer2
            // 
            this.IconPlayer2.BackColor = System.Drawing.Color.OrangeRed;
            this.IconPlayer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IconPlayer2.Font = new System.Drawing.Font("Bradley Hand ITC", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconPlayer2.Location = new System.Drawing.Point(680, 110);
            this.IconPlayer2.Name = "IconPlayer2";
            this.IconPlayer2.Size = new System.Drawing.Size(92, 56);
            this.IconPlayer2.TabIndex = 1030;
            this.IconPlayer2.Text = "O";
            this.IconPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewPlayerName
            // 
            this.AcceptButton = this.ButtonPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.HomeButton;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.IconPlayer2);
            this.Controls.Add(this.IconPlayer1);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.TitleWriteNames);
            this.Controls.Add(this.TitleFirstPlayer);
            this.Controls.Add(this.SelectPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.TextBoxPlayer1);
            this.Controls.Add(this.TitlePlayer2);
            this.Controls.Add(this.TitlePlayer1);
            this.Controls.Add(this.ChangeNameBackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewPlayerName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Players Name";
            this.Load += new System.EventHandler(this.NewPlayerName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ChangeNameBackGround;
        private System.Windows.Forms.Label TitlePlayer1;
        private System.Windows.Forms.Label TitlePlayer2;
        private System.Windows.Forms.TextBox TextBoxPlayer1;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectPlayer;
        private System.Windows.Forms.Label TitleWriteNames;
        private System.Windows.Forms.Label TitleFirstPlayer;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Label IconPlayer1;
        private System.Windows.Forms.Label IconPlayer2;
    }
}