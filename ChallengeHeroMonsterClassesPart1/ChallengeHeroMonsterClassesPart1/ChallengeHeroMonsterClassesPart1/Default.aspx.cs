using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 50;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Troll";
            monster.Health = 35;
            monster.DamageMaximum = 15;
            monster.AttackBonus = true;

            int damage = hero.Attack();
            monster.Defend(damage);

            damage = monster.Attack();
            hero.Defend(damage);

            roundResult(hero);
            roundResult(monster);

        }

        private void roundResult(Character character)
        {
            resultLabel.Text += String.Format("{0} has {1} health <br/>", character.Name, character.Health);
        }
    }
    
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();

            int damage = random.Next(1, this.DamageMaximum);

            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }

    }
}