namespace Alpha_Records_WPF.Contracts
{
    public interface IManagerBook
    {
        string Status { get; set; }

        string TakenOn { get; set; }

        string TakenBy { get; set; }
    }
}
