using Alpha_Records_WPF.Connectivity;
using Alpha_Records_WPF.Connectivity.Contract;

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

        public TheCampAccount CreateTheCampAccount(string mail, string password)
        {
            return new TheCampAccount(mail, password);
        }

    }
}
