using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class DataBaseConnector
    {
        private string CANT_REACH_DATABASE_MSG = "Database unreachable";

        private DataBase dataBase; 

        public DataBaseConnector(DataBase dataBase)
        {
            if(!Connect(dataBase))
            {
                throw new Exception(CANT_REACH_DATABASE_MSG);
            }
        }
        public DataBaseConnector()
        {

        }
        public bool Connect(DataBase dataBase)
        {
            try
            {
                this.dataBase = dataBase;
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
