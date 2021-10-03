using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trevaler_Game_files
{
    public abstract class Stats
    {
        public int Strenght;
        private int hP;
        public int HP
        {
            get
            {
                return hP;
            }
            set
            {
                if (value < 0)
                {
                    hP = 0;
                }
                else
                {
                    hP = value;
                }
            }
        }
    }

    public class Hero :Stats, IDecreaseHP
    {
        
        public string Name;

        public Hero()
        { }

        public Hero(string name)
        {
            Name = name;
        }
        public Hero (string name, int strenght, int hp)
        {
            Name = name;
            Strenght = strenght;
            HP = hp;
        }

        public int Decrease_HP(int hp, int streght)
        {
            return hp - streght;
        }
    }

    public class Monster:Stats, IDecreaseHP
    {
        public string Name;

        public Monster()
        { }

        public Monster(string name)
        {
            Name = name;
        }

        public Monster(string name, int strenght, int hp)
        {
            Name = name;
            Strenght = strenght;
            HP = hp;
        }

        public int Decrease_HP(int hp, int streght)
        {
            return hp-streght;
        }


    }
}
