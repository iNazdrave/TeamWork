using System;
using System.Collections.Generic;
using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.DataLayer.Contracts;
using SQLite;

namespace Alpha_Records_WPF.DataLayer
{
    public class SQLiteFasade : IDataManager
    {
        private readonly SQLiteConnection conn = new SQLiteConnection("alpha_records.db");
        private static readonly SQLiteFasade instance = new SQLiteFasade();

        private SQLiteFasade()
        {

        }

        public static SQLiteFasade Instance
        {
            get
            {
                return instance;
            }
        }

        public IEnumerable<IStudent> GetStudents()
        {
            List<IStudent> students = new List<IStudent>();

            students = conn.CreateCommand("SELECT * FROM TABLE_STUDENTS").ExecuteQuery<IStudent>();

            return students;
        }

        public IEnumerable<IContactInfo> GetContactInfos()
        {
            List<IContactInfo> contactInfos = new List<IContactInfo>();
            contactInfos = conn.CreateCommand("SELECT * FROM TABLE_CONTACT_INFOS").ExecuteQuery<IContactInfo>();
            return contactInfos;
        }

        public IEnumerable<IManagedBook> GetManagedBooks()
        {
            List<IManagedBook> books = new List<IManagedBook>();
            books = conn.CreateCommand("SELECT * FROM TABLE_MANAGED_BOOKS").ExecuteQuery<IManagedBook>();
            return books;
        }

        public IEnumerable<IPresentation> GetPresentations()
        {
            List<IPresentation> presentations = new List<IPresentation>();

            return presentations;
        }

        public void AddOrUpdateStudent(IStudent student)
        {
            throw new NotImplementedException();
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
    }
}
