using Alpha_Records_WPF.Connectivity.Contract;
using Alpha_Records_WPF.Utils;
using System;

namespace Alpha_Records_WPF.Connectivity
{
    public class Connection : IConnection
    {
        private Account account;
        public Connection(Account account)
        {
            Validator.ValidateNull(account, "Account must not be null!");
            this.account = account;
        }

        public bool Connect(string url)
        {
            throw new NotImplementedException();
        }

        public void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
