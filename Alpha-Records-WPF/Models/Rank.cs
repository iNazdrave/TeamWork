using Alpha_Records_WPF.Utils;

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
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Owner)));
                this.owner = value;
            }
        }
        public int Points
        {
            get
            {
                return this.points;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Points)));
                this.points = value;
            }
        }
    }
}
