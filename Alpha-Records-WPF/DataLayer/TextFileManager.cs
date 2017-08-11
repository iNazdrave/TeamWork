using Alpha_Records_WPF.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha_Records_WPF.Contracts;
using System.IO;
using Alpha_Records_WPF.Factory;

namespace Alpha_Records_WPF.DataLayer
{
    public class TextFileManager : IDataManager
    {
        private static readonly TextFileManager instance = new TextFileManager();

        private TextFileManager() { }

        public static TextFileManager Instance
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
            List<IContactInfo> result = new List<IContactInfo>(64);
            string path = @"D:\Documents\Visual Studio 2017\Projects\TeamWork\Alpha-Records-WPF\DataLayer\StudentRecords.txt";

            List<string> lines = new List<string>(64);
            using (StreamReader reader = new StreamReader(path))
            {
                foreach (var item in reader.ReadToEnd().Split('\n'))
                {
                    var holder = item.Split('#');
                    result.Add(ModelsFactory.Instance.CreateContactInfo(holder));
                }
            }
            return result;
        }

        public IEnumerable<IManagedBook> GetManagedBooks()
        {
            List<IManagedBook> result = new List<IManagedBook>(64);
            string path = @"D:\Documents\Visual Studio 2017\Projects\TeamWork\Alpha-Records-WPF\DataLayer\StudentRecords.txt";

            List<string> lines = new List<string>(64);
            using (StreamReader reader = new StreamReader(path))
            {
                foreach (var item in reader.ReadToEnd().Split('\n'))
                {
                    var holder = item.Split('#');
                    result.Add(ModelsFactory.Instance.CreateManagedBook(holder));
                }
            }
            return result;
        }

        public IEnumerable<IPresentation> GetPresentations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IStudent> GetStudents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITeam> GetTeams()
        {
            throw new NotImplementedException();
        }

    }
}
