using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.DataLayer
{
    class SQLiteDataBase
    {

        private SQLiteConnection db = new SQLiteConnection("alpha.db");

        public SQLiteConnection DB { get { return this.db; } }

        public SQLiteDataBase()
        {
            db.CreateTable<ContactInfo>();
        }
    }
}
