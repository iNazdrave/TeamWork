using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System;

namespace Alpha_Records_WPF.Models
{
    public class Presentation : IPresentation
    {
        private DateTime date;
        private string topic;

        public Presentation(DateTime date, string topic)
        {
            this.Date = date;
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
            }
        }
    }
}
