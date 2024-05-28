using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dragonslayer : IWeapon
    {
        public string Name { get ; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public static double SelfDamage { get; private set; }

        public Dragonslayer(string name)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 1;
            SelfDamage = 10;
        }
    }
}
