using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class DataBaseOperations
    {
        private static DataBaseOperations db_oper;
        public static DataBaseOperations getSample()
        {
            if (db_oper == null)
                db_oper = new DataBaseOperations();
            return db_oper;
        }
    }
}
