using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryans_Late_Fee_Calculator
{
    public class ListItem
    {
        public string Text { get; set; }
        public RentalItem Value { get; set; }

        public override string ToString()
        {
            return Value.GetDisplayText();
        }
    }
}
