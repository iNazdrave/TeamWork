using Alpha_Records_WPF.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Contract
{
    public interface IStudent
    {
        IContactInfo ContactInfo { get; }
        ITeam Team { get; }
        IEnumerable<IPresentation> Presentations { get; }
        IBook Book { get; }
    }
}
