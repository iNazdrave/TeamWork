using Alpha_Records_WPF.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Models
{
    public class ManagedBook : IManagerBook
    {
        private string status;
        private string takenOn;
        private string takenBy;

        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                //valid;
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
                //valid;
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
                //valid;
                this.takenBy = value;
            }
        }
    }
}

