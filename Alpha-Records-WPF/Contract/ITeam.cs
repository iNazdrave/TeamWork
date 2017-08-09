using Alpha_Records_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Contract
{
    public interface ITeam
    {
         string Name { get;}
         IEnumerable<IStudent> Members { get; }
    }
}
