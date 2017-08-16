using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    enum ItemBuilderBuildStatus
    {
        OK = 0,
        UNSOLVABLE_PROBLEM = 1
    }
    class ItemBuilder
    {
        private string CANT_BUILD_EXCEPTION_MSG = "ItemBuilder can't create item for some reason";

        ItemTypeController TypeController;

        public ItemBuilder()
        {
            TypeController = new ItemTypeController();
        }
        public ItemBuilder(ItemTypeController TypeController)
        {
            this.TypeController = TypeController;
        }
        public Item BuildItem(RawItemData item, string description = "")
        {
            string typeName = item.typeName;
            string name = item.name;
            uint quantity = item.quantity;
            decimal price = item.price;
            ItemType type;
            if (TypeController.IfItemTypeExists(typeName))
            {
                type = TypeController.FindType(typeName);
            }
            else
            {
                if (TypeController.AddNewType(name,description)==ItemTypeControllerAddErrors.OK)
                {
                    type = TypeController.FindType(typeName);
                }
                else
                {
                    throw new Exception(CANT_BUILD_EXCEPTION_MSG);
                }
            }
            return new Item(TypeController.FindType(typeName), name, quantity, price);
        }
    }
}
