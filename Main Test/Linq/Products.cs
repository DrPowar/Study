using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Test.Linq
{
    class Products
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public Products(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public override string ToString()
        {
            return $"{Name}, {Energy}";
        }
    }
}
