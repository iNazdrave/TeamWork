using Alpha_Records_WPF.Connectivity.Contract;
using System;
using System.Net;

namespace Alpha_Records_WPF.Connectivity
{
    public class TheCampAccount : Account, IConnection
    {
        private readonly Uri fileUrl = new Uri("https://telerikacademy.sharepoint.com/_layouts/15/WopiFrame.aspx?docid=1a8c7b396c2de4147b74f7c110814bef0&authkey=Ac8OSzChMpcd8o8ncBIxDwY&action=view");
        public TheCampAccount(string mail, string password)
            : base(mail, password)
        {
            Client = new WebClient()
            {
                Credentials = new NetworkCredential(mail, password)
            };
        }

        public override WebClient Client
        {
            get;
            set;
        }

        public override void Connect()
        {
            
        }

        public override void GetData()
        {
            Client.OpenReadAsync(fileUrl);
            

        }
    }
}
