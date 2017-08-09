using Alpha_Records_WPF.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (true)
                {
                    throw new NotImplementedException();
                }
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
                if (true)
                {
                    throw new NotImplementedException();
                }
                this.name = value;
            }
        }
    }
}
