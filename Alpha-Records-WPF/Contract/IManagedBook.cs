namespace Alpha_Records_WPF.Contracts
{
    public interface IManagedBook
    {
        string Status { get; set; }

        string TakenOn { get; set; }

        string TakenBy { get; set; }
    }
}
