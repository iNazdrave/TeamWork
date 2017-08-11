using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.DataLayer.Contracts;
using SQLite;
using System;
using System.Collections.Generic;

namespace Alpha_Records_WPF.DataLayer
{
    public class SQLiteManager : IDataManager
    {
        private readonly SQLiteConnection conn;
        private static readonly SQLiteManager instance = new SQLiteManager();

        private SQLiteManager()
        {
            conn = new SQLiteConnection("alpha_records.db");
            new SQLiteDataBase(conn);

        }

        public static SQLiteManager Instance
        {
            get
            {
                return instance;
            }
        }

        public IEnumerable<IStudent> GetStudents()
        {
            return conn.CreateCommand("SELECT * FROM STUDENTS").ExecuteQuery<IStudent>();
        }

        public IEnumerable<IContactInfo> GetContactInfos()
        {
            return conn.CreateCommand("SELECT * FROM CONTACT_INFOS").ExecuteQuery<IContactInfo>();
        }

        public IEnumerable<IManagedBook> GetManagedBooks()
        {
            return conn.CreateCommand("SELECT * FROM MANAGED_BOOKS").ExecuteQuery<IManagedBook>(); ;
        }

        public IEnumerable<IPresentation> GetPresentations()
        {
            return conn.CreateCommand("SELECT * FROM PRESENTATIONS").ExecuteQuery<IPresentation>();
        }

        public void AddOrUpdateStudent(IStudent student)
        {
            conn.InsertOrReplace(student);
        }

        public void AddOrUpdateContactInfo(IContactInfo contactInfo)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdateManagedBook(IManagedBook managedBook)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdatePresentation(IPresentation presentation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITeam> GetTeams()
        {
            throw new NotImplementedException();
        }
    }
}
