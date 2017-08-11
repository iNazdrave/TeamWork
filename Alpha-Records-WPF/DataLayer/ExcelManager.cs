using Alpha_Records_WPF.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha_Records_WPF.Contracts;

namespace Alpha_Records_WPF.DataLayer
{
    public class ExcelManager : IDataManager
    {
        private static readonly ExcelManager instance = new ExcelManager();

        private ExcelManager() { }

        public static ExcelManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void AddOrUpdateContactInfo(IContactInfo contactInfo)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdateManagedBook(IManagedBook managedBook)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdatePresentation(IPresentation presentation)
        {
            throw new NotImplementedException();
        }

        public void AddOrUpdateStudent(IStudent student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IContactInfo> GetContactInfos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IManagedBook> GetManagedBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPresentation> GetPresentations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IStudent> GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
