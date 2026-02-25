
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_adventure_game
{
    internal class Character
    {
        private string name;
        private List<string> inventory;

        public string Name
        {
            get;
            set;
        }
        public List<string> Inventory
        {             
            get;
            set;
        }

        public Character(string name, List<string> inventory) 
        { 
            Name = name;
            this.Inventory = inventory; 
        }
    }
}
