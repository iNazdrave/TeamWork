using Alpha_Records_WPF.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Models
{
    public class Presentation : IPresentation
    {
        private DateTime date;
        private string topic;

        public Presentation(DateTime date, string topic)
        {
            this.date = date;
            this.topic = topic;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }
    }
}
