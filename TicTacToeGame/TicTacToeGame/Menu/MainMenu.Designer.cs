namespace TicTacToeGame.Menu
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NameJafet = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.ButtonTutorial = new System.Windows.Forms.Button();
            this.ReferenceImage = new System.Windows.Forms.PictureBox();
            this.ButtonScore = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NameJafet
            // 
            this.NameJafet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NameJafet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameJafet.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameJafet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameJafet.Location = new System.Drawing.Point(513, 386);
            this.NameJafet.Name = "NameJafet";
            this.NameJafet.Size = new System.Drawing.Size(275, 41);
            this.NameJafet.TabIndex = 1019;
            this.NameJafet.Text = "By: Jafet Obregón R";
            this.NameJafet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name2
            // 
            this.Name2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Name2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name2.Location = new System.Drawing.Point(-4, 381);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(792, 83);
            this.Name2.TabIndex = 1017;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Title.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Title.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(10, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(314, 66);
            this.Title.TabIndex = 1016;
            this.Title.Text = "Tic Tac Toe";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Title1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Title1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title1.Location = new System.Drawing.Point(-4, 34);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(342, 66);
            this.Title1.TabIndex = 1015;
            // 
            // Title2
            // 
            this.Title2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Title2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Title2.Location = new System.Drawing.Point(-4, -2);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(792, 83);
            this.Title2.TabIndex = 1014;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(12, 406);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(69, 44);
            this.ExitButton.TabIndex = 1024;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.DodgerBlue;
            this.Version.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Version.Location = new System.Drawing.Point(647, 427);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(137, 37);
            this.Version.TabIndex = 1023;
            this.Version.Text = "v. 0.0.1";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Version.UseWaitCursor = true;
            // 
            // ButtonTutorial
            // 
            this.ButtonTutorial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTutorial.FlatAppearance.BorderSize = 0;
            this.ButtonTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTutorial.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTutorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonTutorial.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTutorial.Image")));
            this.ButtonTutorial.Location = new System.Drawing.Point(541, 112);
            this.ButtonTutorial.Name = "ButtonTutorial";
            this.ButtonTutorial.Size = new System.Drawing.Size(247, 53);
            this.ButtonTutorial.TabIndex = 1022;
            this.ButtonTutorial.Text = "Tutorial";
            this.ButtonTutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonTutorial.UseVisualStyleBackColor = false;
            this.ButtonTutorial.Click += new System.EventHandler(this.ButtonTutorial_Click);
            // 
            // ReferenceImage
            // 
            this.ReferenceImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReferenceImage.Image = ((System.Drawing.Image)(resources.GetObject("ReferenceImage.Image")));
            this.ReferenceImage.Location = new System.Drawing.Point(12, 124);
            this.ReferenceImage.Name = "ReferenceImage";
            this.ReferenceImage.Size = new System.Drawing.Size(244, 233);
            this.ReferenceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReferenceImage.TabIndex = 1021;
            this.ReferenceImage.TabStop = false;
            this.ReferenceImage.Click += new System.EventHandler(this.ReferenceImage_Click);
            // 
            // ButtonScore
            // 
            this.ButtonScore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonScore.FlatAppearance.BorderSize = 0;
            this.ButtonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonScore.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonScore.Image = ((System.Drawing.Image)(resources.GetObject("ButtonScore.Image")));
            this.ButtonScore.Location = new System.Drawing.Point(541, 288);
            this.ButtonScore.Name = "ButtonScore";
            this.ButtonScore.Size = new System.Drawing.Size(247, 53);
            this.ButtonScore.TabIndex = 1020;
            this.ButtonScore.Text = "Score";
            this.ButtonScore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonScore.UseVisualStyleBackColor = false;
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPlay.Image")));
            this.ButtonPlay.Location = new System.Drawing.Point(490, 184);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(298, 85);
            this.ButtonPlay.TabIndex = 1013;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.ButtonPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.NameJafet);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ButtonTutorial);
            this.Controls.Add(this.ReferenceImage);
            this.Controls.Add(this.ButtonScore);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.Title2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.ReferenceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonScore;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Label NameJafet;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Button ButtonTutorial;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.PictureBox ReferenceImage;
    }
}