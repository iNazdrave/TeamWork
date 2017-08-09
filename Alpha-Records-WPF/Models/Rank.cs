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
            this.owner = owner;
            this.points = points;
        }

        public string Owner { get { return this.owner; } }
        public int Points { get { return this.points; } }
    }
}
