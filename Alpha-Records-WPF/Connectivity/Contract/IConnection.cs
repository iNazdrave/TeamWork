namespace Alpha_Records_WPF.Connectivity.Contract
{
    public interface IConnection
    {
        bool Connect(string url);

        void GetData();

    }
}
