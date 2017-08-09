using Alpha_Records_WPF.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Model
{
    public class ContactInfo : IContactInfo
    {
        private string name;
        private string username;
        private string email;
        private string phoneNumber;

        public ContactInfo(string name, string username, string email, string phoneNumber)
        {
            this.Name = name;
            this.Username = username;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                throw new NotImplementedException();
                this.name = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                throw new NotImplementedException();
                this.username = value;

            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                throw new NotImplementedException();
                this.email = value;
            }
        }

        public string EMail => throw new NotImplementedException();

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            private set
            {
                throw new NotImplementedException();
                this.phoneNumber = value;
            }
        }        
    }
}
