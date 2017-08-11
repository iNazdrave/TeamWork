using Alpha_Records_WPF.Contracts;
using System.Collections.Generic;
using System.Collections;

namespace Alpha_Records_WPF.DataLayer.Contracts
{
    public interface IDataManager
    {
        IEnumerable<IStudent> GetStudents();

        void AddOrUpdateStudent(IStudent student);

        IEnumerable<IContactInfo> GetContactInfos();

        void AddOrUpdateContactInfo(IContactInfo contactInfo);

        IEnumerable<IManagedBook> GetManagedBooks();

        void AddOrUpdateManagedBook(IManagedBook managedBook);

        IEnumerable<IPresentation> GetPresentations();

        void AddOrUpdatePresentation(IPresentation presentation);

        IEnumerable<ITeam> GetTeams();

    }
}
