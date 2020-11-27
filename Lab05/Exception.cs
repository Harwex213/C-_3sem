using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class TechnicException : ApplicationException
    {
        public TechnicException(string message = "**** Error in Technic! ****") : base(message) { }
        static public void CheckTechnic(Technic temp)
        {
            if (temp.Price < 0)
                throw new TabletException("Price can not be a negative number");

            if (temp.Producer == null)
                throw new ArgumentNullException();

            if (temp.InfoAbout == null)
                throw new ArgumentNullException();
        }
    }

    class TabletException : TechnicException
    {
        public TabletException(string message = "**** Some error in TabletException! ****") : base(message) { }

        static public void ChekTablet(Tablet temp)
        {
            if (!temp.IsGuaranteeOn)
                throw new ComputerException("Guarantee of this Tablet is over!");
        }
    }

    class ComputerException : TechnicException
    {
        public ComputerException(string message = "**** Some error in TabletException! ****") : base(message) { }

        static public void ChekComputer(Computer temp)
        {
            if (!temp.IsProductSpoiled)
                throw new ComputerException("This Computer is die!");
        }
    }
}
