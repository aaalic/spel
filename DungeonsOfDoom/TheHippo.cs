using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class TheHippo : Monster
    {
        public TheHippo(int health, int strength, string characterName) : base(health, strength, characterName)
        {
        }

        public override void Fight(Character opponent)
        {
            opponent.Health -= Strength;
        }
    }
}
