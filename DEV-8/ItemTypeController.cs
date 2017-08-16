using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    enum ItemTypeControllerAddErrors
    {
        OK = 0,
        ITEM_ALREADY_EXISTS = 1
    }
    class ItemTypeController
    {
        private List<ItemType> AvailableTypes;
        public bool IfItemTypeExists(string name)
        {
            foreach (var type in AvailableTypes)
            {
                if (type.ToString() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public ItemTypeControllerAddErrors AddNewType(string name, string description)
        {
            if(IfItemTypeExists(name))
            {
                return ItemTypeControllerAddErrors.ITEM_ALREADY_EXISTS;
            }
            else
            {
                AvailableTypes.Add(new ItemType(name, description));
                return ItemTypeControllerAddErrors.OK;
            }
        }
        public ItemType FindType(string name)
        {
            foreach (var type in AvailableTypes)
            {
                if (type.ToString() == name)
                {
                    return type;
                }
            }
            return null;
        }
    }
}
