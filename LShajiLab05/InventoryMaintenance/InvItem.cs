using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    class InvItem
    {
        public int itemNo;
        public string description;
        public decimal price; 

        public InvItem() { }

        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price; 
        }
        public int ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string GetDisplayText(string spaces)
        {
            return itemNo.ToString() + spaces + description + "( " + price.ToString("c") + " )";


        }
    }
}
