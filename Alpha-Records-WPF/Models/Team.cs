using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Records_WPF.Models
{
    public class Team
    {
        public string Name { get; set; }

        public IEnumerable<Student> Members { get; set; }

    }
}
