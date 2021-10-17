using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trevaler_Game_files.Persons_options;
using Trevaler_Game_files.Interfeces_Person;

namespace Trevaler_Game_files.Person_child
{
    [Serializable]
    public class Monster : Person, IDecreaseHP
    {
        public Stats Stats;
        public int Terretory;
        public Monster()
        { }

        public Monster(string name)
        {
            Name = name;
        }

        public Monster(string name, int strenght, int hp)
        {
            Name = name;
            Stats = new Stats(strenght, hp);
        }

        public Monster(string name, int strenght, int hp, int terretory)
        {
            Name = name;
            Stats = new Stats(strenght, hp);
            Terretory = terretory;
        }

        public int Decrease_HP(int hp, int streght)
        {
            return hp - streght;
        }


    }
}
