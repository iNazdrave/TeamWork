using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System.Text;

namespace Alpha_Records_WPF.Models
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Name)));
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Username)));
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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Email)));
                this.email = value;
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
                this.phoneNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Name: " + name);
            builder.AppendLine("Username: " + username);
            builder.AppendLine("Email: " + email);
            builder.AppendLine("Phone: " + phoneNumber);
            return builder.ToString();
        }
    }
}
