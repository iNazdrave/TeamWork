﻿using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;

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
            this.EMail = email;
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Name)));
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Username)));
            }
        }

        public string EMail
        {
            get
            {
                return this.email;
            }

            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.EMail)));
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.PhoneNumber)));
            }
        }        
    }
}
