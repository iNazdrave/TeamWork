using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Contract
{
    interface IManagerBook
    {
        string Status { get; set; }

        string TakenOn { get; set; }

        string TakenBy { get; set; }
    }
}
