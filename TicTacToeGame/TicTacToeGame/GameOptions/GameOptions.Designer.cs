namespace TicTacToeGame.GameOptions
{
    partial class GameOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOptions));
            this.TitleBackground = new System.Windows.Forms.Label();
            this.TwoPlayers = new System.Windows.Forms.Button();
            this.BotonPlay = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleBackground
            // 
            this.TitleBackground.BackColor = System.Drawing.Color.DodgerBlue;
            this.TitleBackground.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleBackground.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBackground.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleBackground.Location = new System.Drawing.Point(0, -1);
            this.TitleBackground.Name = "TitleBackground";
            this.TitleBackground.Size = new System.Drawing.Size(351, 464);
            this.TitleBackground.TabIndex = 1015;
            this.TitleBackground.Text = "Select a Game Mode";
            this.TitleBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoPlayers
            // 
            this.TwoPlayers.BackColor = System.Drawing.Color.OrangeRed;
            this.TwoPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoPlayers.FlatAppearance.BorderSize = 0;
            this.TwoPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPlayers.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TwoPlayers.Image = ((System.Drawing.Image)(resources.GetObject("TwoPlayers.Image")));
            this.TwoPlayers.Location = new System.Drawing.Point(435, 202);
            this.TwoPlayers.Name = "TwoPlayers";
            this.TwoPlayers.Size = new System.Drawing.Size(298, 85);
            this.TwoPlayers.TabIndex = 1017;
            this.TwoPlayers.Text = "Two Players";
            this.TwoPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TwoPlayers.UseVisualStyleBackColor = false;
            this.TwoPlayers.Click += new System.EventHandler(this.TwoPlayers_Click);
            // 
            // BotonPlay
            // 
            this.BotonPlay.BackColor = System.Drawing.Color.OrangeRed;
            this.BotonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPlay.FlatAppearance.BorderSize = 0;
            this.BotonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPlay.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonPlay.Image = ((System.Drawing.Image)(resources.GetObject("BotonPlay.Image")));
            this.BotonPlay.Location = new System.Drawing.Point(435, 73);
            this.BotonPlay.Name = "BotonPlay";
            this.BotonPlay.Size = new System.Drawing.Size(298, 85);
            this.BotonPlay.TabIndex = 1016;
            this.BotonPlay.Text = "One Player";
            this.BotonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonPlay.UseVisualStyleBackColor = false;
            this.BotonPlay.Click += new System.EventHandler(this.BotonPlay_Click);
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
            this.HomeButton.Location = new System.Drawing.Point(522, 333);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(126, 42);
            this.HomeButton.TabIndex = 1018;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.HomeButton;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.TwoPlayers);
            this.Controls.Add(this.BotonPlay);
            this.Controls.Add(this.TitleBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleBackground;
        private System.Windows.Forms.Button BotonPlay;
        private System.Windows.Forms.Button TwoPlayers;
        private System.Windows.Forms.Button HomeButton;
    }
}