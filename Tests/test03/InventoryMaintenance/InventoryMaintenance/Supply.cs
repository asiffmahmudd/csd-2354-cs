using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        private string manufacturer;

        //no parameter constructor
        public Supply() { }

        // constructor with parameters
        public Supply(int itemNo, string description, decimal price, string manufacturer)
            : base(itemNo, description, price)
        {
            this.manufacturer = manufacturer;
        }

        // getter and setter for the variable
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        //overriding the base class method
        public override string GetDisplayText()
        {
            return this.manufacturer + "\t" + base.GetDisplayText();
        }
    }
}
