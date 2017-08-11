using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Models;
using System;
using System.Collections.Generic;

namespace Alpha_Records_WPF.Factory
{
    public class ModelsFactory
    {
        private static readonly ModelsFactory instance = new ModelsFactory();
        private ModelsFactory() { }

        public static ModelsFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public IManagedBook CreateManagedBook(string title, string autor, string language, string status, DateTime takenOn, string takenBy)
        {
            return new ManagedBook(title, autor, language, status, takenOn, takenBy);
        }

        public IContactInfo CreateContactInfo(string name, string username, string email, string phoneNumber)
        {
            return new ContactInfo(name, username, email, phoneNumber);
        }

        public IContactInfo CreateContactInfo(string[] data)
        {
            string name = (data.Length > 0) ? data[0] : string.Empty;
            string username = (data.Length > 1) ? data[1] : string.Empty;
            string email = (data.Length > 2) ? data[2] : string.Empty;
            string phone = (data.Length > 3) ? data[3] : string.Empty;
            return new ContactInfo(name, username, email, phone);
        }

        public IPresentation CreatePresentation(DateTime date, string lector, string topic)
        {
            return new Presentation(date, lector, topic);
        }

        public Rank CreateRank(string owner, int points)
        {
            return new Rank(owner, points);
        }

        public IStudent CreateStudent(IContactInfo contactInfo, IEnumerable<IPresentation> presentations, IBook book, string team)
        {
            return new Student(contactInfo, presentations, book, team);
        }

        public ITeam CreateTeam(string name, IEnumerable<IStudent> members)
        {
            return new Team(name, members);
        }

        public IManagedBook CreateManagedBook(string[] data)
        {
            string title, author, language, status, takenBy;
            DateTime takenOn = new DateTime();
            title = (data.Length > 0) ? data[0] : string.Empty;
            author = (data.Length > 1) ? data[1] : string.Empty;
            language = (data.Length > 2) ? data[2] : string.Empty;
            status = (data.Length > 3) ? data[3] : string.Empty;
            if (data.Length > 4)
            {
                takenOn = DateTime.Parse(data[4]);
            }

            takenBy = (data.Length > 5) ? data[5] : string.Empty;
            return new ManagedBook(title, author, language, status, takenOn, takenBy);
        }
    }
}
