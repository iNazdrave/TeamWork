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

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string EMail
        {
            get
            {
                return this.email;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                throw new NotImplementedException();
            }
        }        
    }
}
