using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scout7Client.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Players> Players { get; set; }
        public PageViewModel PageViewModel { get; set; }

    }
}
