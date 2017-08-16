using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class ItemType
    {
        private string TypeName;
        private string TypeDescription;
        public ItemType(string name, string description)
        {
            TypeName = name;
            TypeDescription = description;
        }
        override public string ToString()
        {
            return TypeName;
        }
    }
}
