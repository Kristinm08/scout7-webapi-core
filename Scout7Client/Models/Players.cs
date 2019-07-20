using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scout7Client.Models
{
    public class Players
    {
        public string Guid { get; set; }
        public bool isActive { get; set; }
        public string Picture { get; set; }
        public int Age { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Goals { get; set; }
        public int Appearances { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Team Team { get; set; }

    }
}
