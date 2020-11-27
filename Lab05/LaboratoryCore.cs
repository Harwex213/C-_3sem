using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    partial class Laboratory
    {
        public void Set(int i, Technic technic)
        {
            this.technics[i - 1] = (Technic)technic.Clone();
        }

        public Technic Get(int i)
        {
            return this.technics[i - 1];
        }

        public void Add(Technic technic) => this.technics.Add(technic);
        public void Remove(Technic _) => this.technics.Remove(_);
        public void Display()
        {
            for (int i = 0; i < this.technics.Count; i++)
                this.technics[i].ToString();
        }
        public void Sort()
        {
            this.technics.Sort();
        }
    }
}
