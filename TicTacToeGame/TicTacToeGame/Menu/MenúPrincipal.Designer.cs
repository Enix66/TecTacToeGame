namespace TicTacToeGame.Menu
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.FondoTitulo1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.FondoNombre1 = new System.Windows.Forms.Label();
            this.Versión = new System.Windows.Forms.Label();
            this.FondoTitulo2 = new System.Windows.Forms.Label();
            this.FondoNombre2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoTitulo1
            // 
            this.FondoTitulo1.BackColor = System.Drawing.Color.OrangeRed;
            this.FondoTitulo1.Location = new System.Drawing.Point(-2, 35);
            this.FondoTitulo1.Name = "FondoTitulo1";
            this.FondoTitulo1.Size = new System.Drawing.Size(342, 66);
            this.FondoTitulo1.TabIndex = 1000;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.OrangeRed;
            this.Titulo.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.Location = new System.Drawing.Point(12, 35);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(314, 66);
            this.Titulo.TabIndex = 1001;
            this.Titulo.Text = "Tic Tac Toe";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Chartreuse;
            this.Nombre.Font = new System.Drawing.Font("Rockwell", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombre.Location = new System.Drawing.Point(424, 365);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(348, 58);
            this.Nombre.TabIndex = 1004;
            this.Nombre.Text = "By: Jafet Obregón Rodríguez";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FondoNombre1
            // 
            this.FondoNombre1.BackColor = System.Drawing.Color.Chartreuse;
            this.FondoNombre1.Location = new System.Drawing.Point(419, 365);
            this.FondoNombre1.Name = "FondoNombre1";
            this.FondoNombre1.Size = new System.Drawing.Size(367, 58);
            this.FondoNombre1.TabIndex = 1003;
            // 
            // Versión
            // 
            this.Versión.BackColor = System.Drawing.Color.DarkGreen;
            this.Versión.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versión.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Versión.Location = new System.Drawing.Point(653, 423);
            this.Versión.Name = "Versión";
            this.Versión.Size = new System.Drawing.Size(137, 42);
            this.Versión.TabIndex = 1005;
            this.Versión.Text = "v. 0.0.1";
            this.Versión.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FondoTitulo2
            // 
            this.FondoTitulo2.BackColor = System.Drawing.Color.DarkRed;
            this.FondoTitulo2.Location = new System.Drawing.Point(-2, -1);
            this.FondoTitulo2.Name = "FondoTitulo2";
            this.FondoTitulo2.Size = new System.Drawing.Size(792, 83);
            this.FondoTitulo2.TabIndex = 999;
            // 
            // FondoNombre2
            // 
            this.FondoNombre2.BackColor = System.Drawing.Color.DarkGreen;
            this.FondoNombre2.Location = new System.Drawing.Point(-2, 382);
            this.FondoNombre2.Name = "FondoNombre2";
            this.FondoNombre2.Size = new System.Drawing.Size(792, 83);
            this.FondoNombre2.TabIndex = 1002;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 39);
            this.button2.TabIndex = 1009;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(546, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 65);
            this.button1.TabIndex = 1008;
            this.button1.Text = "Tutorial";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BotonPlay
            // 
            this.BotonPlay.BackColor = System.Drawing.Color.MediumBlue;
            this.BotonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPlay.FlatAppearance.BorderSize = 0;
            this.BotonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonPlay.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonPlay.Location = new System.Drawing.Point(492, 108);
            this.BotonPlay.Name = "BotonPlay";
            this.BotonPlay.Size = new System.Drawing.Size(298, 85);
            this.BotonPlay.TabIndex = 1;
            this.BotonPlay.Text = "Play";
            this.BotonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BotonPlay.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(20, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1007;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(545, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 62);
            this.button3.TabIndex = 1010;
            this.button3.Text = "Score";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotonPlay);
            this.Controls.Add(this.Versión);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.FondoNombre1);
            this.Controls.Add(this.FondoNombre2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.FondoTitulo1);
            this.Controls.Add(this.FondoTitulo2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label FondoTitulo1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label FondoNombre1;
        private System.Windows.Forms.Label Versión;
        private System.Windows.Forms.Button BotonPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FondoNombre2;
        private System.Windows.Forms.Label FondoTitulo2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}