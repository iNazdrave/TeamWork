using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System.Collections.Generic;

namespace Alpha_Records_WPF.Models
{
    public class Student : IStudent
    {
        private IContactInfo contactInfo;
        private IEnumerable<IPresentation> presentations;
        private IBook book;
        private string team;

        public Student(IContactInfo contactInfo, IEnumerable<IPresentation> presentations, IBook book, string teamName)
        {
            this.ContactInfo = contactInfo;
            this.Presentations = presentations;
            this.Book = book;
            this.Team = teamName;
        }

        public IContactInfo ContactInfo
        {
            get
            {
                return this.contactInfo;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.ContactInfo)));
                this.contactInfo = value;
            }
        }

        public IEnumerable<IPresentation> Presentations
        {
            get
            {
                return this.presentations;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Presentations)));
                this.presentations = value;
            }
        }

        public IBook Book
        {
            get
            {
                return this.book;
            }
            set
            {
                this.book = value;
            }
        }

        public string Team
        {
            get
            {
                return this.team;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Team)));
                this.team = value;
            }
        }
    }
}
