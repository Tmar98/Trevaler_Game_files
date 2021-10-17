using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trevaler_Game_files.Person_child;

namespace Trevaler_Game_files.Terretory_Files
{
    public class Terretory
    {
        private string _name;
        public string Name;

        private List<Monster> _monsters;
        public List<Monster> Monsters;


        public Terretory()
        { }
        public Terretory(string name, List<Monster> monsters) : base()
        { }
    }
}
