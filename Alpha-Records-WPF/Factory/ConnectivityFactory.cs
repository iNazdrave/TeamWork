using Alpha_Records_WPF.Connectivity;

namespace Alpha_Records_WPF.Factory
{
    public class ConnectivityFactory
    {
        private static readonly ConnectivityFactory instance = new ConnectivityFactory();
        private ConnectivityFactory() { }

        public static ConnectivityFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public Account CreateAccount(string mail, string password)
        {
            return new Account(mail, password);
        }

        public Connection CreateConnection(Account acc)
        {
            return new Connection(acc);
        }
    }
}
