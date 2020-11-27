using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    abstract class Product
    {
        public virtual int Price { get; set; }
        public virtual string Name { get; set; } = "";
        public virtual string InfoAbout { get; set; }
        public virtual string Producer { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime Guarantee { get; set; } = new DateTime(2021, 1, 1);
        public virtual bool IsGuaranteeOn { get; set; } = true;
        public virtual bool IsProductSpoiled { get; set; } = false;

        public virtual void CheсkGuarantee()
        {
            if (DateTime.Now > Guarantee)
                IsGuaranteeOn = false;
            else
                IsGuaranteeOn = true;
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Guarantee.GetHashCode() + Price.GetHashCode() + Name.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + $"Product Name: {Name}. Product Price: {Price}. Product Producer: {Producer}. Guarantee off date: {Guarantee}\n";
        }
    }
}
