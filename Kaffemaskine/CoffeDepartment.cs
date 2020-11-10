using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    /// <summary>
    /// The department that holds the filter and the coffee powder
    /// </summary>
    public class CoffeDepartment
    {

        private Filter cFilter;

        public Filter CFilter
        {
            get { return cFilter; }
            set { cFilter = value; }
        }

        private Powder cPowder;

        public Powder CPowder
        {
            get { return cPowder; }
            set { cPowder = value; }
        }


        public CoffeDepartment()
        {
            CFilter = null;
            cPowder = new Powder();
        }

        public void Fill(Powder PowderType)
        {
            this.cPowder.Amount = 100;
            this.cPowder = PowderType;
            this.cFilter = new Filter();
        }

        public bool HasPowder()
        {
            return (this.cPowder != null);
        }
        public bool HasFilter()
        {
            return (this.cFilter != null);
        }
        
        public void Empty()
        {
            this.cFilter = null;
            this.cPowder = null;
        }
    }
}
