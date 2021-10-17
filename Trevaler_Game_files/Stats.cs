using System;

namespace Trevaler_Game_files
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