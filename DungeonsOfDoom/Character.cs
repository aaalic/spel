using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public Character(int health)
        {
            Health = health;
        }
        public int Health { get; set; }
    }
}
