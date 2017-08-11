using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System;

namespace Alpha_Records_WPF.Models
{
    public class Presentation : IPresentation
    {
        private DateTime date;
        private string lector;
        private string topic;

        public Presentation(DateTime date, string lector, string topic)
        {
            this.Date = date;
            this.Lector = lector;
            this.Topic = topic;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Date)));
                this.date = value;
            }
        }

        public string Lector
        {
            get
            {
                return this.lector;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Lector)));
                this.lector = value;
            }
        }

        public string Topic
        {
            get
            {
                return this.topic;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Topic)));
                this.topic = value;
            }
        }
    }
}
