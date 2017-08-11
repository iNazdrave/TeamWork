using System;

namespace Alpha_Records_WPF.Contracts
{
    public interface IManagedBook : IBook
    {
        string Status { get; set; }

        DateTime TakenOn { get; set; }

        string TakenBy { get; set; }
    }
}
