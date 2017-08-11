using System.Net;

namespace Alpha_Records_WPF.Connectivity.Contract
{
    public interface IConnection
    {
        WebClient Client { get;}

        void Connect();

        void GetData();

    }
}
