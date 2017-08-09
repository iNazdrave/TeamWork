using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Models
{
    public class Rank
    {
        private string owner;
        private int points;

        public Rank(string owner, int points)
        {
            this.Owner = owner;
            this.Points = points;
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (true)
                {
                    throw new NotImplementedException();
                }
                this.owner = value;
            }
        }
        public int Points {
            get
            {
                return this.points;
            }
            private set
            {
                if (true)
                {
                    throw new NotImplementedException();
                }
                this.points = value;
            }
        }
    }
}
