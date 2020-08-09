namespace Fighting_Game
{
    partial class StartingForm
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
            this.textHeading = new System.Windows.Forms.Label();
            this.ButtonHeroCreation = new System.Windows.Forms.Button();
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.labelMyHealthPoints = new System.Windows.Forms.Label();
            this.labelMyHero = new System.Windows.Forms.Label();
            this.labelOpponentHero = new System.Windows.Forms.Label();
            this.labelOpponentHealthPoints = new System.Windows.Forms.Label();
            this.labelMyArmorPoints = new System.Windows.Forms.Label();
            this.labelOpponentArmorPoints = new System.Windows.Forms.Label();
            this.labelMyAttackPoints = new System.Windows.Forms.Label();
            this.labelOpponentAttackPoints = new System.Windows.Forms.Label();
            this.labelOpponentHeroClass = new System.Windows.Forms.Label();
            this.labelMyHeroClass = new System.Windows.Forms.Label();
            this.labelPleaseCreateAHero = new System.Windows.Forms.Label();
            this.textBoxCanvas = new System.Windows.Forms.RichTextBox();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // textHeading
            // 
            this.textHeading.AutoSize = true;
            this.textHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeading.Location = new System.Drawing.Point(12, 9);
            this.textHeading.Name = "textHeading";
            this.textHeading.Size = new System.Drawing.Size(191, 31);
            this.textHeading.TabIndex = 0;
            this.textHeading.Text = "Fighting Game";
            // 
            // ButtonHeroCreation
            // 
            this.ButtonHeroCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHeroCreation.Location = new System.Drawing.Point(12, 367);
            this.ButtonHeroCreation.Name = "ButtonHeroCreation";
            this.ButtonHeroCreation.Size = new System.Drawing.Size(192, 50);
            this.ButtonHeroCreation.TabIndex = 1;
            this.ButtonHeroCreation.Text = "Create Hero";
            this.ButtonHeroCreation.UseVisualStyleBackColor = true;
            this.ButtonHeroCreation.Click += new System.EventHandler(this.ButtonHeroCreation_Click);
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartGame.Location = new System.Drawing.Point(12, 423);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(191, 50);
            this.ButtonStartGame.TabIndex = 2;
            this.ButtonStartGame.Text = "Start Game";
            this.ButtonStartGame.UseVisualStyleBackColor = true;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 53);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(433, 296);
            this.pictureBoxCanvas.TabIndex = 3;
            this.pictureBoxCanvas.TabStop = false;
            // 
            // buttonAttack
            // 
            this.buttonAttack.Enabled = false;
            this.buttonAttack.Location = new System.Drawing.Point(253, 367);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(119, 27);
            this.buttonAttack.TabIndex = 4;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.ButtonAttack_Click);
            // 
            // labelMyHealthPoints
            // 
            this.labelMyHealthPoints.AutoSize = true;
            this.labelMyHealthPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMyHealthPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMyHealthPoints.ForeColor = System.Drawing.Color.Red;
            this.labelMyHealthPoints.Location = new System.Drawing.Point(26, 105);
            this.labelMyHealthPoints.Name = "labelMyHealthPoints";
            this.labelMyHealthPoints.Size = new System.Drawing.Size(96, 17);
            this.labelMyHealthPoints.TabIndex = 5;
            this.labelMyHealthPoints.Text = "Health Points:";
            this.labelMyHealthPoints.Visible = false;
            // 
            // labelMyHero
            // 
            this.labelMyHero.AutoSize = true;
            this.labelMyHero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMyHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelMyHero.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMyHero.Location = new System.Drawing.Point(24, 79);
            this.labelMyHero.Name = "labelMyHero";
            this.labelMyHero.Size = new System.Drawing.Size(94, 26);
            this.labelMyHero.TabIndex = 6;
            this.labelMyHero.Text = "My Hero";
            this.labelMyHero.Visible = false;
            // 
            // labelOpponentHero
            // 
            this.labelOpponentHero.AutoSize = true;
            this.labelOpponentHero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpponentHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelOpponentHero.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOpponentHero.Location = new System.Drawing.Point(267, 79);
            this.labelOpponentHero.Name = "labelOpponentHero";
            this.labelOpponentHero.Size = new System.Drawing.Size(160, 26);
            this.labelOpponentHero.TabIndex = 7;
            this.labelOpponentHero.Text = "Opponent Hero";
            this.labelOpponentHero.Visible = false;
            // 
            // labelOpponentHealthPoints
            // 
            this.labelOpponentHealthPoints.AutoSize = true;
            this.labelOpponentHealthPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpponentHealthPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOpponentHealthPoints.ForeColor = System.Drawing.Color.Red;
            this.labelOpponentHealthPoints.Location = new System.Drawing.Point(269, 105);
            this.labelOpponentHealthPoints.Name = "labelOpponentHealthPoints";
            this.labelOpponentHealthPoints.Size = new System.Drawing.Size(96, 17);
            this.labelOpponentHealthPoints.TabIndex = 8;
            this.labelOpponentHealthPoints.Text = "Health Points:";
            this.labelOpponentHealthPoints.Visible = false;
            // 
            // labelMyArmorPoints
            // 
            this.labelMyArmorPoints.AutoSize = true;
            this.labelMyArmorPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMyArmorPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMyArmorPoints.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelMyArmorPoints.Location = new System.Drawing.Point(26, 139);
            this.labelMyArmorPoints.Name = "labelMyArmorPoints";
            this.labelMyArmorPoints.Size = new System.Drawing.Size(93, 17);
            this.labelMyArmorPoints.TabIndex = 9;
            this.labelMyArmorPoints.Text = "Armor Points:";
            this.labelMyArmorPoints.Visible = false;
            // 
            // labelOpponentArmorPoints
            // 
            this.labelOpponentArmorPoints.AutoSize = true;
            this.labelOpponentArmorPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpponentArmorPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOpponentArmorPoints.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelOpponentArmorPoints.Location = new System.Drawing.Point(269, 139);
            this.labelOpponentArmorPoints.Name = "labelOpponentArmorPoints";
            this.labelOpponentArmorPoints.Size = new System.Drawing.Size(93, 17);
            this.labelOpponentArmorPoints.TabIndex = 10;
            this.labelOpponentArmorPoints.Text = "Armor Points:";
            this.labelOpponentArmorPoints.Visible = false;
            // 
            // labelMyAttackPoints
            // 
            this.labelMyAttackPoints.AutoSize = true;
            this.labelMyAttackPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMyAttackPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMyAttackPoints.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelMyAttackPoints.Location = new System.Drawing.Point(26, 122);
            this.labelMyAttackPoints.Name = "labelMyAttackPoints";
            this.labelMyAttackPoints.Size = new System.Drawing.Size(94, 17);
            this.labelMyAttackPoints.TabIndex = 11;
            this.labelMyAttackPoints.Text = "Attack Points:";
            this.labelMyAttackPoints.Visible = false;
            // 
            // labelOpponentAttackPoints
            // 
            this.labelOpponentAttackPoints.AutoSize = true;
            this.labelOpponentAttackPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpponentAttackPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOpponentAttackPoints.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelOpponentAttackPoints.Location = new System.Drawing.Point(269, 122);
            this.labelOpponentAttackPoints.Name = "labelOpponentAttackPoints";
            this.labelOpponentAttackPoints.Size = new System.Drawing.Size(94, 17);
            this.labelOpponentAttackPoints.TabIndex = 12;
            this.labelOpponentAttackPoints.Text = "Attack Points:";
            this.labelOpponentAttackPoints.Visible = false;
            // 
            // labelOpponentHeroClass
            // 
            this.labelOpponentHeroClass.AutoSize = true;
            this.labelOpponentHeroClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpponentHeroClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOpponentHeroClass.ForeColor = System.Drawing.Color.Bisque;
            this.labelOpponentHeroClass.Location = new System.Drawing.Point(269, 156);
            this.labelOpponentHeroClass.Name = "labelOpponentHeroClass";
            this.labelOpponentHeroClass.Size = new System.Drawing.Size(46, 17);
            this.labelOpponentHeroClass.TabIndex = 13;
            this.labelOpponentHeroClass.Text = "Class:";
            this.labelOpponentHeroClass.Visible = false;
            // 
            // labelMyHeroClass
            // 
            this.labelMyHeroClass.AutoSize = true;
            this.labelMyHeroClass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMyHeroClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMyHeroClass.ForeColor = System.Drawing.Color.Bisque;
            this.labelMyHeroClass.Location = new System.Drawing.Point(26, 156);
            this.labelMyHeroClass.Name = "labelMyHeroClass";
            this.labelMyHeroClass.Size = new System.Drawing.Size(46, 17);
            this.labelMyHeroClass.TabIndex = 14;
            this.labelMyHeroClass.Text = "Class:";
            this.labelMyHeroClass.Visible = false;
            // 
            // labelPleaseCreateAHero
            // 
            this.labelPleaseCreateAHero.AutoSize = true;
            this.labelPleaseCreateAHero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPleaseCreateAHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPleaseCreateAHero.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPleaseCreateAHero.Location = new System.Drawing.Point(24, 57);
            this.labelPleaseCreateAHero.Name = "labelPleaseCreateAHero";
            this.labelPleaseCreateAHero.Size = new System.Drawing.Size(399, 26);
            this.labelPleaseCreateAHero.TabIndex = 17;
            this.labelPleaseCreateAHero.Text = "Please create a hero and start the game";
            // 
            // textBoxCanvas
            // 
            this.textBoxCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCanvas.Location = new System.Drawing.Point(12, 176);
            this.textBoxCanvas.Name = "textBoxCanvas";
            this.textBoxCanvas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxCanvas.Size = new System.Drawing.Size(433, 173);
            this.textBoxCanvas.TabIndex = 18;
            this.textBoxCanvas.Text = "";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Enabled = false;
            this.buttonPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(253, 423);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(192, 50);
            this.buttonPlayAgain.TabIndex = 19;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.ButtonPlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fighting_Game.Properties.Resources.game_background;
            this.ClientSize = new System.Drawing.Size(457, 485);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.textBoxCanvas);
            this.Controls.Add(this.labelPleaseCreateAHero);
            this.Controls.Add(this.labelMyHeroClass);
            this.Controls.Add(this.labelOpponentHeroClass);
            this.Controls.Add(this.labelOpponentAttackPoints);
            this.Controls.Add(this.labelMyAttackPoints);
            this.Controls.Add(this.labelOpponentArmorPoints);
            this.Controls.Add(this.labelMyArmorPoints);
            this.Controls.Add(this.labelOpponentHealthPoints);
            this.Controls.Add(this.labelOpponentHero);
            this.Controls.Add(this.labelMyHero);
            this.Controls.Add(this.labelMyHealthPoints);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.ButtonStartGame);
            this.Controls.Add(this.ButtonHeroCreation);
            this.Controls.Add(this.textHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textHeading;
        private System.Windows.Forms.Button ButtonHeroCreation;
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Label labelMyHealthPoints;
        private System.Windows.Forms.Label labelMyHero;
        private System.Windows.Forms.Label labelOpponentHero;
        private System.Windows.Forms.Label labelOpponentHealthPoints;
        private System.Windows.Forms.Label labelMyArmorPoints;
        private System.Windows.Forms.Label labelOpponentArmorPoints;
        private System.Windows.Forms.Label labelMyAttackPoints;
        private System.Windows.Forms.Label labelOpponentAttackPoints;
        private System.Windows.Forms.Label labelOpponentHeroClass;
        private System.Windows.Forms.Label labelMyHeroClass;
        private System.Windows.Forms.Label labelPleaseCreateAHero;
        private System.Windows.Forms.RichTextBox textBoxCanvas;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}

