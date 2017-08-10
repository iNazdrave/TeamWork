using System.Collections.Generic;

namespace Alpha_Records_WPF.Contracts
{
    public interface ITeam
    {
         string Name { get;}

         IEnumerable<IStudent> Members { get; }
    }
}
