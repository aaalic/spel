using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public Character(int health, int strength, string characterName)
        {
            Health = health;
            Strength = strength;
            CharacterName = characterName;
        }
        private int health;

        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0)
                    health = value;
                else { health = 0; }
            }
        }

        public int Strength { get; set; }
        public string CharacterName { get; set; }

        public virtual void Fight(Character opponent)
        {
            opponent.Health -= Strength;
        }

        //Metod som tar in en character

        //public string Fight(string characterName1, string characterName2)
        //{
        //    string winner = "";

        //    return winner;
        //}
    }
}
