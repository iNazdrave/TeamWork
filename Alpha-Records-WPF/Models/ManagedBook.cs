using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;

namespace Alpha_Records_WPF.Models
{
    public class ManagedBook : Book, IManagerBook 
    {
        private string status;
        private string takenOn;
        private string takenBy;

        public ManagedBook(string title, string autor, string language) 
            : base(title, autor, language)
        {
            this.Status = status;
            this.TakenOn = takenOn;
            this.TakenBy = takenBy;
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

        public string TakenOn
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

