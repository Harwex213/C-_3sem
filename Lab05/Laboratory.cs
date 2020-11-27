using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    partial class Laboratory
    {
        protected List<Technic> technics = new List<Technic>();
        public int Length { get => this.technics.Count; }
        public Laboratory() { }
    }
}
