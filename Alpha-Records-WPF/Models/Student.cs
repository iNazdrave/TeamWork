using Alpha_Records_WPF.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha_Records_WPF.Contracts;

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
                if (true)
                {
                    throw new NotImplementedException();
                }
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
                if (true)
                {
                    throw new NotImplementedException();
                }
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
                if (true)
                {
                    throw new NotImplementedException();
                }
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
                if (true)
                {
                    throw new NotImplementedException();
                }
                this.team = value;
            }
        }
    }
}
