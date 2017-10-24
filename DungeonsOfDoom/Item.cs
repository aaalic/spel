using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Item
    {
        
        public Item(string name, int extraStrength)
        {
            ExtraStrength = extraStrength;
            Name = name;
        }

        public string Name { get; private set; }
        public int ExtraStrength { get; private set; }

    }
}
