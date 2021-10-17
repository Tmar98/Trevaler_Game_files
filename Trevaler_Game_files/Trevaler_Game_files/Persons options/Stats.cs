using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trevaler_Game_files.Persons_options
{
    public class Stats
    {
        public int Strenght;

        //ловкость
        //мана
        //интелект

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

        public Stats()
        { }

        public Stats(int strenght, int hp)
        {
            Strenght = strenght;
            HP = hp;
        }
    }
}
