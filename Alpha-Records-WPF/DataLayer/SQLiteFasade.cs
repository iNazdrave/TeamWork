using SQLite;

namespace Alpha_Records_WPF.DataLayer
{
    public class SQLiteFasade
    {
        private readonly SQLiteConnection conn = new SQLiteConnection("alpha_records.db");
        private static readonly SQLiteFasade instance = new SQLiteFasade();

        private SQLiteFasade()
        {
            //ai molq ti sa
        }

        public static SQLiteFasade Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
