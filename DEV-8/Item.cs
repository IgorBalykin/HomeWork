using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class Item
    {
        private ItemType type;
        private string name;
        uint quantity;
        decimal price;
        public Item(ItemType type, string name, uint quantity, decimal price)
        {
            this.type = type;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
