using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trevaler_Game_files.Interfeces_Person
{
    public interface IDecreaseHP
    {
        /// <summary>
        /// Уменьшение hp 
        /// </summary>
        /// <param name="hp">объект у которого отнимут хп</param>
        /// <param name="strenght">объект у которого берется сила атаки</param>
        /// <returns></returns>
        int Decrease_HP(int hp, int strenght);
    }
}
