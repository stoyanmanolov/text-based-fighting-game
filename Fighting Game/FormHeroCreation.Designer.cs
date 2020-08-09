namespace Fighting_Game
{
    partial class FormHeroCreation
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
            this.labelHeroName = new System.Windows.Forms.Label();
            this.TextBoxHeroName = new System.Windows.Forms.TextBox();
            this.ComboBoxHeroClass = new System.Windows.Forms.ComboBox();
            this.labelHeroClass = new System.Windows.Forms.Label();
            this.ButtonHeroSubmit = new System.Windows.Forms.Button();
            this.buttonClassInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeroName
            // 
            this.labelHeroName.AutoSize = true;
            this.labelHeroName.Location = new System.Drawing.Point(16, 15);
            this.labelHeroName.Name = "labelHeroName";
            this.labelHeroName.Size = new System.Drawing.Size(38, 13);
            this.labelHeroName.TabIndex = 0;
            this.labelHeroName.Text = "Name:";
            // 
            // TextBoxHeroName
            // 
            this.TextBoxHeroName.Location = new System.Drawing.Point(57, 12);
            this.TextBoxHeroName.MaxLength = 10;
            this.TextBoxHeroName.Name = "TextBoxHeroName";
            this.TextBoxHeroName.Size = new System.Drawing.Size(150, 20);
            this.TextBoxHeroName.TabIndex = 1;
            // 
            // ComboBoxHeroClass
            // 
            this.ComboBoxHeroClass.FormattingEnabled = true;
            this.ComboBoxHeroClass.Items.AddRange(new object[] {
            "Warrior",
            "Knight",
            "Assassin",
            "Monk",
            "Mage"});
            this.ComboBoxHeroClass.Location = new System.Drawing.Point(83, 38);
            this.ComboBoxHeroClass.Name = "ComboBoxHeroClass";
            this.ComboBoxHeroClass.Size = new System.Drawing.Size(124, 21);
            this.ComboBoxHeroClass.TabIndex = 2;
            // 
            // labelHeroClass
            // 
            this.labelHeroClass.AutoSize = true;
            this.labelHeroClass.Location = new System.Drawing.Point(16, 41);
            this.labelHeroClass.Name = "labelHeroClass";
            this.labelHeroClass.Size = new System.Drawing.Size(61, 13);
            this.labelHeroClass.TabIndex = 3;
            this.labelHeroClass.Text = "Hero Class:";
            // 
            // ButtonHeroSubmit
            // 
            this.ButtonHeroSubmit.Location = new System.Drawing.Point(19, 95);
            this.ButtonHeroSubmit.Name = "ButtonHeroSubmit";
            this.ButtonHeroSubmit.Size = new System.Drawing.Size(188, 24);
            this.ButtonHeroSubmit.TabIndex = 4;
            this.ButtonHeroSubmit.Text = "Submit";
            this.ButtonHeroSubmit.UseVisualStyleBackColor = true;
            this.ButtonHeroSubmit.Click += new System.EventHandler(this.ButtonHeroSubmit_Click);
            // 
            // buttonClassInformation
            // 
            this.buttonClassInformation.Location = new System.Drawing.Point(19, 66);
            this.buttonClassInformation.Name = "buttonClassInformation";
            this.buttonClassInformation.Size = new System.Drawing.Size(188, 23);
            this.buttonClassInformation.TabIndex = 5;
            this.buttonClassInformation.Text = "Class Information";
            this.buttonClassInformation.UseVisualStyleBackColor = true;
            this.buttonClassInformation.Click += new System.EventHandler(this.ButtonClassInformation_Click);
            // 
            // FormHeroCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 131);
            this.Controls.Add(this.buttonClassInformation);
            this.Controls.Add(this.ButtonHeroSubmit);
            this.Controls.Add(this.labelHeroClass);
            this.Controls.Add(this.ComboBoxHeroClass);
            this.Controls.Add(this.TextBoxHeroName);
            this.Controls.Add(this.labelHeroName);
            this.Name = "FormHeroCreation";
            this.Text = "FormHeroCreation";
            this.Load += new System.EventHandler(this.FormHeroCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeroName;
        private System.Windows.Forms.TextBox TextBoxHeroName;
        private System.Windows.Forms.ComboBox ComboBoxHeroClass;
        private System.Windows.Forms.Label labelHeroClass;
        private System.Windows.Forms.Button ButtonHeroSubmit;
        private System.Windows.Forms.Button buttonClassInformation;
    }
}