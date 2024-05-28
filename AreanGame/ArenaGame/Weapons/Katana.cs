using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Katana: IWeapon
    {

        private static double bleedCoeficient = 0;

        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public static double BleedDamage {  get; private set; }

        public Katana(string name)
        {
            Name = name;
            AttackDamage = 35;
            BlockingPower = 5;
            BleedDamage = 5;
        }

        public static double ApplyBleed(double damage)
        {
            bleedCoeficient++;
            return damage + BleedDamage * bleedCoeficient;
        }
    }
}
