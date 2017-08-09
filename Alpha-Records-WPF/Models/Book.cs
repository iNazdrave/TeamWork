using Alpha_Records_WPF.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Models
{
    public class Book : IBook
    {
        public string Title { get; set; }

        public string Autor { get; set; }

        public string Language { get; set; }
    }
}
