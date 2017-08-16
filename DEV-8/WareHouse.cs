using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class WareHouse
    {
        private string wareHouseName;
        private string owner;
        private DataBaseConnector dataBaseConnector;

        public string WareHouseName { get => wareHouseName; set { } }
        public string Owner { get => owner; set { } }

        public WareHouse(string WareHouseName, string Owner, DataBaseConnector connector)
        {
            this.WareHouseName = WareHouseName;
            this.Owner = Owner;
            dataBaseConnector = connector;
        }

    }
}
