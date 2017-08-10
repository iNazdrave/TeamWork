using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System.Collections.Generic;

namespace Alpha_Records_WPF.Models
{
    public class Student : IStudent
    {

        public Student(IBook book,IContactInfo contactInfo,IEnumerable<IPresentation> presentations,ITeam team)
        {
            this.Team = team;
            this.ContactInfo = contactInfo;
            this.Presentations = presentations;
            this.Team = team;
        }

        private IBook book;
        private IContactInfo contactInfo;
        private IEnumerable<IPresentation> presentations;
        private ITeam team;

        public IBook Book
        {
            get
            {
                return this.book;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Book)));
                this.book = value;
            }
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

        public ITeam Team
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
