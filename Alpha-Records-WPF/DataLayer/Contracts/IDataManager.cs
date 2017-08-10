using Alpha_Records_WPF.Contracts;
using System.Collections.Generic;

namespace Alpha_Records_WPF.DataLayer.Contracts
{
    public interface IDataManager
    {
        IEnumerable<IManagedBook> ManagedBooks { get; }

        void AddManagedBook(IManagedBook managedBook);

        IEnumerable<IContactInfo> ContactInfos { get; }

        void AddContactInfo(IContactInfo contactInfo);

        IEnumerable<IPresentation> Presentations { get; }

        void AddPresentation(IPresentation presentation);

        IEnumerable<IStudent> Students { get; }

        void AddStudent(IStudent student);




    }
}
