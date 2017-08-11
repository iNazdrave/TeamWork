using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System;

namespace Alpha_Records_WPF.Models
{
    public class ManagedBook : Book, IManagedBook, IBook
    {
        private string status;
        private DateTime takenOn;
        private string takenBy;

        public ManagedBook(string title, string author, string language, string status, DateTime takenOn, string takenBy)
            : base(title, author, language)
        {
            Status = status;
            TakenOn = takenOn;
            TakenBy = takenBy;
        }

        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Status)));
                this.status = value;
            }
        }

        public DateTime TakenOn
        {
            get
            {
                return this.takenOn;
            }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.TakenOn)));
                this.takenOn = value;
            }
        }

        public string TakenBy
        {

            get
            {
                return this.takenBy;
            }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.TakenBy)));
                this.takenBy = value;
            }
        }
    }
}

