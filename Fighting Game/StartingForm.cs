using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using Engine.HeroClasses;

namespace Fighting_Game
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Needed variables

        static Random random = new Random();
        public Hero MyHero { get; set; }
        public Hero opponentHero = new Hero("Opponent Hero");
        public FormHeroCreation heroCreation = new FormHeroCreation();

        private void ButtonHeroCreation_Click(object sender, EventArgs e)
        {
            heroCreation.Show();
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            
            MyHero = heroCreation.hero;
            if (MyHero == null)
            {
                MessageBox.Show("Please go back and create a hero.");
            }
            else if (MyHero != null)
            {
                //Visibility after starting the game
                ButtonHeroCreation.Enabled = false;
                ButtonStartGame.Enabled = false;

                labelMyHero.Visible = true;
                labelMyHealthPoints.Visible = true;
                labelMyAttackPoints.Visible = true;
                labelMyArmorPoints.Visible = true;
                labelMyHeroClass.Visible = true;

                labelOpponentHero.Visible = true;
                labelOpponentHealthPoints.Visible = true;
                labelOpponentAttackPoints.Visible = true;
                labelOpponentArmorPoints.Visible = true;
                labelOpponentHeroClass.Visible = true;

                buttonAttack.Enabled = true;
                labelPleaseCreateAHero.Visible = false;

                //Opponent hero creation

                int randomHeroClass = random.Next(1, 5 + 1);
                switch (randomHeroClass)
                {
                    case 1:
                        opponentHero = new Warrior("Opponent Hero");
                        break;
                    case 2:
                        opponentHero = new Knight("Opponent Hero");
                        break;
                    case 3:
                        opponentHero = new Assassin("Opponent Hero");
                        break;
                    case 4:
                        opponentHero = new Monk("Opponent Hero");
                        break;
                    case 5:
                        opponentHero = new Mage("Opponent Hero");
                        break;
                }
                opponentHero.SetStats();

                //Changes depending on hero creation

                labelMyHero.Text = MyHero.Name;
                labelMyHealthPoints.Text = "Health Points: " + MyHero.HealthPoints;
                labelMyAttackPoints.Text = "Attack Points: " + MyHero.AttackPoints;
                labelMyArmorPoints.Text = "Armor Points: " + MyHero.ArmorPoints;
                labelMyHeroClass.Text = "Class: " + MyHero.GetType().Name;

                labelOpponentHero.Text = opponentHero.Name;
                labelOpponentHealthPoints.Text = "Health Points: " + opponentHero.HealthPoints;
                labelOpponentAttackPoints.Text = "Attack Points: " + opponentHero.AttackPoints;
                labelOpponentArmorPoints.Text = "Armor Points: " + opponentHero.ArmorPoints;
                labelOpponentHeroClass.Text = "Class: " + opponentHero.GetType().Name;

                textBoxCanvas.AppendText("You go first");
                textBoxCanvas.AppendText(Environment.NewLine);
            }
        }

        private void ButtonAttack_Click(object sender, EventArgs e)
        {

            // Attack if my hero is alive

            if (MyHero.HealthPoints > 0)
            {
                int attack = MyHero.Attack(opponentHero);
                textBoxCanvas.SelectionColor = Color.Blue;
                textBoxCanvas.AppendText(MyHero.Name + " attacked " + opponentHero.Name + " for " + attack + " damage");
                textBoxCanvas.AppendText(Environment.NewLine);
                labelOpponentHealthPoints.Text = "Health Points: " + opponentHero.HealthPoints;
            }

            // Opponent attacks me if he survived my attack

            if (opponentHero.HealthPoints > 0)
            {
                int attack = opponentHero.Attack(MyHero);
                textBoxCanvas.SelectionColor = Color.Red;
                textBoxCanvas.AppendText(opponentHero.Name + " attacked " + MyHero.Name + " for " + attack + " damage");
                textBoxCanvas.AppendText(Environment.NewLine);
                labelMyHealthPoints.Text = "Health Points: " + MyHero.HealthPoints;
                
            }

            // TextBox scroll to bottom

            textBoxCanvas.SelectionStart = textBoxCanvas.Text.Length;
            textBoxCanvas.ScrollToCaret();

            // If one of us dies

            if (MyHero.HealthPoints < 0 || opponentHero.HealthPoints < 0)
            {
                textBoxCanvas.SelectionColor = Color.Red;
                textBoxCanvas.AppendText("GAME OVER");
                textBoxCanvas.AppendText(Environment.NewLine);
                if (opponentHero.HealthPoints < 0)
                {
                    textBoxCanvas.SelectionColor = Color.Blue;
                    textBoxCanvas.AppendText("YOU WON");
                    
                }
                else if (MyHero.HealthPoints < 0)
                {
                    textBoxCanvas.SelectionColor = Color.Red;
                    textBoxCanvas.AppendText("YOU LOST");
                }
                buttonAttack.Enabled = false;
                buttonPlayAgain.Enabled = true;
            }
        }

        private void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
