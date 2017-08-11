using System;

namespace Alpha_Records_WPF.Contracts
{
    public interface IPresentation
    {
        DateTime Date { get; set; }
        string Lector { get; set; }
        string Topic { get; set; }
    }
}
