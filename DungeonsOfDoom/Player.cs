using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public Player(int health, int strength, int x, int y, string characterName) : base(health, strength, characterName)
        { 
            X = x;
            Y = y;
            BackPack = new List<Item>();
        }

        public int X { get; set; }
        public int Y { get; set; }

        public List<Item> BackPack { get; private set; }
    }
}
