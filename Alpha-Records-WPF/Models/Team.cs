using Alpha_Records_WPF.Contracts;
using Alpha_Records_WPF.Utils;
using System.Collections.Generic;

namespace Alpha_Records_WPF.Models
{
    public class Team : ITeam
    {
        public Team(string name,IEnumerable<IStudent> members)
        {
            this.Name = name;
            this.Members = members;
        }

        private IEnumerable<IStudent> members;
        private string name;

        public IEnumerable<IStudent> Members
        {
            get
            {
                return this.members;
            }

             private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Members)));
                this.members = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

           private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Name)));
                this.name = value;
            }
        }
    }
}
