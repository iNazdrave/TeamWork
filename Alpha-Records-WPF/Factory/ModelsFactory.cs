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

        public IManagedBook CreateManagedBook(string title, string autor, string language, string Status, string TakenOn, string TakenBy)
        {
            return new ManagedBook(title, autor, language);
        }

        public IContactInfo ContactInfo(string name, string username, string email, string phoneNumber)
        {
            return new ContactInfo(name, username, email, phoneNumber);
        }

        public IPresentation Presentation(DateTime date, string topic)
        {
            return new Presentation(date, topic);
        }

        public Rank Rank(string owner, int points)
        {
            return new Rank(owner, points);
        }

        public IStudent Student(IBook book, IContactInfo contactInfo, IEnumerable<IPresentation> presentations, ITeam team)
        {
            return new Student(book, contactInfo, presentations, team);
        }

        public ITeam Team(string name, IEnumerable<IStudent> members)
        {
            return new Team(name, members);
        }
    }
}
