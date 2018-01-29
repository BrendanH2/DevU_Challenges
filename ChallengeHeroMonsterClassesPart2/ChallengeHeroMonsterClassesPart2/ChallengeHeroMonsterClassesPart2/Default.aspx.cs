using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "The Hero";
            hero.Health = 100;
            hero.DamageMaximum = 30;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Nasty Troll";
            monster.Health = 75;
            monster.DamageMaximum = 35;
            monster.AttackBonus = true;

            Dice dice = new Dice();

            if (hero.AttackBonus)
                monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));
            
            while (hero.Health > 0 && monster.Health >0)
            {
                int damage = hero.Attack(dice);
                monster.Defend(damage);

                damage = monster.Attack(dice);
                hero.Defend(damage);

                roundResult(hero);
                roundResult(monster);
            }

            displayResult(hero, monster);

           

           
            
        }
        
        private void roundResult(Character character)
        {
            resultLabel.Text += String.Format("{0} has {1} health remaining <br/>", character.Name, character.Health);
        }

        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>Both {0} and {1} died.",
                                    opponent1.Name,
                                    opponent2.Name);
            else if (opponent1.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>",
                                    opponent2.Name,
                                    opponent1.Name);
            else
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>",
                                   opponent1.Name,
                                   opponent2.Name);

        }
    }

    

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            dice.Sides = this.DamageMaximum;
            
            return dice.Roll();

        }

        public void Defend(int damage)
        {
            Health -= damage;
        }

        

    }

    class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();

        public int Roll()
        {
            return random.Next(this.Sides);
        }

    }
}