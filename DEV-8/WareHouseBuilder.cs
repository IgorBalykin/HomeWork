using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class WareHouseBuilder
    {
        public WareHouse Build(string WareHouseName, string Owner, DataBaseConnector connector)
        {
            return new WareHouse(WareHouseName, Owner, connector);
        }
        public WareHouse Build(string WareHouseName, string Owner)
        {
            DataBase database = new DataBase();
            DataBaseConnector connector = new DataBaseConnector(database);
            return new WareHouse(WareHouseName, Owner, connector);
        }
    }
}
