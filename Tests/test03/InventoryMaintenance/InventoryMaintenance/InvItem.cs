using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;

        //no parameter constructor
        public InvItem()
        {
        }

        // constructor with parameters
        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }

        // getter and setter for the variable
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        // overrideable method
        public virtual string GetDisplayText() => itemNo + "    " + description + " (" + price.ToString("c") + ")";
    }
}
