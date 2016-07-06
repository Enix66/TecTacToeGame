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
            this.Nombre = new System.Windows.Forms.Label();
            this.FondoNombre1 = new System.Windows.Forms.Label();
            this.FondoNombre2 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.FondoTitulo1 = new System.Windows.Forms.Label();
            this.FondoTitulo2 = new System.Windows.Forms.Label();
            this.Tutorial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Button();
            this.BotonPlay = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Versión = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Nombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Nombre.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombre.Location = new System.Drawing.Point(422, 364);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(348, 58);
            this.Nombre.TabIndex = 1019;
            this.Nombre.Text = "By: Jafet Obregón Rodríguez";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FondoNombre1
            // 
            this.FondoNombre1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FondoNombre1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FondoNombre1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FondoNombre1.Location = new System.Drawing.Point(417, 364);
            this.FondoNombre1.Name = "FondoNombre1";
            this.FondoNombre1.Size = new System.Drawing.Size(367, 58);
            this.FondoNombre1.TabIndex = 1018;
            // 
            // FondoNombre2
            // 
            this.FondoNombre2.BackColor = System.Drawing.Color.DodgerBlue;
            this.FondoNombre2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FondoNombre2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FondoNombre2.Location = new System.Drawing.Point(-4, 381);
            this.FondoNombre2.Name = "FondoNombre2";
            this.FondoNombre2.Size = new System.Drawing.Size(792, 83);
            this.FondoNombre2.TabIndex = 1017;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Titulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Titulo.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.Location = new System.Drawing.Point(10, 34);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(314, 66);
            this.Titulo.TabIndex = 1016;
            this.Titulo.Text = "Tic Tac Toe";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FondoTitulo1
            // 
            this.FondoTitulo1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FondoTitulo1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FondoTitulo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FondoTitulo1.Location = new System.Drawing.Point(-4, 34);
            this.FondoTitulo1.Name = "FondoTitulo1";
            this.FondoTitulo1.Size = new System.Drawing.Size(342, 66);
            this.FondoTitulo1.TabIndex = 1015;
            // 
            // FondoTitulo2
            // 
            this.FondoTitulo2.BackColor = System.Drawing.Color.DodgerBlue;
            this.FondoTitulo2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FondoTitulo2.Location = new System.Drawing.Point(-4, -2);
            this.FondoTitulo2.Name = "FondoTitulo2";
            this.FondoTitulo2.Size = new System.Drawing.Size(792, 83);
            this.FondoTitulo2.TabIndex = 1014;
            // 
            // Tutorial
            // 
            this.Tutorial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tutorial.FlatAppearance.BorderSize = 0;
            this.Tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tutorial.Image = global::TicTacToeGame.Properties.Resources.Tutorial2;
            this.Tutorial.Location = new System.Drawing.Point(-1, 119);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(247, 53);
            this.Tutorial.TabIndex = 1022;
            this.Tutorial.Text = "Tutorial";
            this.Tutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Tutorial.UseVisualStyleBackColor = false;
            this.Tutorial.Click += new System.EventHandler(this.Tutorial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1021;
            this.pictureBox1.TabStop = false;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Score.FlatAppearance.BorderSize = 0;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Score.Image = global::TicTacToeGame.Properties.Resources.ScoreIcon;
            this.Score.Location = new System.Drawing.Point(541, 242);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(247, 53);
            this.Score.TabIndex = 1020;
            this.Score.Text = "Score";
            this.Score.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Score.UseVisualStyleBackColor = false;
            // 
            // BotonPlay
            // 
            this.BotonPlay.BackColor = System.Drawing.Color.OrangeRed;
            this.BotonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPlay.FlatAppearance.BorderSize = 0;
            this.BotonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPlay.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonPlay.Image = global::TicTacToeGame.Properties.Resources.playButton;
            this.BotonPlay.Location = new System.Drawing.Point(490, 136);
            this.BotonPlay.Name = "BotonPlay";
            this.BotonPlay.Size = new System.Drawing.Size(298, 85);
            this.BotonPlay.TabIndex = 1013;
            this.BotonPlay.Text = "Play";
            this.BotonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonPlay.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // 
            // Versión
            // 
            this.Versión.BackColor = System.Drawing.Color.DodgerBlue;
            this.Versión.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versión.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Versión.Location = new System.Drawing.Point(647, 422);
            this.Versión.Name = "Versión";
            this.Versión.Size = new System.Drawing.Size(137, 42);
            this.Versión.TabIndex = 1023;
            this.Versión.Text = "v. 0.0.1";
            this.Versión.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Versión.UseWaitCursor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Versión);
            this.Controls.Add(this.Tutorial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.BotonPlay);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.FondoNombre1);
            this.Controls.Add(this.FondoNombre2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.FondoTitulo1);
            this.Controls.Add(this.FondoTitulo2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button BotonPlay;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label FondoNombre1;
        private System.Windows.Forms.Label FondoNombre2;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label FondoTitulo1;
        private System.Windows.Forms.Label FondoTitulo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Tutorial;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Versión;
    }
}