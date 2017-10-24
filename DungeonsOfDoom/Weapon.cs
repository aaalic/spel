using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Weapon : Item
    {
        public Weapon(string name) : base(name)
        {

        }

        public static Item GenerateRandom(Random random)
        {
            int i = random.Next(0, 10);
            if (i < 5)
                return new Knife();
            else if (i < 8)
                return new Sword();
            else
                return new Bomb();
        }
    }
}
