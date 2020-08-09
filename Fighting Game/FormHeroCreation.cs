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
    public partial class FormHeroCreation : Form
    {
        public FormHeroCreation()
        {
            InitializeComponent();
        }
        private void FormHeroCreation_Load(object sender, EventArgs e)
        {

        }
        public Hero hero;
        private void ButtonHeroSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxHeroName.Text == "")
            {
                MessageBox.Show("Please choose a name!");
            }
            else
            {
                switch (ComboBoxHeroClass.Text)
                {
                    case "Warrior":
                        hero = new Warrior(TextBoxHeroName.Text);
                        hero.SetStats();
                        MessageBox.Show("You created " + hero.Name + " the Warrior!");
                        this.Hide();
                        break;
                    case "Knight":
                        hero = new Knight(TextBoxHeroName.Text);
                        hero.SetStats();
                        MessageBox.Show("You created " + hero.Name + " the Knight!");
                        this.Hide();
                        break;
                    case "Assassin":
                        hero = new Assassin(TextBoxHeroName.Text);
                        hero.SetStats();
                        MessageBox.Show("You created " + hero.Name + " the Assassin!");
                        this.Hide();
                        break;
                    case "Monk":
                        hero = new Monk(TextBoxHeroName.Text);
                        hero.SetStats();
                        MessageBox.Show("You created " + hero.Name + " the Monk!");
                        this.Hide();
                        break;
                    case "Mage":
                        hero = new Mage(TextBoxHeroName.Text);
                        hero.SetStats();
                        MessageBox.Show("You created " + hero.Name + " the Mage!");
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Please go back and choose a class!");
                        break;
                }
            }
        }

        private void ButtonClassInformation_Click(object sender, EventArgs e)
        {
            String output = string.Format("Warrior: Nothing special.{0}{0}" +
                                          "Knight: {0}" +
                                          "Defending: 20% chance to block and receive no damage.{0}" +
                                          "Attacking: 10% chance to do 200% damage.{0}{0}" +
                                          "Assassin: {0}" +
                                          "Attacking: 30% chance to do 300% damage.{0}{0}" +
                                          "Monk: {0}" +
                                          "Defending: 30% chance to avoid and receive no damage.{0}{0}" +
                                          "Mage: {0}" +
                                          "Attacking: 30% chance to do 200% damage.{0}" +
                                          "Defending: 30% chance to put on a spell and take 50% damage."
                                          , Environment.NewLine);
            MessageBox.Show(output);
        }
    }
}
