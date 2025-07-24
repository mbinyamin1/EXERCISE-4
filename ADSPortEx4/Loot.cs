using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    class Loot : IComparable
    {
        private string name;
        private double lootvalue;

        public Loot(string name, double lootvalue)
        {
            this.name = name;
            this.lootvalue = lootvalue;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double LootValue
        {
            get { return lootvalue; }
            set { lootvalue = value; }
        }

        public int CompareTo(object obj)
        {
            Loot other = (Loot)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
