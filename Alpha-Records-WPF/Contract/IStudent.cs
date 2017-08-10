using System.Collections.Generic;

namespace Alpha_Records_WPF.Contracts
{
    public interface IStudent
    {
        IContactInfo ContactInfo { get; }

        ITeam Team { get; }

        IEnumerable<IPresentation> Presentations { get; }

        IBook Book { get; }
    }
}
