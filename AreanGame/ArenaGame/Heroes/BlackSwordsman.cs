using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class BlackSwordsman : Hero
    {
        private int berserkModeTurns;
        public BlackSwordsman(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if(berserkModeTurns > 0)
            {
                berserkModeTurns -= 1;
                return damage * 1.5;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            if (damage + Dragonslayer.SelfDamage > 30 && berserkModeTurns == 0)
            {
                berserkModeTurns = 3;
            }
            return base.Defend(damage);
        }

    }
}
