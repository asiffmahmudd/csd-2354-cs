using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant:InvItem
    {
        private string size;

        //no parameter constructor
        public Plant()
        {
        }

        // constructor with parameters
        public Plant(int itemNo, string description, decimal price, string size)
            :base(itemNo, description, price)
        {
            this.size = size;
        }

        // getter and setter for the variable
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        //overriding the base class method
        public string GetDisplayText()
        {
            return this.size + "\t" + base.GetDisplayText();
        }
    }
}
