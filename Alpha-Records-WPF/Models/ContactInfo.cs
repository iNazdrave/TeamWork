using Alpha_Records_WPF.Contracts;
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
<<<<<<< HEAD
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Name)));
=======
                throw new NotImplementedException();
                this.name = value;
>>>>>>> ec52b6c66d993e7eb8202a592ecfc6902b64bb06
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
<<<<<<< HEAD
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Username)));
=======
                throw new NotImplementedException();
                this.username = value;

>>>>>>> ec52b6c66d993e7eb8202a592ecfc6902b64bb06
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
<<<<<<< HEAD
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.EMail)));
=======
                throw new NotImplementedException();
                this.email = value;
>>>>>>> ec52b6c66d993e7eb8202a592ecfc6902b64bb06
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
<<<<<<< HEAD
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.PhoneNumber)));
=======
                throw new NotImplementedException();
                this.phoneNumber = value;
>>>>>>> ec52b6c66d993e7eb8202a592ecfc6902b64bb06
            }
        }        
    }
}
