using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class DataBase
    {
        private List<Item> Items;
        private ItemBuilder itemBuilder;

        public DataBase()
        {
            itemBuilder = new ItemBuilder();
        }
        public void AddItem(RawItemData itemData)
        {
            Item item = itemBuilder.BuildItem(itemData);
            Items.Add(item);
        }
    }
}
