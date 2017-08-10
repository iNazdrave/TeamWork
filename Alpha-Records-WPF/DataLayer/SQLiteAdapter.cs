using SQLite;

namespace Alpha_Records_WPF.DataLayer
{
    public class SQLiteAdapter
    {
        private readonly SQLiteConnection conn = new SQLiteConnection("alpha_records.db");
        private static readonly SQLiteAdapter instance = new SQLiteAdapter();

        private SQLiteAdapter()
        {
            //ai molq ti sa
        }

        public static SQLiteAdapter Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
