using Alpha_Records_WPF.Models;
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
        private const string TABLE_STUDENTS = "STUDENTS";
        private const string COLUMN_CONTACT_INFO = "contact_info";
        private const string COLUMN_TEAM = "team";
        private const string COLUMN_PRESENTATIONS = "presentations";
        private const string COLUMN_BOOK = "book";

        private readonly string CREATE_STUDENTS = "CREATE TABLE IF NOT EXISTS " + TABLE_STUDENTS +
            "(id int, " + COLUMN_CONTACT_INFO + " int, " +
            COLUMN_TEAM + " int, " + COLUMN_PRESENTATIONS + " int, " + COLUMN_BOOK + " int)";

        private const string TABLE_CONTACT_INFOS = "CONTACT_INFOS";
        private const string COLUMN_NAME = "name";
        private const string COLUMN_USERNAMES = "usernames";
        private const string COLUMN_EMAIL = "mail";
        private const string COLUMN_PHONE = "phone";

        private readonly string CREATE_CONTACT_INFOS = "CREATE TABLE IF NOT EXISTS " + TABLE_CONTACT_INFOS +
            "(id int, " + COLUMN_NAME + " text, " +
            COLUMN_USERNAMES + " text, " + COLUMN_EMAIL + " text, " + COLUMN_PHONE + " text)";

        private const string TABLE_MANAGED_BOOKS = "MANAGED_BOOKS";
        private const string COLUMN_TITLE = "title";
        private const string COLUMN_AUTHOR = "author";
        private const string COLUMN_STATUS = "status";
        private const string COLUMN_TAKEN_BY = "taken_by";
        private const string COLUMN_TAKEN_ON = "taken_on";

        private readonly string CREATE_MANAGED_BOOKS = "CREATE TABLE IF NOT EXISTS " + TABLE_MANAGED_BOOKS +
            "(id int, " + COLUMN_TITLE + " text, " +
            COLUMN_AUTHOR + " text, " + COLUMN_STATUS + " int, " + COLUMN_TAKEN_BY + " int, " + COLUMN_TAKEN_ON + " text)";

        private const string TABLE_PRESENTATIONS = "PRESENTATIONS";
        private const string COLUMN_LECTOR = "lector";
        private const string COLUMN_TOPIC = "topic";
        private const string COLUMN_DATE = "date";

        private const string CREATE_PRESENTATIONS = "CREATE TABLE IF NOT EXISTS " + TABLE_PRESENTATIONS +
            "(id int, " + COLUMN_LECTOR + " int, " +
            COLUMN_TOPIC + " text, " + COLUMN_DATE + " text)";

        private const string TABLE_RANKS = "RANKS";
        private const string COLUMN_OWNER = "owner";
        private const string COLUMN_POINTS = "points";

        public SQLiteDataBase(SQLiteConnection conn)
        {
            var createStudents = conn.CreateCommand(CREATE_STUDENTS);
            createStudents.ExecuteNonQuery();
            var createContactInfos = conn.CreateCommand(CREATE_CONTACT_INFOS);
            createContactInfos.ExecuteNonQuery();
            var createManagedBooks = conn.CreateCommand(CREATE_MANAGED_BOOKS);
            createContactInfos.ExecuteNonQuery();
            var createPresentations = conn.CreateCommand(CREATE_PRESENTATIONS);
            createContactInfos.ExecuteNonQuery();
        }



    }
}
