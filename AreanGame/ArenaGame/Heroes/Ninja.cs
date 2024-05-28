using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Ninja: Hero
    {
        private double dodgeChance;
        private double hitAccuracy;
        private bool bleed;
        public Ninja(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {
            dodgeChance = 0.5;
        }

        public override double Defend(double damage)
        {
            hitAccuracy = random.NextDouble(); 
            if (hitAccuracy <= dodgeChance)
            {
                return 0;
            }
            return base.Defend(damage);
        }

        public override double Attack()
        {
            double damage = base.Attack();

            if (Weapon is Katana)
            {
                double probability = random.NextDouble();
                if (probability < 0.30 && bleed == false)
                {
                    Katana.ApplyBleed(damage);
                    bleed = true;
                }
                else if(bleed == true)
                {
                    Katana.ApplyBleed(damage);
                }
            }
            
            return damage;
        }
    }
}
