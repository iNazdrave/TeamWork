﻿using Alpha_Records_WPF.Utils;

namespace Alpha_Records_WPF.Connectivity
{
    public class Account
    {
        private string mail;
        private string password;

        public Account(string mail, string password)
        {
            this.Mail = mail;
            this.Password = password;
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                Validator.ValidateNull(value, "You need to write your email. You won`t get any spam. Man...");
                this.mail = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                Validator.ValidateNull(value, "You need to write your passwords so you can connect. No personal data will be stored");
                this.password = value;
            }
        }
    }
}
