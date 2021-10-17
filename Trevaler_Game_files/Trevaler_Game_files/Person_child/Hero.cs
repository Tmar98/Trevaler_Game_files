using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trevaler_Game_files.Persons_options;
using Trevaler_Game_files.Interfeces_Person;

namespace Trevaler_Game_files.Person_child
{
    public class Hero : Person, IDecreaseHP
    {

        public Stats Stats;
        public Equipment_Places ecuepment;

        public Hero()
        { }

        public Hero(string name)
        {
            Name = name;
        }
        public Hero(string name, int strenght, int hp)
        {
            Name = name;
            Stats = new Stats(strenght, hp);


        }

        public int Decrease_HP(int hp, int strenght)
        {
            return hp-strenght;
        }
    }
}
